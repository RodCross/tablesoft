package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.model.Rol;

/*
 * @author migue
 */
public class RolMySQL implements RolDAO{
    Connection con;
    @Override
    public int insertar(Rol rol) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_rol(?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", rol.getNombre());
            cs.setString("_DESCRIPCION", rol.getDescripcion());
                        
            cs.execute();
            rpta = cs.getInt("_ID");
            rol.setRolId(rpta);
            rol.setActivo(true);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Rol rol) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_rol(?,?,?)}");
            
            cs.setInt("_ID", rol.getRolId());
            cs.setString("_NOMBRE", rol.getNombre());
            cs.setString("_DESCRIPCION", rol.getDescripcion());
                        
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
}

    @Override
    public int eliminar(Rol rol) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_rol(?)}");
            
            cs.setInt("_ID", rol.getRolId());
                        
            cs.execute();
            rpta = cs.getInt("_ID");
            rol.setRolId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<Rol> listar() {
        ArrayList<Rol> roles = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_rol()}");
                        
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                Rol rol = new Rol();
                
                rol.setRolId(rs.getInt("rol_id"));
                rol.setNombre(rs.getString("nombre"));
                rol.setDescripcion(rs.getString("descripcion"));
                rol.setActivo(rs.getBoolean("activo"));
                
                roles.add(rol);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return roles;
    }

    @Override
    public Rol buscar(int rolId) {
        Rol rol = new Rol();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_rol(?)}");
            cs.setInt("_ID", rolId);
                        
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                
                rol.setRolId(rs.getInt("rol_id"));
                rol.setNombre(rs.getString("nombre"));
                rol.setDescripcion(rs.getString("descripcion"));
                rol.setActivo(rs.getBoolean("activo"));
                
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rol;
    }

}
