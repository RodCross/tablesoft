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
import pe.edu.pucp.tablesoft.dao.TareaDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Tarea;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public class TareaMySQL implements TareaDAO {
    
    Connection con;
    @Override
    public int insertar(Tarea tarea, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            tarea.setFechaCreacion(LocalDateTime.now());
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_tarea(?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());            
            cs.setString("_DESCRIPCION", tarea.getDescripcion());
            cs.setInt("_AGENTE_ID",tarea.getAgente().getAgenteId());
            cs.setBoolean("_COMPLETADO", tarea.getCompletado());
                       
            cs.execute();
            rpta = cs.getInt("_ID");
            tarea.setTareaId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Tarea tarea, Agente agente) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_tarea(?,?,?,?)}");
            
            cs.setInt("_ID", tarea.getTareaId());
            cs.setInt("_AGENTE_ID", agente.getAgenteId());
            cs.setString("_DESCRIPCION", tarea.getDescripcion());
            cs.setBoolean("_COMPLETADO", tarea.getCompletado());
                       
            cs.execute();
            con.close();
            
        } catch(SQLException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        } catch(ClassNotFoundException ex2){
            System.out.println(ex2.getMessage());
            rpta = -2;
        }
        
        return rpta;
    }

    @Override
    public int eliminar(Tarea tarea) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_tarea(?)}");
            
            cs.setInt("_ID", tarea.getTareaId());
            
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Tarea> listarxTicket(Ticket ticket) {
        ArrayList<Tarea> tareas = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_tarea(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                Tarea tarea = new Tarea();
                
                tarea.setTareaId(rs.getInt("tarea_id"));
                tarea.setDescripcion(rs.getString("descripcion"));
                tarea.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                Timestamp fechaCompletado = rs.getTimestamp("fecha_completado");
                if (fechaCompletado != null) {
                    ticket.setFechaCierreMaximo(fechaCompletado.toLocalDateTime());
                }
                tarea.getAgente().setAgenteId(rs.getInt("agente_id"));
                
                tarea.setCompletado(rs.getBoolean("completado"));
                
                tareas.add(tarea);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        
        return tareas;
    }

    @Override
    public int actualizarInsertarArreglo(ArrayList<Tarea> tareas, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            for(Tarea tarea : tareas){
                if(tarea.getTareaId() != 0){
                    CallableStatement cs = con.prepareCall(
                        "{CALL actualizar_tarea(?,?,?,?)}");

                    cs.setInt("_ID", tarea.getTareaId());
                    cs.setInt("_AGENTE_ID", tarea.getAgente().getAgenteId());
                    cs.setString("_DESCRIPCION", tarea.getDescripcion());
                    cs.setBoolean("_COMPLETADO", tarea.getCompletado());

                    cs.execute();
                    rpta++;
                }
                else{
                    tarea.setFechaCreacion(LocalDateTime.now());
            
                    CallableStatement cs = con.prepareCall(
                            "{CALL insertar_tarea(?,?,?,?,?)}");

                    cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
                    cs.setInt("_TICKET_ID", ticket.getTicketId());            
                    cs.setString("_DESCRIPCION", tarea.getDescripcion());
                    cs.setInt("_AGENTE_ID",tarea.getAgente().getAgenteId());
                    cs.setBoolean("_COMPLETADO", tarea.getCompletado());

                    cs.execute();
                    tarea.setTareaId(cs.getInt("_ID"));
                    if(tarea.getTareaId() != 0) rpta++;
                }
            }
                
            con.close();
            
        } catch(SQLException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        } catch(ClassNotFoundException ex2){
            System.out.println(ex2.getMessage());
            rpta = -2;
        }
        
        return rpta;
    }

    @Override
    public int eliminarArreglo(ArrayList<Tarea> tareas) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            for(Tarea tarea : tareas){
                CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_tarea(?)}");
            
                cs.setInt("_ID", tarea.getTareaId());

                cs.execute();
                rpta ++;
            }
                
            con.close();
            
        } catch(SQLException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        } catch(ClassNotFoundException ex2){
            System.out.println(ex2.getMessage());
            rpta = -2;
        }
        
        return rpta;
    }

}
