package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.EstadoTareaDAO;
import pe.edu.pucp.tablesoft.model.EstadoTarea;

/*
 * @author migue
 */
public class EstadoTareaMySQL implements EstadoTareaDAO {
    
    Connection con;
    
    @Override
    public int insertar(EstadoTarea estadoTarea) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_estado_tarea(?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", estadoTarea.getNombre());
            cs.setString("_DESCRIPCION", estadoTarea.getDescripcion());
                        
            cs.execute();
            rpta = cs.getInt("_ID");
            estadoTarea.setEstadoId(rpta);
            estadoTarea.setActivo(true);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(EstadoTarea estadoTarea) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_estado_tarea(?,?,?)}");
            
            cs.setInt("_ID", estadoTarea.getEstadoId());
            cs.setString("_NOMBRE", estadoTarea.getNombre());
            cs.setString("_DESCRIPCION", estadoTarea.getDescripcion());
                        
            cs.execute();
            rpta = cs.getInt("_ID");
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(EstadoTarea estadoTarea) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_estado_tarea(?,?,?)}");
            
            cs.setInt("_ID", estadoTarea.getEstadoId());
            
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<EstadoTarea> listar() {
        ArrayList<EstadoTarea> estados = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_estado_tarea()}");
            
            ResultSet rs = cs.executeQuery();

            while(rs.next()){
                EstadoTarea estado = new EstadoTarea();
                
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
    public EstadoTarea buscar(int estadoTareaId) {
        EstadoTarea estado = new EstadoTarea();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_estado_tarea(?)}");
            cs.setInt("_ID", estadoTareaId);
            
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
