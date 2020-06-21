/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.CambioEstadoTicket;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.EstadoTicket;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.TransferenciaExterna;
import pe.edu.pucp.tablesoft.model.TransferenciaInterna;
import pe.edu.pucp.tablesoft.model.TransferenciaTicket;


public class TicketMySQL implements TicketDAO{
    Connection con;
    @Override
    public int insertar(Ticket ticket) {
        
        int out = 0;
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );
            
            CallableStatement cs = con.prepareCall("{CALL insertar_ticket(?,?,?,?,?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            
            cs.setString("_ASUNTO", ticket.getAsunto());
            cs.setString("_DESCRIPCION", ticket.getDescripcion());
            cs.setInt("_ESTADO_ID", ticket.getEstado().getEstadoId());
            cs.setInt("_EMPLEADO_ID", ticket.getEmpleado().getEmpleadoId());
            
            cs.setInt("_URGENCIA_ID", ticket.getUrgencia().getUrgenciaId());
            cs.setInt("_CATEGORIA_ID", ticket.getCategoria().getCategoriaId());
            
            int bibliotecaId = ticket.getBiblioteca().getBibliotecaId();
            if (bibliotecaId != 0){
                cs.setInt("_BIBLIOTECA_ID", bibliotecaId);
            } else{
                cs.setNull("_BIBLIOTECA_ID", java.sql.Types.INTEGER);
            }
            
            int activoFijoId = ticket.getActivoFijo().getActivoFijoId();
            if (activoFijoId != 0) {
                cs.setInt("_ACTIVO_FIJO_ID", activoFijoId);
            } else {
                cs.setNull("_ACTIVO_FIJO_ID", java.sql.Types.INTEGER);
            }
            
            String alumno_email = ticket.getAlumnoEmail();
            if("".equals(alumno_email)){
                cs.setNull("_ALUMNO_EMAIL", java.sql.Types.VARCHAR);
            }
            else{
                cs.setString("_ALUMNO_EMAIL", alumno_email);
            }
            
            cs.execute();
            
            out = cs.getInt("_ID");
            ticket.setTicketId(out);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return out;
    }

    @Override
    public int actualizar(Ticket ticket) {
        int out = 0;
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );
            
            if(ticket.getHistorialTransferencia() != null){
                for (TransferenciaTicket transfer : ticket.getHistorialTransferencia()){
                    if(transfer.getTransferenciaId() == 0){
                        transfer.setFecha(LocalDateTime.now());
                        if(transfer instanceof TransferenciaExterna){
                            CallableStatement cs1 = con.prepareCall("{CALL insertar_transferencia_externa(?,?,?,?,?)}");
                            cs1.registerOutParameter("_ID", java.sql.Types.INTEGER);
                            cs1.setInt("_TICKET_ID", ticket.getTicketId());
                            cs1.setInt("_AGENTE_ID", transfer.getAgenteResponsable().getAgenteId());
                            cs1.setString("_COMENTARIO", transfer.getComentario());
                            cs1.setInt("_PROVEEDOR_ID", ((TransferenciaExterna)transfer).getProveedorTo().getProveedorId());
                            cs1.execute();
                            transfer.setTransferenciaId(cs1.getInt("_ID"));
                        }
                        if(transfer instanceof TransferenciaInterna){
                            CallableStatement cs2 = con.prepareCall("{CALL insertar_transferencia_interna(?,?,?,?,?)}");
                            cs2.registerOutParameter("_ID", java.sql.Types.INTEGER);
                            cs2.setInt("_TICKET_ID", ticket.getTicketId());
                            cs2.setInt("_AGENTE_ID", transfer.getAgenteResponsable().getAgenteId());
                            cs2.setString("_COMENTARIO", transfer.getComentario());
                            cs2.setInt("_PROVEEDOR_ID", ((TransferenciaInterna)transfer).getCategoriaTo().getCategoriaId());
                            cs2.execute();
                            transfer.setTransferenciaId(cs2.getInt("_ID"));
                        }
                    }
                }
            }
            
            for (CambioEstadoTicket cambioEstado : ticket.getHistorialEstado()){
                if(cambioEstado.getCambioEstadoTicketId() == 0){
                    CallableStatement cs3 = con.prepareCall("{CALL insertar_cambio_estado_ticket(?,?,?,?,?)}");
                    cs3.registerOutParameter("_ID", java.sql.Types.INTEGER);
                    cs3.setInt("_TICKET_ID", ticket.getTicketId());
                    cs3.setString("_COMENTARIO", cambioEstado.getComentario());
                    cs3.setInt("_AGENTE_ID", cambioEstado.getAgenteResponsable().getAgenteId());
                    cs3.setInt("_ESTADO_ID_TO", cambioEstado.getEstadoTo().getEstadoId());
                    cs3.execute();
                    cambioEstado.setCambioEstadoTicketId(cs3.getInt("_ID"));
                }
            }
            
            
            CallableStatement cs = con.prepareCall(
                "{CALL actualizar_ticket(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}"
            );
            
            cs.setInt("_ID", ticket.getTicketId());
            cs.setString("_ASUNTO", ticket.getAsunto());
            cs.setString("_DESCRIPCION", ticket.getDescripcion());
            cs.setInt("_ESTADO_ID", ticket.getEstado().getEstadoId());
            
            if (ticket.getFechaCierreMaximo() != null){
                cs.setTimestamp("_FECHA_CIERRE_MAXIMO", Timestamp.valueOf(ticket.getFechaCierreMaximo()));
            }
            else {
                cs.setTimestamp("_FECHA_CIERRE_MAXIMO", null);
            }
            if (ticket.getFechaCierre() != null){
                cs.setTimestamp("_FECHA_CIERRE", Timestamp.valueOf(ticket.getFechaCierre()));
            }
            else{
                cs.setTimestamp("_FECHA_CIERRE", null);
            }
            
            cs.setInt("_EMPLEADO_ID", ticket.getEmpleado().getEmpleadoId());
            int agenteId = ticket.getAgente().getAgenteId();
            if (agenteId != 0){
                cs.setInt("_AGENTE_ID", agenteId );
            } else {
                cs.setNull("_AGENTE_ID", java.sql.Types.INTEGER);
            }            
            
            cs.setInt("_URGENCIA_ID", ticket.getUrgencia().getUrgenciaId());
            cs.setInt("_CATEGORIA_ID", ticket.getCategoria().getCategoriaId());
            int bibliotecaId = ticket.getBiblioteca().getBibliotecaId();
            if (bibliotecaId != 0){
                cs.setInt("_BIBLIOTECA_ID", bibliotecaId);
            } else{
                cs.setNull("_BIBLIOTECA_ID", java.sql.Types.INTEGER);
            }
            
            int proveedorId = ticket.getProveedor().getProveedorId();
            if (proveedorId != 0){
                cs.setInt("_PROVEEDOR_ID", proveedorId);
            } else{
                cs.setNull("_PROVEEDOR_ID", java.sql.Types.INTEGER);
            }
            int activoFijoId = ticket.getActivoFijo().getActivoFijoId();
            if (activoFijoId != 0) {
                cs.setInt("_ACTIVO_FIJO_ID", activoFijoId);
            } else {
                cs.setNull("_ACTIVO_FIJO_ID", java.sql.Types.INTEGER);
            }
            
            String alumno_email = ticket.getAlumnoEmail();
            if("".equals(alumno_email)){
                cs.setNull("_ALUMNO_EMAIL", java.sql.Types.VARCHAR);
            }
            else{
                cs.setString("_ALUMNO_EMAIL", alumno_email);
            }
            
            out = cs.executeUpdate();
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return out;
    }

    @Override
    public ArrayList<Ticket> listar() {
        ArrayList<Ticket> tickets = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );            

            CallableStatement cs = con.prepareCall("{CALL listar_ticket()}");
            ResultSet rs = cs.executeQuery();            
            
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaCierreMaximo = rs.getTimestamp("fecha_cierre_maximo");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setAsunto(rs.getString("asunto"));
                ticket.setDescripcion(rs.getString("descripcion"));
                
                ticket.getEstado().setEstadoId(rs.getInt("estado_id"));
                ticket.getEstado().setNombre(rs.getString("estado_nombre"));
                ticket.getEstado().setDescripcion(rs.getString("estado_descripcion"));
                ticket.getEstado().setActivo(rs.getBoolean("estado_activo"));
                
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaCierreMaximo != null) {
                    ticket.setFechaCierreMaximo(fechaCierreMaximo.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                
                ticket.getUrgencia().setUrgenciaId(rs.getInt("urgencia_id"));
                ticket.getUrgencia().setNombre(rs.getString("urgencia_nombre"));
                ticket.getUrgencia().setPlazoMaximo(rs.getInt("plazo_maximo"));
                ticket.getUrgencia().setActivo(rs.getBoolean("urgencia_activo"));
                
                ticket.getCategoria().setCategoriaId(rs.getInt("categoria_id"));
                ticket.getCategoria().setNombre(rs.getString("categoria_nombre"));
                ticket.getCategoria().setDescripcion(rs.getString("categoria_descripcion"));
                ticket.getCategoria().setActivo(rs.getBoolean("categoria_activo"));
                
                int bibliotecaId = rs.getInt("biblioteca_id");
                if(bibliotecaId != 0){
                    ticket.getBiblioteca().setBibliotecaId(bibliotecaId);
                    ticket.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    ticket.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    ticket.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                
                int activoFijoId = rs.getInt("activo_fijo_id");
                if(activoFijoId != 0){
                    ticket.getActivoFijo().setActivoFijoId(activoFijoId);
                }
                int proveedorId = rs.getInt("proveedor_id");
                if(proveedorId != 0){
                    ticket.getProveedor().setProveedorId(proveedorId);
                }
                
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                
                ticket.setRetrasado(rs.getBoolean("retrasado"));

                tickets.add(ticket);
            }
            
            for(Ticket tick : tickets){
                cs = con.prepareCall("{CALL buscar_empleado(?)}");
                cs.setInt("_ID", tick.getEmpleado().getEmpleadoId());
                rs = cs.executeQuery();
                while(rs.next()){
                    tick.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                    tick.getEmpleado().setCodigo(rs.getString("codigo"));
                    tick.getEmpleado().setDni(rs.getString("dni"));
                    tick.getEmpleado().setPersonaEmail(rs.getString("persona_email"));
                    tick.getEmpleado().setActivo(rs.getBoolean("activo"));
                    tick.getEmpleado().setNombre(rs.getString("nombre"));
                    tick.getEmpleado().setApellidoPaterno(rs.getString("apellido_paterno"));
                    tick.getEmpleado().setApellidoMaterno(rs.getString("apellido_materno"));
                    tick.getEmpleado().setDireccion(rs.getString("direccion"));
                    tick.getEmpleado().setTelefono(rs.getString("telefono"));
                    tick.getEmpleado().setTipo(rs.getString("tipo").charAt(0));
                    
                    tick.getEmpleado().getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                    tick.getEmpleado().getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    tick.getEmpleado().getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    tick.getEmpleado().getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                int agenteId = tick.getAgente().getAgenteId();
                if(agenteId != 0){
                    cs = con.prepareCall("{CALL buscar_agente(?)}");
                    cs.setInt("_ID", agenteId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getAgente().setAgenteId(rs.getInt("agente_id"));
                        tick.getAgente().setCodigo(rs.getString("codigo"));
                        tick.getAgente().setDni(rs.getString("dni"));
                        tick.getAgente().setPersonaEmail(rs.getString("persona_email"));
                        tick.getAgente().setAgenteEmail(rs.getString("agente_email"));
                        tick.getAgente().setActivo(rs.getBoolean("activo"));
                        tick.getAgente().setNombre(rs.getString("nombre"));
                        tick.getAgente().setApellidoPaterno(rs.getString("apellido_paterno"));
                        tick.getAgente().setApellidoMaterno(rs.getString("apellido_materno"));
                        tick.getAgente().setDireccion(rs.getString("direccion"));
                        tick.getAgente().setTelefono(rs.getString("telefono"));
                        tick.getAgente().setTipo(rs.getString("tipo").charAt(0));

                        tick.getAgente().getEquipo().setEquipoId(rs.getInt("equipo_id"));
                        tick.getAgente().getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                        tick.getAgente().getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                        tick.getAgente().getEquipo().setNombre(rs.getString("equipo_nombre"));
                        tick.getAgente().getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                        tick.getAgente().getRol().setRolId(rs.getInt("rol_id"));
                        tick.getAgente().getRol().setNombre(rs.getString("rol_nombre"));
                        tick.getAgente().getRol().setDescripcion(rs.getString("rol_descripcion"));
                        tick.getAgente().getRol().setActivo(rs.getBoolean("rol_activo"));
                    }
                }
                int proveedorId = tick.getProveedor().getProveedorId();
                if(proveedorId != 0){
                    cs = con.prepareCall("{CALL buscar_proveedor(?)}");
                    cs.setInt("_ID", proveedorId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad"));
                        tick.getProveedor().setDireccion(rs.getString("direccion"));
                        tick.getProveedor().setEmail(rs.getString("email"));
                        tick.getProveedor().setRazonSocial(rs.getString("razon_social"));
                        tick.getProveedor().setRuc(rs.getString("ruc"));
                        tick.getProveedor().setTelefono(rs.getString("telefono"));
                        tick.getProveedor().setActivo(rs.getBoolean("activo"));
                        
                        tick.getProveedor().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                        tick.getProveedor().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                        tick.getProveedor().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    }
                }
                int activoFijoId = tick.getActivoFijo().getActivoFijoId();
                if(activoFijoId != 0){
                    cs = con.prepareCall("{CALL buscar_activo_fijo(?)}");
                    cs.setInt("_ID", activoFijoId);
                    rs=cs.executeQuery();

                    while(rs.next()) {
                        tick.getActivoFijo().setActivoFijoId(rs.getInt("proveedor_id"));
                        tick.getActivoFijo().setNombre(rs.getString("nombre"));
                        tick.getActivoFijo().setCodigo(rs.getString("codigo"));
                        tick.getActivoFijo().setMarca(rs.getString("marca"));
                        tick.getActivoFijo().setTipo(rs.getString("tipo"));
                        tick.getActivoFijo().setActivo(rs.getBoolean("activo"));
                    }
                }
                
                // Listar historial de transferencias
                ArrayList<TransferenciaTicket> transferencias = new ArrayList<>();
                
                cs = con.prepareCall("{CALL listar_transferencia_externa(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaExterna transferExt = new TransferenciaExterna();

                    transferExt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferExt.setComentario(rs.getString("comentario"));
                    transferExt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferExt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferExt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferExt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferExt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferExt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferExt.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                    transferExt.getProveedorTo().setRuc(rs.getString("ruc"));
                    transferExt.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                    transferExt.getProveedorTo().setTelefono(rs.getString("proveedor_telefono"));
                    transferExt.getProveedorTo().setDireccion(rs.getString("proveedor_direccion"));
                    transferExt.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                    transferExt.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                    
                    transferExt.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                    transferExt.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    transferExt.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                    transferExt.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                    
                    transferencias.add(transferExt);
                }
                
                cs = con.prepareCall("{CALL listar_transferencia_interna(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaInterna transferInt = new TransferenciaInterna();

                    transferInt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferInt.setComentario(rs.getString("comentario"));
                    transferInt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferInt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferInt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferInt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferInt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferInt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferInt.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                    transferInt.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                    transferInt.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                    transferInt.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                    
                    transferencias.add(transferInt);
                }
                tick.setHistorialTransferencia(transferencias);
                
                // Listar historial de cambios de estado
                ArrayList<CambioEstadoTicket> cambiosEstado = new ArrayList<>();
                cs = con.prepareCall("{CALL listar_cambio_estado_ticket(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                    cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                    cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                    cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                    cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));

                    cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                    cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));

                    cambio.setComentario(rs.getString("comentario"));
                    cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                    cambiosEstado.add(cambio);
                }
                tick.setHistorialEstado(cambiosEstado);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }

    @Override
    public ArrayList<Ticket> listarxAgente(Agente agente) {
        ArrayList<Ticket> tickets = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );            

            CallableStatement cs = con.prepareCall("{CALL listar_ticket_agente(?)}");
            cs.setInt("_ID", agente.getAgenteId());
            ResultSet rs = cs.executeQuery();            
            
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaCierreMaximo = rs.getTimestamp("fecha_cierre_maximo");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setAsunto(rs.getString("asunto"));
                ticket.setDescripcion(rs.getString("descripcion"));
                
                ticket.getEstado().setEstadoId(rs.getInt("estado_id"));
                ticket.getEstado().setNombre(rs.getString("estado_nombre"));
                ticket.getEstado().setDescripcion(rs.getString("estado_descripcion"));
                ticket.getEstado().setActivo(rs.getBoolean("estado_activo"));
                
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaCierreMaximo != null) {
                    ticket.setFechaCierreMaximo(fechaCierreMaximo.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                
                ticket.getUrgencia().setUrgenciaId(rs.getInt("urgencia_id"));
                ticket.getUrgencia().setNombre(rs.getString("urgencia_nombre"));
                ticket.getUrgencia().setPlazoMaximo(rs.getInt("plazo_maximo"));
                ticket.getUrgencia().setActivo(rs.getBoolean("urgencia_activo"));
                
                ticket.getCategoria().setCategoriaId(rs.getInt("categoria_id"));
                ticket.getCategoria().setNombre(rs.getString("categoria_nombre"));
                ticket.getCategoria().setDescripcion(rs.getString("categoria_descripcion"));
                ticket.getCategoria().setActivo(rs.getBoolean("categoria_activo"));
                
                int bibliotecaId = rs.getInt("biblioteca_id");
                if(bibliotecaId != 0){
                    ticket.getBiblioteca().setBibliotecaId(bibliotecaId);
                    ticket.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    ticket.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    ticket.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                
                int activoFijoId = rs.getInt("activo_fijo_id");
                if(activoFijoId != 0){
                    ticket.getActivoFijo().setActivoFijoId(activoFijoId);
                }
                int proveedorId = rs.getInt("proveedor_id");
                if(proveedorId != 0){
                    ticket.getProveedor().setProveedorId(proveedorId);
                }
                
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                
                ticket.setRetrasado(rs.getBoolean("retrasado"));

                tickets.add(ticket);
            }
            
            for(Ticket tick : tickets){
                cs = con.prepareCall("{CALL buscar_empleado(?)}");
                cs.setInt("_ID", tick.getEmpleado().getEmpleadoId());
                rs = cs.executeQuery();
                while(rs.next()){
                    tick.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                    tick.getEmpleado().setCodigo(rs.getString("codigo"));
                    tick.getEmpleado().setDni(rs.getString("dni"));
                    tick.getEmpleado().setPersonaEmail(rs.getString("persona_email"));
                    tick.getEmpleado().setActivo(rs.getBoolean("activo"));
                    tick.getEmpleado().setNombre(rs.getString("nombre"));
                    tick.getEmpleado().setApellidoPaterno(rs.getString("apellido_paterno"));
                    tick.getEmpleado().setApellidoMaterno(rs.getString("apellido_materno"));
                    tick.getEmpleado().setDireccion(rs.getString("direccion"));
                    tick.getEmpleado().setTelefono(rs.getString("telefono"));
                    tick.getEmpleado().setTipo(rs.getString("tipo").charAt(0));
                    
                    tick.getEmpleado().getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                    tick.getEmpleado().getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    tick.getEmpleado().getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    tick.getEmpleado().getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                int agenteId = tick.getAgente().getAgenteId();
                if(agenteId != 0){
                    cs = con.prepareCall("{CALL buscar_agente(?)}");
                    cs.setInt("_ID", agenteId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getAgente().setAgenteId(rs.getInt("agente_id"));
                        tick.getAgente().setCodigo(rs.getString("codigo"));
                        tick.getAgente().setDni(rs.getString("dni"));
                        tick.getAgente().setPersonaEmail(rs.getString("persona_email"));
                        tick.getAgente().setAgenteEmail(rs.getString("agente_email"));
                        tick.getAgente().setActivo(rs.getBoolean("activo"));
                        tick.getAgente().setNombre(rs.getString("nombre"));
                        tick.getAgente().setApellidoPaterno(rs.getString("apellido_paterno"));
                        tick.getAgente().setApellidoMaterno(rs.getString("apellido_materno"));
                        tick.getAgente().setDireccion(rs.getString("direccion"));
                        tick.getAgente().setTelefono(rs.getString("telefono"));
                        tick.getAgente().setTipo(rs.getString("tipo").charAt(0));

                        tick.getAgente().getEquipo().setEquipoId(rs.getInt("equipo_id"));
                        tick.getAgente().getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                        tick.getAgente().getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                        tick.getAgente().getEquipo().setNombre(rs.getString("equipo_nombre"));
                        tick.getAgente().getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                        tick.getAgente().getRol().setRolId(rs.getInt("rol_id"));
                        tick.getAgente().getRol().setNombre(rs.getString("rol_nombre"));
                        tick.getAgente().getRol().setDescripcion(rs.getString("rol_descripcion"));
                        tick.getAgente().getRol().setActivo(rs.getBoolean("rol_activo"));
                    }
                }
                int proveedorId = tick.getProveedor().getProveedorId();
                if(proveedorId != 0){
                    cs = con.prepareCall("{CALL buscar_proveedor(?)}");
                    cs.setInt("_ID", proveedorId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad"));
                        tick.getProveedor().setDireccion(rs.getString("direccion"));
                        tick.getProveedor().setEmail(rs.getString("email"));
                        tick.getProveedor().setRazonSocial(rs.getString("razon_social"));
                        tick.getProveedor().setRuc(rs.getString("ruc"));
                        tick.getProveedor().setTelefono(rs.getString("telefono"));
                        tick.getProveedor().setActivo(rs.getBoolean("activo"));
                        
                        tick.getProveedor().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                        tick.getProveedor().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                        tick.getProveedor().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    }
                }
                int activoFijoId = tick.getActivoFijo().getActivoFijoId();
                if(activoFijoId != 0){
                    cs = con.prepareCall("{CALL buscar_activo_fijo(?)}");
                    cs.setInt("_ID", activoFijoId);
                    rs=cs.executeQuery();

                    while(rs.next()) {
                        tick.getActivoFijo().setActivoFijoId(rs.getInt("proveedor_id"));
                        tick.getActivoFijo().setNombre(rs.getString("nombre"));
                        tick.getActivoFijo().setCodigo(rs.getString("codigo"));
                        tick.getActivoFijo().setMarca(rs.getString("marca"));
                        tick.getActivoFijo().setTipo(rs.getString("tipo"));
                        tick.getActivoFijo().setActivo(rs.getBoolean("activo"));
                    }
                }
                
                // Listar historial de transferencias
                ArrayList<TransferenciaTicket> transferencias = new ArrayList<>();
                
                cs = con.prepareCall("{CALL listar_transferencia_externa(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaExterna transferExt = new TransferenciaExterna();

                    transferExt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferExt.setComentario(rs.getString("comentario"));
                    transferExt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferExt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferExt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferExt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferExt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferExt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferExt.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                    transferExt.getProveedorTo().setRuc(rs.getString("ruc"));
                    transferExt.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                    transferExt.getProveedorTo().setTelefono(rs.getString("proveedor_telefono"));
                    transferExt.getProveedorTo().setDireccion(rs.getString("proveedor_direccion"));
                    transferExt.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                    transferExt.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                    
                    transferExt.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                    transferExt.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    transferExt.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                    transferExt.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                    
                    transferencias.add(transferExt);
                }
                
                cs = con.prepareCall("{CALL listar_transferencia_interna(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaInterna transferInt = new TransferenciaInterna();

                    transferInt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferInt.setComentario(rs.getString("comentario"));
                    transferInt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferInt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferInt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferInt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferInt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferInt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferInt.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                    transferInt.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                    transferInt.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                    transferInt.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                    
                    transferencias.add(transferInt);
                }
                tick.setHistorialTransferencia(transferencias);
                
                // Listar historial de cambios de estado
                ArrayList<CambioEstadoTicket> cambiosEstado = new ArrayList<>();
                cs = con.prepareCall("{CALL listar_cambio_estado_ticket(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                    cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                    cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                    cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                    cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));

                    cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                    cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));

                    cambio.setComentario(rs.getString("comentario"));
                    cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                    cambiosEstado.add(cambio);
                }
                tick.setHistorialEstado(cambiosEstado);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }

    @Override
    public ArrayList<Ticket> listarxEmpleado(Empleado empleado) {
        ArrayList<Ticket> tickets = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );            

            CallableStatement cs = con.prepareCall("{CALL listar_ticket_empleado()}");
            cs.setInt("_ID", empleado.getEmpleadoId());
            ResultSet rs = cs.executeQuery();            
            
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaCierreMaximo = rs.getTimestamp("fecha_cierre_maximo");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setAsunto(rs.getString("asunto"));
                ticket.setDescripcion(rs.getString("descripcion"));
                
                ticket.getEstado().setEstadoId(rs.getInt("estado_id"));
                ticket.getEstado().setNombre(rs.getString("estado_nombre"));
                ticket.getEstado().setDescripcion(rs.getString("estado_descripcion"));
                ticket.getEstado().setActivo(rs.getBoolean("estado_activo"));
                
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaCierreMaximo != null) {
                    ticket.setFechaCierreMaximo(fechaCierreMaximo.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                
                ticket.getUrgencia().setUrgenciaId(rs.getInt("urgencia_id"));
                ticket.getUrgencia().setNombre(rs.getString("urgencia_nombre"));
                ticket.getUrgencia().setPlazoMaximo(rs.getInt("plazo_maximo"));
                ticket.getUrgencia().setActivo(rs.getBoolean("urgencia_activo"));
                
                ticket.getCategoria().setCategoriaId(rs.getInt("categoria_id"));
                ticket.getCategoria().setNombre(rs.getString("categoria_nombre"));
                ticket.getCategoria().setDescripcion(rs.getString("categoria_descripcion"));
                ticket.getCategoria().setActivo(rs.getBoolean("categoria_activo"));
                
                int bibliotecaId = rs.getInt("biblioteca_id");
                if(bibliotecaId != 0){
                    ticket.getBiblioteca().setBibliotecaId(bibliotecaId);
                    ticket.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    ticket.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    ticket.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                
                int activoFijoId = rs.getInt("activo_fijo_id");
                if(activoFijoId != 0){
                    ticket.getActivoFijo().setActivoFijoId(activoFijoId);
                }
                int proveedorId = rs.getInt("proveedor_id");
                if(proveedorId != 0){
                    ticket.getProveedor().setProveedorId(proveedorId);
                }
                
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                
                ticket.setRetrasado(rs.getBoolean("retrasado"));

                tickets.add(ticket);
            }
            
            for(Ticket tick : tickets){
                cs = con.prepareCall("{CALL buscar_empleado(?)}");
                cs.setInt("_ID", tick.getEmpleado().getEmpleadoId());
                rs = cs.executeQuery();
                while(rs.next()){
                    tick.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                    tick.getEmpleado().setCodigo(rs.getString("codigo"));
                    tick.getEmpleado().setDni(rs.getString("dni"));
                    tick.getEmpleado().setPersonaEmail(rs.getString("persona_email"));
                    tick.getEmpleado().setActivo(rs.getBoolean("activo"));
                    tick.getEmpleado().setNombre(rs.getString("nombre"));
                    tick.getEmpleado().setApellidoPaterno(rs.getString("apellido_paterno"));
                    tick.getEmpleado().setApellidoMaterno(rs.getString("apellido_materno"));
                    tick.getEmpleado().setDireccion(rs.getString("direccion"));
                    tick.getEmpleado().setTelefono(rs.getString("telefono"));
                    tick.getEmpleado().setTipo(rs.getString("tipo").charAt(0));
                    
                    tick.getEmpleado().getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                    tick.getEmpleado().getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    tick.getEmpleado().getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    tick.getEmpleado().getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                int agenteId = tick.getAgente().getAgenteId();
                if(agenteId != 0){
                    cs = con.prepareCall("{CALL buscar_agente(?)}");
                    cs.setInt("_ID", agenteId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getAgente().setAgenteId(rs.getInt("agente_id"));
                        tick.getAgente().setCodigo(rs.getString("codigo"));
                        tick.getAgente().setDni(rs.getString("dni"));
                        tick.getAgente().setPersonaEmail(rs.getString("persona_email"));
                        tick.getAgente().setAgenteEmail(rs.getString("agente_email"));
                        tick.getAgente().setActivo(rs.getBoolean("activo"));
                        tick.getAgente().setNombre(rs.getString("nombre"));
                        tick.getAgente().setApellidoPaterno(rs.getString("apellido_paterno"));
                        tick.getAgente().setApellidoMaterno(rs.getString("apellido_materno"));
                        tick.getAgente().setDireccion(rs.getString("direccion"));
                        tick.getAgente().setTelefono(rs.getString("telefono"));
                        tick.getAgente().setTipo(rs.getString("tipo").charAt(0));

                        tick.getAgente().getEquipo().setEquipoId(rs.getInt("equipo_id"));
                        tick.getAgente().getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                        tick.getAgente().getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                        tick.getAgente().getEquipo().setNombre(rs.getString("equipo_nombre"));
                        tick.getAgente().getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                        tick.getAgente().getRol().setRolId(rs.getInt("rol_id"));
                        tick.getAgente().getRol().setNombre(rs.getString("rol_nombre"));
                        tick.getAgente().getRol().setDescripcion(rs.getString("rol_descripcion"));
                        tick.getAgente().getRol().setActivo(rs.getBoolean("rol_activo"));
                    }
                }
                int proveedorId = tick.getProveedor().getProveedorId();
                if(proveedorId != 0){
                    cs = con.prepareCall("{CALL buscar_proveedor(?)}");
                    cs.setInt("_ID", proveedorId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad"));
                        tick.getProveedor().setDireccion(rs.getString("direccion"));
                        tick.getProveedor().setEmail(rs.getString("email"));
                        tick.getProveedor().setRazonSocial(rs.getString("razon_social"));
                        tick.getProveedor().setRuc(rs.getString("ruc"));
                        tick.getProveedor().setTelefono(rs.getString("telefono"));
                        tick.getProveedor().setActivo(rs.getBoolean("activo"));
                        
                        tick.getProveedor().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                        tick.getProveedor().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                        tick.getProveedor().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    }
                }
                int activoFijoId = tick.getActivoFijo().getActivoFijoId();
                if(activoFijoId != 0){
                    cs = con.prepareCall("{CALL buscar_activo_fijo(?)}");
                    cs.setInt("_ID", activoFijoId);
                    rs=cs.executeQuery();

                    while(rs.next()) {
                        tick.getActivoFijo().setActivoFijoId(rs.getInt("proveedor_id"));
                        tick.getActivoFijo().setNombre(rs.getString("nombre"));
                        tick.getActivoFijo().setCodigo(rs.getString("codigo"));
                        tick.getActivoFijo().setMarca(rs.getString("marca"));
                        tick.getActivoFijo().setTipo(rs.getString("tipo"));
                        tick.getActivoFijo().setActivo(rs.getBoolean("activo"));
                    }
                }
                
                // Listar historial de transferencias
                ArrayList<TransferenciaTicket> transferencias = new ArrayList<>();
                
                cs = con.prepareCall("{CALL listar_transferencia_externa(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaExterna transferExt = new TransferenciaExterna();

                    transferExt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferExt.setComentario(rs.getString("comentario"));
                    transferExt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferExt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferExt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferExt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferExt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferExt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferExt.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                    transferExt.getProveedorTo().setRuc(rs.getString("ruc"));
                    transferExt.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                    transferExt.getProveedorTo().setTelefono(rs.getString("proveedor_telefono"));
                    transferExt.getProveedorTo().setDireccion(rs.getString("proveedor_direccion"));
                    transferExt.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                    transferExt.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                    
                    transferExt.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                    transferExt.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    transferExt.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                    transferExt.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                    
                    transferencias.add(transferExt);
                }
                
                cs = con.prepareCall("{CALL listar_transferencia_interna(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaInterna transferInt = new TransferenciaInterna();

                    transferInt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferInt.setComentario(rs.getString("comentario"));
                    transferInt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferInt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferInt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferInt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferInt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferInt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferInt.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                    transferInt.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                    transferInt.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                    transferInt.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                    
                    transferencias.add(transferInt);
                }
                tick.setHistorialTransferencia(transferencias);
                
                // Listar historial de cambios de estado
                ArrayList<CambioEstadoTicket> cambiosEstado = new ArrayList<>();
                cs = con.prepareCall("{CALL listar_cambio_estado_ticket(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                    cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                    cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                    cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                    cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));

                    cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                    cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));

                    cambio.setComentario(rs.getString("comentario"));
                    cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                    cambiosEstado.add(cambio);
                }
                tick.setHistorialEstado(cambiosEstado);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }

    @Override
    public ArrayList<Ticket> listarxCategoria(Categoria categoria) {
        ArrayList<Ticket> tickets = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );            

            CallableStatement cs = con.prepareCall("{CALL listar_ticket_categoria(?)}");
            cs.setInt("_ID", categoria.getCategoriaId());
            ResultSet rs = cs.executeQuery();            
            
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaCierreMaximo = rs.getTimestamp("fecha_cierre_maximo");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setAsunto(rs.getString("asunto"));
                ticket.setDescripcion(rs.getString("descripcion"));
                
                ticket.getEstado().setEstadoId(rs.getInt("estado_id"));
                ticket.getEstado().setNombre(rs.getString("estado_nombre"));
                ticket.getEstado().setDescripcion(rs.getString("estado_descripcion"));
                ticket.getEstado().setActivo(rs.getBoolean("estado_activo"));
                
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaCierreMaximo != null) {
                    ticket.setFechaCierreMaximo(fechaCierreMaximo.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                
                ticket.getUrgencia().setUrgenciaId(rs.getInt("urgencia_id"));
                ticket.getUrgencia().setNombre(rs.getString("urgencia_nombre"));
                ticket.getUrgencia().setPlazoMaximo(rs.getInt("plazo_maximo"));
                ticket.getUrgencia().setActivo(rs.getBoolean("urgencia_activo"));
                
                ticket.getCategoria().setCategoriaId(rs.getInt("categoria_id"));
                ticket.getCategoria().setNombre(rs.getString("categoria_nombre"));
                ticket.getCategoria().setDescripcion(rs.getString("categoria_descripcion"));
                ticket.getCategoria().setActivo(rs.getBoolean("categoria_activo"));
                
                int bibliotecaId = rs.getInt("biblioteca_id");
                if(bibliotecaId != 0){
                    ticket.getBiblioteca().setBibliotecaId(bibliotecaId);
                    ticket.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    ticket.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    ticket.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                
                int activoFijoId = rs.getInt("activo_fijo_id");
                if(activoFijoId != 0){
                    ticket.getActivoFijo().setActivoFijoId(activoFijoId);
                }
                int proveedorId = rs.getInt("proveedor_id");
                if(proveedorId != 0){
                    ticket.getProveedor().setProveedorId(proveedorId);
                }
                
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                
                ticket.setRetrasado(rs.getBoolean("retrasado"));

                tickets.add(ticket);
            }
            
            for(Ticket tick : tickets){
                cs = con.prepareCall("{CALL buscar_empleado(?)}");
                cs.setInt("_ID", tick.getEmpleado().getEmpleadoId());
                rs = cs.executeQuery();
                while(rs.next()){
                    tick.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                    tick.getEmpleado().setCodigo(rs.getString("codigo"));
                    tick.getEmpleado().setDni(rs.getString("dni"));
                    tick.getEmpleado().setPersonaEmail(rs.getString("persona_email"));
                    tick.getEmpleado().setActivo(rs.getBoolean("activo"));
                    tick.getEmpleado().setNombre(rs.getString("nombre"));
                    tick.getEmpleado().setApellidoPaterno(rs.getString("apellido_paterno"));
                    tick.getEmpleado().setApellidoMaterno(rs.getString("apellido_materno"));
                    tick.getEmpleado().setDireccion(rs.getString("direccion"));
                    tick.getEmpleado().setTelefono(rs.getString("telefono"));
                    tick.getEmpleado().setTipo(rs.getString("tipo").charAt(0));
                    
                    tick.getEmpleado().getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                    tick.getEmpleado().getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    tick.getEmpleado().getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    tick.getEmpleado().getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                int agenteId = tick.getAgente().getAgenteId();
                if(agenteId != 0){
                    cs = con.prepareCall("{CALL buscar_agente(?)}");
                    cs.setInt("_ID", agenteId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getAgente().setAgenteId(rs.getInt("agente_id"));
                        tick.getAgente().setCodigo(rs.getString("codigo"));
                        tick.getAgente().setDni(rs.getString("dni"));
                        tick.getAgente().setPersonaEmail(rs.getString("persona_email"));
                        tick.getAgente().setAgenteEmail(rs.getString("agente_email"));
                        tick.getAgente().setActivo(rs.getBoolean("activo"));
                        tick.getAgente().setNombre(rs.getString("nombre"));
                        tick.getAgente().setApellidoPaterno(rs.getString("apellido_paterno"));
                        tick.getAgente().setApellidoMaterno(rs.getString("apellido_materno"));
                        tick.getAgente().setDireccion(rs.getString("direccion"));
                        tick.getAgente().setTelefono(rs.getString("telefono"));
                        tick.getAgente().setTipo(rs.getString("tipo").charAt(0));

                        tick.getAgente().getEquipo().setEquipoId(rs.getInt("equipo_id"));
                        tick.getAgente().getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                        tick.getAgente().getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                        tick.getAgente().getEquipo().setNombre(rs.getString("equipo_nombre"));
                        tick.getAgente().getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                        tick.getAgente().getRol().setRolId(rs.getInt("rol_id"));
                        tick.getAgente().getRol().setNombre(rs.getString("rol_nombre"));
                        tick.getAgente().getRol().setDescripcion(rs.getString("rol_descripcion"));
                        tick.getAgente().getRol().setActivo(rs.getBoolean("rol_activo"));
                    }
                }
                int proveedorId = tick.getProveedor().getProveedorId();
                if(proveedorId != 0){
                    cs = con.prepareCall("{CALL buscar_proveedor(?)}");
                    cs.setInt("_ID", proveedorId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad"));
                        tick.getProveedor().setDireccion(rs.getString("direccion"));
                        tick.getProveedor().setEmail(rs.getString("email"));
                        tick.getProveedor().setRazonSocial(rs.getString("razon_social"));
                        tick.getProveedor().setRuc(rs.getString("ruc"));
                        tick.getProveedor().setTelefono(rs.getString("telefono"));
                        tick.getProveedor().setActivo(rs.getBoolean("activo"));
                        
                        tick.getProveedor().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                        tick.getProveedor().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                        tick.getProveedor().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    }
                }
                int activoFijoId = tick.getActivoFijo().getActivoFijoId();
                if(activoFijoId != 0){
                    cs = con.prepareCall("{CALL buscar_activo_fijo(?)}");
                    cs.setInt("_ID", activoFijoId);
                    rs=cs.executeQuery();

                    while(rs.next()) {
                        tick.getActivoFijo().setActivoFijoId(rs.getInt("proveedor_id"));
                        tick.getActivoFijo().setNombre(rs.getString("nombre"));
                        tick.getActivoFijo().setCodigo(rs.getString("codigo"));
                        tick.getActivoFijo().setMarca(rs.getString("marca"));
                        tick.getActivoFijo().setTipo(rs.getString("tipo"));
                        tick.getActivoFijo().setActivo(rs.getBoolean("activo"));
                    }
                }
                
                // Listar historial de transferencias
                ArrayList<TransferenciaTicket> transferencias = new ArrayList<>();
                
                cs = con.prepareCall("{CALL listar_transferencia_externa(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaExterna transferExt = new TransferenciaExterna();

                    transferExt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferExt.setComentario(rs.getString("comentario"));
                    transferExt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferExt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferExt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferExt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferExt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferExt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferExt.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                    transferExt.getProveedorTo().setRuc(rs.getString("ruc"));
                    transferExt.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                    transferExt.getProveedorTo().setTelefono(rs.getString("proveedor_telefono"));
                    transferExt.getProveedorTo().setDireccion(rs.getString("proveedor_direccion"));
                    transferExt.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                    transferExt.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                    
                    transferExt.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                    transferExt.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    transferExt.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                    transferExt.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                    
                    transferencias.add(transferExt);
                }
                
                cs = con.prepareCall("{CALL listar_transferencia_interna(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaInterna transferInt = new TransferenciaInterna();

                    transferInt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferInt.setComentario(rs.getString("comentario"));
                    transferInt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferInt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferInt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferInt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferInt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferInt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferInt.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                    transferInt.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                    transferInt.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                    transferInt.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                    
                    transferencias.add(transferInt);
                }
                tick.setHistorialTransferencia(transferencias);
                
                // Listar historial de cambios de estado
                ArrayList<CambioEstadoTicket> cambiosEstado = new ArrayList<>();
                cs = con.prepareCall("{CALL listar_cambio_estado_ticket(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                    cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                    cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                    cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                    cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));

                    cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                    cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));

                    cambio.setComentario(rs.getString("comentario"));
                    cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                    cambiosEstado.add(cambio);
                }
                tick.setHistorialEstado(cambiosEstado);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }

    @Override
    public ArrayList<Ticket> listarxEstadoxEquipo(EstadoTicket estado, Equipo equipo) {
        ArrayList<Ticket> tickets = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );            

            CallableStatement cs = con.prepareCall("{CALL listar_ticket_equipo_estado(?,?)}");
            cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
            cs.setInt("_ESTADO_ID", estado.getEstadoId());
            ResultSet rs = cs.executeQuery();            
            
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaCierreMaximo = rs.getTimestamp("fecha_cierre_maximo");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setAsunto(rs.getString("asunto"));
                ticket.setDescripcion(rs.getString("descripcion"));
                
                ticket.getEstado().setEstadoId(rs.getInt("estado_id"));
                ticket.getEstado().setNombre(rs.getString("estado_nombre"));
                ticket.getEstado().setDescripcion(rs.getString("estado_descripcion"));
                ticket.getEstado().setActivo(rs.getBoolean("estado_activo"));
                
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaCierreMaximo != null) {
                    ticket.setFechaCierreMaximo(fechaCierreMaximo.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                
                ticket.getUrgencia().setUrgenciaId(rs.getInt("urgencia_id"));
                ticket.getUrgencia().setNombre(rs.getString("urgencia_nombre"));
                ticket.getUrgencia().setPlazoMaximo(rs.getInt("plazo_maximo"));
                ticket.getUrgencia().setActivo(rs.getBoolean("urgencia_activo"));
                
                ticket.getCategoria().setCategoriaId(rs.getInt("categoria_id"));
                ticket.getCategoria().setNombre(rs.getString("categoria_nombre"));
                ticket.getCategoria().setDescripcion(rs.getString("categoria_descripcion"));
                ticket.getCategoria().setActivo(rs.getBoolean("categoria_activo"));
                
                int bibliotecaId = rs.getInt("biblioteca_id");
                if(bibliotecaId != 0){
                    ticket.getBiblioteca().setBibliotecaId(bibliotecaId);
                    ticket.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    ticket.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    ticket.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                
                int activoFijoId = rs.getInt("activo_fijo_id");
                if(activoFijoId != 0){
                    ticket.getActivoFijo().setActivoFijoId(activoFijoId);
                }
                int proveedorId = rs.getInt("proveedor_id");
                if(proveedorId != 0){
                    ticket.getProveedor().setProveedorId(proveedorId);
                }
                
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                
                ticket.setRetrasado(rs.getBoolean("retrasado"));

                tickets.add(ticket);
            }
            
            for(Ticket tick : tickets){
                cs = con.prepareCall("{CALL buscar_empleado(?)}");
                cs.setInt("_ID", tick.getEmpleado().getEmpleadoId());
                rs = cs.executeQuery();
                while(rs.next()){
                    tick.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                    tick.getEmpleado().setCodigo(rs.getString("codigo"));
                    tick.getEmpleado().setDni(rs.getString("dni"));
                    tick.getEmpleado().setPersonaEmail(rs.getString("persona_email"));
                    tick.getEmpleado().setActivo(rs.getBoolean("activo"));
                    tick.getEmpleado().setNombre(rs.getString("nombre"));
                    tick.getEmpleado().setApellidoPaterno(rs.getString("apellido_paterno"));
                    tick.getEmpleado().setApellidoMaterno(rs.getString("apellido_materno"));
                    tick.getEmpleado().setDireccion(rs.getString("direccion"));
                    tick.getEmpleado().setTelefono(rs.getString("telefono"));
                    tick.getEmpleado().setTipo(rs.getString("tipo").charAt(0));
                    
                    tick.getEmpleado().getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                    tick.getEmpleado().getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                    tick.getEmpleado().getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                    tick.getEmpleado().getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                }
                int agenteId = tick.getAgente().getAgenteId();
                if(agenteId != 0){
                    cs = con.prepareCall("{CALL buscar_agente(?)}");
                    cs.setInt("_ID", agenteId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getAgente().setAgenteId(rs.getInt("agente_id"));
                        tick.getAgente().setCodigo(rs.getString("codigo"));
                        tick.getAgente().setDni(rs.getString("dni"));
                        tick.getAgente().setPersonaEmail(rs.getString("persona_email"));
                        tick.getAgente().setAgenteEmail(rs.getString("agente_email"));
                        tick.getAgente().setActivo(rs.getBoolean("activo"));
                        tick.getAgente().setNombre(rs.getString("nombre"));
                        tick.getAgente().setApellidoPaterno(rs.getString("apellido_paterno"));
                        tick.getAgente().setApellidoMaterno(rs.getString("apellido_materno"));
                        tick.getAgente().setDireccion(rs.getString("direccion"));
                        tick.getAgente().setTelefono(rs.getString("telefono"));
                        tick.getAgente().setTipo(rs.getString("tipo").charAt(0));

                        tick.getAgente().getEquipo().setEquipoId(rs.getInt("equipo_id"));
                        tick.getAgente().getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                        tick.getAgente().getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                        tick.getAgente().getEquipo().setNombre(rs.getString("equipo_nombre"));
                        tick.getAgente().getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                        tick.getAgente().getRol().setRolId(rs.getInt("rol_id"));
                        tick.getAgente().getRol().setNombre(rs.getString("rol_nombre"));
                        tick.getAgente().getRol().setDescripcion(rs.getString("rol_descripcion"));
                        tick.getAgente().getRol().setActivo(rs.getBoolean("rol_activo"));
                    }
                }
                int proveedorId = tick.getProveedor().getProveedorId();
                if(proveedorId != 0){
                    cs = con.prepareCall("{CALL buscar_proveedor(?)}");
                    cs.setInt("_ID", proveedorId);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        tick.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad"));
                        tick.getProveedor().setDireccion(rs.getString("direccion"));
                        tick.getProveedor().setEmail(rs.getString("email"));
                        tick.getProveedor().setRazonSocial(rs.getString("razon_social"));
                        tick.getProveedor().setRuc(rs.getString("ruc"));
                        tick.getProveedor().setTelefono(rs.getString("telefono"));
                        tick.getProveedor().setActivo(rs.getBoolean("activo"));
                        
                        tick.getProveedor().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                        tick.getProveedor().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                        tick.getProveedor().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                        tick.getProveedor().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    }
                }
                int activoFijoId = tick.getActivoFijo().getActivoFijoId();
                if(activoFijoId != 0){
                    cs = con.prepareCall("{CALL buscar_activo_fijo(?)}");
                    cs.setInt("_ID", activoFijoId);
                    rs=cs.executeQuery();

                    while(rs.next()) {
                        tick.getActivoFijo().setActivoFijoId(rs.getInt("proveedor_id"));
                        tick.getActivoFijo().setNombre(rs.getString("nombre"));
                        tick.getActivoFijo().setCodigo(rs.getString("codigo"));
                        tick.getActivoFijo().setMarca(rs.getString("marca"));
                        tick.getActivoFijo().setTipo(rs.getString("tipo"));
                        tick.getActivoFijo().setActivo(rs.getBoolean("activo"));
                    }
                }
                
                // Listar historial de transferencias
                ArrayList<TransferenciaTicket> transferencias = new ArrayList<>();
                
                cs = con.prepareCall("{CALL listar_transferencia_externa(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaExterna transferExt = new TransferenciaExterna();

                    transferExt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferExt.setComentario(rs.getString("comentario"));
                    transferExt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferExt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferExt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferExt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferExt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferExt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferExt.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                    transferExt.getProveedorTo().setRuc(rs.getString("ruc"));
                    transferExt.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                    transferExt.getProveedorTo().setTelefono(rs.getString("proveedor_telefono"));
                    transferExt.getProveedorTo().setDireccion(rs.getString("proveedor_direccion"));
                    transferExt.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                    transferExt.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                    
                    transferExt.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                    transferExt.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                    transferExt.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                    transferExt.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                    
                    transferencias.add(transferExt);
                }
                
                cs = con.prepareCall("{CALL listar_transferencia_interna(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    TransferenciaInterna transferInt = new TransferenciaInterna();

                    transferInt.setTransferenciaId(rs.getInt("transferencia_id"));
                    transferInt.setComentario(rs.getString("comentario"));
                    transferInt.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());

                    transferInt.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                    transferInt.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                    transferInt.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                    transferInt.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                    transferInt.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));

                    transferInt.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                    transferInt.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                    transferInt.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                    transferInt.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                    
                    transferencias.add(transferInt);
                }
                tick.setHistorialTransferencia(transferencias);
                
                // Listar historial de cambios de estado
                ArrayList<CambioEstadoTicket> cambiosEstado = new ArrayList<>();
                cs = con.prepareCall("{CALL listar_cambio_estado_ticket(?)}");
                cs.setInt("_ID", tick.getTicketId());
                rs=cs.executeQuery();
                
                while(rs.next()) {
                    CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                    cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                    cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                    cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                    cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));

                    cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                    cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));

                    cambio.setComentario(rs.getString("comentario"));
                    cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                    cambiosEstado.add(cambio);
                }
                tick.setHistorialEstado(cambiosEstado);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }
    
}
