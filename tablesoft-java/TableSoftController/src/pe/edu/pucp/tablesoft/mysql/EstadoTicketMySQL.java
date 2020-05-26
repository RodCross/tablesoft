package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.model.EstadoTicket;

/*
 * @author migue
 */
public class EstadoTicketMySQL implements EstadoTicketDAO {
    Connection con;
    @Override
    public int insertar(EstadoTicket estadoTicket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_estado_ticket(?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", estadoTicket.getNombre());
            cs.setString("_DESCRIPCION", estadoTicket.getDescripcion());
                        
            cs.execute();
            rpta = cs.getInt("_ID");
            estadoTicket.setEstadoId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(EstadoTicket estadoTicket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_estado_ticket(?,?,?)}");
            
            cs.setInt("_ID", estadoTicket.getEstadoId());
            cs.setString("_NOMBRE", estadoTicket.getNombre());
            cs.setString("_DESCRIPCION", estadoTicket.getDescripcion());
            
            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(EstadoTicket estadoTicket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_estado_ticket(?)}");
            
            cs.setInt("_ID", estadoTicket.getEstadoId());
            
            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<EstadoTicket> listar() {
        ArrayList<EstadoTicket> estados = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_estado_ticket()}");
            
            ResultSet rs = cs.executeQuery();

            while(rs.next()){
                EstadoTicket estado = new EstadoTicket();
                
                estado.setEstadoId(rs.getInt("estado_id"));
                estado.setNombre(rs.getString("nombre"));
                estado.setDescripcion(rs.getString("descripcion"));
                estado.setActivo(rs.getBoolean("activo"));
                estados.add(estado);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return estados;
    }

    @Override
    public EstadoTicket buscar(int estadoTicketId) {
        EstadoTicket estado = new EstadoTicket();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_estado_ticket(?)}");
            
            cs.setInt("_ID", estadoTicketId);
            ResultSet rs = cs.executeQuery();

            while(rs.next()){
                estado.setEstadoId(rs.getInt("estado_id"));
                estado.setNombre(rs.getString("nombre"));
                estado.setDescripcion(rs.getString("descripcion"));
                estado.setActivo(rs.getBoolean("activo"));
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        
        return estado;
    }
    
}
