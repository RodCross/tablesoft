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
import pe.edu.pucp.tablesoft.dao.EstadoTareaDAO;
import pe.edu.pucp.tablesoft.dao.TareaDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.EstadoTarea;
import pe.edu.pucp.tablesoft.model.Tarea;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public class TareaMySQL implements TareaDAO {
    
    Connection con;
    @Override
    public int insertar(Tarea tarea, Agente agente, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_tarea(?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());            
            cs.setString("_DESCRIPCION", tarea.getDescripcion());
            cs.setInt("_AGENTE_ID",agente.getAgenteId());
            cs.setInt("_ESTADO_ID", tarea.getEstado().getEstadoId());
                       
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
            cs.setInt("_ESTADO_ID", tarea.getEstado().getEstadoId());
                       
            cs.execute();
            rpta = cs.getInt("_ID");
            tarea.setTareaId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
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
            
            EstadoTareaDAO daoEstadoTarea = new EstadoTareaMySQL();
            while(rs.next()){
                Tarea tarea = new Tarea();
                
                tarea.setTareaId(rs.getInt("tarea_id"));
                tarea.setAgente(new Agente(rs.getInt("agente_id")));
                tarea.setDescripcion(rs.getString("descripcion"));
                // Cambiar
                tarea.setEstado(daoEstadoTarea.buscar(rs.getInt("estado_id")));
                
                tareas.add(tarea);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        
        return tareas;
    }

}
