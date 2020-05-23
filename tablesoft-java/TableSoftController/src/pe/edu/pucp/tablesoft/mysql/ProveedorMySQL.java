package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.model.Proveedor;

public class ProveedorMySQL implements ProveedorDAO {
    @Override
    public int insertar(Proveedor proveedor) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_proveedor(?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", proveedor.getNombre());
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            proveedor.setProveedorId(rpta);
            con.close();
        } catch(Exception ex) {
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
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_proveedor(?,?)}");
            cs.setInt("_ID", proveedor.getProveedorId());
            cs.setString("_NOMBRE", proveedor.getNombre());
            rpta=cs.executeUpdate();
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int eliminar(int idProveedor) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_proveedor(?)}");
            cs.setInt("_ID", idProveedor);
            rpta = cs.executeUpdate();
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
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
            Connection con;
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
                proveedor.setNombre(rs.getString("nombre"));
                proveedores.add(proveedor);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return proveedores;
    }
}