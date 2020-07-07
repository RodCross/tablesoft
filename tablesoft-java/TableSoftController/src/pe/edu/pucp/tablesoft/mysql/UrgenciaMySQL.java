package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.model.Urgencia;


public class UrgenciaMySQL implements UrgenciaDAO{

    @Override
    public int insertar(Urgencia urgencia) {
        int rpta = 0;
        Connection con;
        try {             
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL insertar_urgencia(?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", urgencia.getNombre());
            cs.setInt("_TIEMPO", urgencia.getPlazoMaximo());
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            urgencia.setUrgenciaId(rpta);
            urgencia.setActivo(true);
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Urgencia urgencia) {
        int rpta = 0;
        Connection con;
        try {             
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL actualizar_urgencia(?,?,?)}");
            cs.setInt(1, urgencia.getUrgenciaId());
            cs.setString(2, urgencia.getNombre());
            cs.setInt(3, urgencia.getPlazoMaximo());
            rpta = cs.executeUpdate();
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int eliminar(Urgencia urgencia) {
        Connection con;
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL eliminar_urgencia(?)}");
            cs.setInt(1, urgencia.getUrgenciaId());
            rpta = cs.executeUpdate();
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<Urgencia> listar() {
        ArrayList<Urgencia> urgencias=new ArrayList<>();
        Connection con;
        try {
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_urgencia()}");
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Urgencia urgencia=new Urgencia();
                urgencia.setUrgenciaId(rs.getInt("urgencia_id"));
                urgencia.setNombre(rs.getString("nombre"));
                urgencia.setPlazoMaximo(rs.getInt("plazo_maximo"));
                urgencia.setActivo(rs.getBoolean("activo"));
                urgencias.add(urgencia);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return urgencias;
    }

    @Override
    public Urgencia buscar(int urgenciaId) {
        Urgencia urgencia=new Urgencia();
        Connection con;
        try {
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_urgencia(?)}");
            cs.setInt("_ID", urgenciaId);
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                
                urgencia.setUrgenciaId(rs.getInt("urgencia_id"));
                urgencia.setNombre(rs.getString("nombre"));
                urgencia.setPlazoMaximo(rs.getInt("plazo_maximo"));
                urgencia.setActivo(rs.getBoolean("activo"));
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return urgencia;
    }

    @Override
    public ArrayList<Urgencia> listarxNombre(String nombre) {
        ArrayList<Urgencia> urgencias=new ArrayList<>();
        Connection con;
        try {
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_urgencia_nombre(?)}");
            cs.setString("_NOMBRE_URGENCIA", nombre);
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Urgencia urgencia=new Urgencia();
                urgencia.setUrgenciaId(rs.getInt("urgencia_id"));
                urgencia.setNombre(rs.getString("nombre"));
                urgencia.setPlazoMaximo(rs.getInt("plazo_maximo"));
                urgencia.setActivo(rs.getBoolean("activo"));
                urgencias.add(urgencia);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return urgencias;
    }
    
}
