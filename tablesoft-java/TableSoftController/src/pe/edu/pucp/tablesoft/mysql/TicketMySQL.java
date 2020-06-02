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
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Proveedor;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.Urgencia;


public class TicketMySQL implements TicketDAO{

    @Override
    public int insertar(Ticket ticket) {
        Connection con;
        
        int out = 0;
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );
            
            Timestamp fechaEnvio = Timestamp.valueOf(ticket.getFechaEnvio());
            
            CallableStatement cs = con.prepareCall("{CALL insertar_ticket(?,?,?,?,?)}");
            cs.registerOutParameter(1, java.sql.Types.INTEGER);
            cs.setString(2, ticket.getEstado());
            cs.setTimestamp(3, fechaEnvio);
            cs.setInt(4, ticket.getUrgencia().getUrgenciaId());
            cs.setInt(5, ticket.getCategoria().getCategoriaId());
            cs.execute();
            
            out = cs.getInt(1);
            ticket.setTicketId(out);
            
            con.close();
            out = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return out;
    }

    @Override
    public int actualizar(Ticket ticket) {
        Connection con;
        
        int out = 0;
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );
            
            // Variables auxiliares
            LocalDateTime envio = ticket.getFechaEnvio(); // nunca es null
            LocalDateTime prim = ticket.getFechaPrimeraRespuesta();
            LocalDateTime cierre = ticket.getFechaCierre();
            int activoFijo = ticket.getActivoFijoId();
            
            // Convertir a Timestamp
            Timestamp fechaEnvio, fechaPrimeraRespuesta, fechaCierre;
            
            fechaEnvio = Timestamp.valueOf(envio);
            
            if (prim != null) {
                fechaPrimeraRespuesta = Timestamp.valueOf(prim);
            }
            else {
                fechaPrimeraRespuesta = null;
            }
            
            if (cierre != null) {
                fechaCierre = Timestamp.valueOf(cierre);
            }
            else {
                fechaCierre = null;
            }
 
            CallableStatement cs = con.prepareCall(
                "{CALL actualizar_ticket(?,?,?,?,?,?,?,?,?,?,?,?,?)}"
            );
            cs.setInt(1, ticket.getTicketId());
            cs.setString(2, ticket.getEstado());
            cs.setString(3, ticket.getInfoAdicional());
            cs.setString(4, ticket.getAlumnoEmail());
            cs.setTimestamp(5, fechaEnvio);
            cs.setTimestamp(6, fechaPrimeraRespuesta);
            cs.setTimestamp(7, fechaCierre);
            if (activoFijo != 0) {
                cs.setInt(8, activoFijo);
            }
            else {
                cs.setNull(8, java.sql.Types.INTEGER);
            }
            cs.setInt(9, ticket.getEmpleado().getEmpleadoId());
            cs.setInt(10, ticket.getAgente().getAgenteId());
            cs.setInt(11, ticket.getUrgencia().getUrgenciaId());
            cs.setInt(12, ticket.getProveedor().getProveedorId());
            cs.setInt(13, ticket.getCategoria().getCategoriaId());
            out = cs.executeUpdate();
            
            con.close();
            out = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return out;
    }

    @Override
    public int eliminar(int ticketId) {
        Connection con;
        
        int out = 0;
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(
                DBManager.urlMySQL,
                DBManager.user,
                DBManager.password
            );
            
            CallableStatement cs = con.prepareCall("{CALL eliminar_ticket(?)}");
            cs.setInt(1, ticketId);
            out = cs.executeUpdate();
            
            con.close();
            out = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return out;
    }

    @Override
    public ArrayList<Ticket> listar() {
        Connection con;
        
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
                Empleado empleado = new Empleado();
                Agente agente = new Agente();
                Urgencia urgencia = new Urgencia();
                Proveedor proveedor = new Proveedor();
                Categoria categoria = new Categoria();
                
                Timestamp fechaEnvio = rs.getTimestamp("fecha_envio");
                Timestamp fechaPrimeraRespuesta = rs.getTimestamp("fecha_primera_respuesta");
                Timestamp fechaCierre = rs.getTimestamp("fecha_cierre");
                
                Ticket ticket = new Ticket();
                ticket.setTicketId(rs.getInt("ticket_id"));
                ticket.setEstado(rs.getString("estado"));
                ticket.setInfoAdicional(rs.getString("info_adicional"));
                ticket.setAlumnoEmail(rs.getString("alumno_email"));
                ticket.setFechaEnvio(fechaEnvio.toLocalDateTime());
                if (fechaPrimeraRespuesta != null) {
                    ticket.setFechaPrimeraRespuesta(fechaPrimeraRespuesta.toLocalDateTime());
                }
                if (fechaCierre != null) {
                    ticket.setFechaCierre(fechaCierre.toLocalDateTime());
                }
                ticket.setActivoFijoId(rs.getInt("activo_fijo_id"));
                empleado.setEmpleadoId(rs.getInt("empleado_id"));
                agente.setAgenteId(rs.getInt("agente_id"));
                urgencia.setUrgenciaId(rs.getInt("urgencia_id"));
                proveedor.setProveedorId(rs.getInt("proveedor_id"));
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                ticket.setEmpleado(empleado);
                ticket.setAgente(agente);
                ticket.setUrgencia(urgencia);
                ticket.setProveedor(proveedor);
                ticket.setCategoria(categoria);
                tickets.add(ticket);
            }
            
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return tickets;
    }
    
}
