package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.model.Proveedor;

public class ProveedorMySQL implements ProveedorDAO {
    
    Connection con;
    
    @Override
    public int insertar(Proveedor proveedor) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_proveedor(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_RUC", proveedor.getRuc());
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_DIRECCION", proveedor.getDireccion());
            cs.setString("_CIUDAD", proveedor.getCiudad());
            cs.setString("_PAIS", proveedor.getPais());
            cs.setString("_TELEFONO", proveedor.getTelefono());
            cs.setString("_EMAIL", proveedor.getEmail());
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            proveedor.setProveedorId(rpta);
            proveedor.setActivo(true);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Proveedor proveedor) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_proveedor(?,?,?,?,?,?,?,?)}");
            cs.setInt("_ID", proveedor.getProveedorId());
            cs.setString("_RUC", proveedor.getRuc());
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_DIRECCION", proveedor.getDireccion());
            cs.setString("_CIUDAD", proveedor.getCiudad());
            cs.setString("_PAIS", proveedor.getPais());
            cs.setString("_TELEFONO", proveedor.getTelefono());
            cs.setString("_EMAIL", proveedor.getEmail());
            
            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Proveedor> listar() {
        ArrayList<Proveedor> proveedores=new ArrayList<>();
        try {
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_proveedor()}");
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Proveedor proveedor = new Proveedor();
                proveedor.setProveedorId(rs.getInt("proveedor_id"));
                proveedor.setCiudad(rs.getString("ciudad"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setEmail(rs.getString("email"));
                proveedor.setPais(rs.getString("pais"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRuc(rs.getString("ruc"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setActivo(rs.getBoolean("activo"));
                proveedores.add(proveedor);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return proveedores;
    }
    
    @Override
    public Proveedor buscar(int proveedorId){
        Proveedor proveedor = new Proveedor();
        try {
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_proveedor(?)}");
            cs.setInt("_ID", proveedorId);
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                proveedor.setProveedorId(rs.getInt("proveedor_id"));
                proveedor.setCiudad(rs.getString("ciudad"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setEmail(rs.getString("email"));
                proveedor.setPais(rs.getString("pais"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRuc(rs.getString("ruc"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setActivo(rs.getBoolean("activo"));
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return proveedor;
    }

    @Override
    public int eliminar(Proveedor proveedor) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_proveedor(?)}");
            cs.setInt("_ID", proveedor.getProveedorId());

            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }
}