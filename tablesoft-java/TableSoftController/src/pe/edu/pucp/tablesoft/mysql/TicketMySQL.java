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
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.dao.CambioEstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaExternaDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaInternaDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
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
            
            Timestamp fechaEnvio = Timestamp.valueOf(LocalDateTime.now());
            
            CallableStatement cs = con.prepareCall("{CALL insertar_ticket(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_ESTADO_ID", ticket.getEstado().getEstadoId());
            cs.setTimestamp("_FECHA_ENVIO", fechaEnvio);
            cs.setInt("_URGENCIA_ID", ticket.getUrgencia().getUrgenciaId());
            cs.setInt("_CATEGORIA_ID", ticket.getCategoria().getCategoriaId());
            cs.setInt("_EMPLEADO_ID", ticket.getEmpleado().getEmpleadoId());
            cs.setInt("_BIBLIOTECA_ID", ticket.getBiblioteca().getBibliotecaId());
            cs.execute();
            
            out = cs.getInt("_ID");
            ticket.setTicketId(out);
            ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
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
            
            TransferenciaExternaDAO daoExterna = new TransferenciaExternaMySQL();
            TransferenciaInternaDAO daoInterna = new TransferenciaInternaMySQL();
            if(ticket.getHistorialTransferencia() != null){
                for (TransferenciaTicket transfer : ticket.getHistorialTransferencia()){
                    if(transfer.getTransferenciaId() == 0){
                        if(transfer instanceof TransferenciaExterna){
                            daoExterna.insertar((TransferenciaExterna)transfer, ticket);
                        }
                        if(transfer instanceof TransferenciaInterna){
                            daoInterna.insertar((TransferenciaInterna)transfer, ticket);
                        }
                    }
                }
            }
            
            CambioEstadoTicketDAO daoCambioEstado = new CambioEstadoTicketMySQL();
            for (CambioEstadoTicket cambioEstado : ticket.getHistorialEstado()){
                if(cambioEstado.getCambioEstadoTicketId() == 0){
                    daoCambioEstado.insertar(cambioEstado, ticket);
                }
            }
            
            CallableStatement cs = con.prepareCall(
                "{CALL actualizar_ticket(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}"
            );
            cs.setInt("_ID", ticket.getTicketId());
            cs.setInt("_ESTADO_ID", ticket.getEstado().getEstadoId());
            
            cs.setTimestamp("_FECHA_ENVIO", Timestamp.valueOf(ticket.getFechaEnvio()));
            if (ticket.getFechaPrimeraRespuesta() != null){
                cs.setTimestamp("_FECHA_PRIMERA_RESPUESTA", Timestamp.valueOf(ticket.getFechaPrimeraRespuesta()));
            }
            else {
                cs.setTimestamp("_FECHA_PRIMERA_RESPUESTA", null);
            }
            if (ticket.getFechaCierre() != null){
                cs.setTimestamp("_FECHA_CIERRE", Timestamp.valueOf(ticket.getFechaCierre()));
            }
            else{
                cs.setTimestamp("_FECHA_CIERRE", null);
            }
            
            int activoFijoId = ticket.getActivoFijo().getActivoFijoId();
            if (activoFijoId != 0) {
                cs.setInt("_ACTIVO_FIJO_ID", activoFijoId);
            } else {
                cs.setNull("_ACTIVO_FIJO_ID", java.sql.Types.INTEGER);
            }
            int agenteId = ticket.getAgente().getAgenteId();
            if (agenteId != 0){
                cs.setInt("_AGENTE_ID", agenteId );
            } else {
                cs.setNull("_AGENTE_ID", java.sql.Types.INTEGER);
            }
            cs.setInt("_EMPLEADO_ID", ticket.getEmpleado().getEmpleadoId());
            cs.setInt("_URGENCIA_ID", ticket.getUrgencia().getUrgenciaId());
            int proveedorId = ticket.getProveedor().getProveedorId();
            if (proveedorId != 0){
                cs.setInt("_PROVEEDOR_ID", proveedorId);
            } else{
                cs.setNull("_PROVEEDOR_ID", java.sql.Types.INTEGER);
            }
            cs.setInt("_CATEGORIA_ID", ticket.getCategoria().getCategoriaId());
            int bibliotecaId = ticket.getBiblioteca().getBibliotecaId();
            if (bibliotecaId != 0){
                cs.setInt("_BIBLIOTECA_ID", bibliotecaId);
            } else{
                cs.setNull("_BIBLIOTECA_ID", java.sql.Types.INTEGER);
            }
            cs.setString("_INFO_ADICIONAL", ticket.getInfoAdicional());
            cs.setString("_ALUMNO_EMAIL", ticket.getAlumnoEmail());
            
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
            
            BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
            CategoriaDAO daoCategoria = new CategoriaMySQL();
            UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
            EstadoTicketDAO daoEstadoTicket = new EstadoTicketMySQL();
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(daoEstadoTicket.buscar(rs.getInt("estado_id")));
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.getActivoFijo().setActivoFijoId(rs.getInt("activo_fijo_id"));
                ticket.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setUrgencia(daoUrgencia.buscar(rs.getInt("urgencia_id")));
                ticket.setCategoria(daoCategoria.buscar(rs.getInt("categoria_id")));
                ticket.setBiblioteca(daoBiblioteca.buscar(rs.getInt("biblioteca_id")));
                tickets.add(ticket);
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
            
            BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
            CategoriaDAO daoCategoria = new CategoriaMySQL();
            UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
            EstadoTicketDAO daoEstadoTicket = new EstadoTicketMySQL();
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(daoEstadoTicket.buscar(rs.getInt("estado_id")));
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.getActivoFijo().setActivoFijoId(rs.getInt("activo_fijo_id"));
                ticket.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.setAgente(agente);
                
                ticket.setUrgencia(daoUrgencia.buscar(rs.getInt("urgencia_id")));
                ticket.setCategoria(daoCategoria.buscar(rs.getInt("categoria_id")));
                ticket.setBiblioteca(daoBiblioteca.buscar(rs.getInt("biblioteca_id")));
                tickets.add(ticket);
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

            CallableStatement cs = con.prepareCall("{CALL listar_ticket_empleado(?)}");
            cs.setInt("_ID", empleado.getEmpleadoId());
            
            ResultSet rs = cs.executeQuery();            
            
            BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
            CategoriaDAO daoCategoria = new CategoriaMySQL();
            UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
            EstadoTicketDAO daoEstadoTicket = new EstadoTicketMySQL();
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(daoEstadoTicket.buscar(rs.getInt("estado_id")));
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.getActivoFijo().setActivoFijoId(rs.getInt("activo_fijo_id"));
                ticket.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                ticket.setEmpleado(empleado);
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setUrgencia(daoUrgencia.buscar(rs.getInt("urgencia_id")));
                ticket.setCategoria(daoCategoria.buscar(rs.getInt("categoria_id")));
                ticket.setBiblioteca(daoBiblioteca.buscar(rs.getInt("biblioteca_id")));
                tickets.add(ticket);
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
            
            BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
            UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
            EstadoTicketDAO daoEstadoTicket = new EstadoTicketMySQL();
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(daoEstadoTicket.buscar(rs.getInt("estado_id")));
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.getActivoFijo().setActivoFijoId(rs.getInt("activo_fijo_id"));
                ticket.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setUrgencia(daoUrgencia.buscar(rs.getInt("urgencia_id")));
                ticket.setCategoria(categoria);
                ticket.setBiblioteca(daoBiblioteca.buscar(rs.getInt("biblioteca_id")));
                tickets.add(ticket);
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
            cs.setInt("_ESTADO_ID", estado.getEstadoId());
            cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
            ResultSet rs = cs.executeQuery();            
            
            BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
            CategoriaDAO daoCategoria = new CategoriaMySQL();
            UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
            EstadoTicketDAO daoEstadoTicket = new EstadoTicketMySQL();
            while(rs.next()) {
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(estado);
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.getActivoFijo().setActivoFijoId(rs.getInt("activo_fijo_id"));
                ticket.getProveedor().setProveedorId(rs.getInt("proveedor_id"));
                ticket.getEmpleado().setEmpleadoId(rs.getInt("empleado_id"));
                ticket.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                ticket.setUrgencia(daoUrgencia.buscar(rs.getInt("urgencia_id")));
                ticket.setCategoria(daoCategoria.buscar(rs.getInt("categoria_id")));
                ticket.setBiblioteca(daoBiblioteca.buscar(rs.getInt("biblioteca_id")));
                tickets.add(ticket);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }
    
}
