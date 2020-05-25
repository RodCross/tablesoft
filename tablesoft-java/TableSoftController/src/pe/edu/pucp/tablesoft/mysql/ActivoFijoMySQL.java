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
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ActivoFijoDAO;
import pe.edu.pucp.tablesoft.model.ActivoFijo;


public class ActivoFijoMySQL implements ActivoFijoDAO {

    @Override
    public int insertar(ActivoFijo activoFijo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_activo_fijo(?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", activoFijo.getNombre());
            cs.setString("_DESCRIPCION", activoFijo.getDescripcion());
            cs.setBoolean("_ACTIVO", activoFijo.getActivo());
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            activoFijo.setActivoFijoId(rpta);
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(ActivoFijo activoFijo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_activo_fijo(?,?,?,?)}");
            cs.setInt("_ID", activoFijo.getActivoFijoId());
            cs.setString("_NOMBRE", activoFijo.getNombre());
            cs.setString("_ABREVIATURA", activoFijo.getDescripcion());
            cs.setBoolean("_ACTIVO", activoFijo.getActivo());
            rpta=cs.executeUpdate();
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int eliminar(ActivoFijo activoFijo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_activo_fijo(?)}");
            cs.setInt("_ID", activoFijo.getActivoFijoId());
            rpta = cs.executeUpdate();
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<ActivoFijo> listar() {
        ArrayList<ActivoFijo> activosFijos=new ArrayList<>();
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
                    "{CALL listar_activo_fijo()}");
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                ActivoFijo activoFijo = new ActivoFijo();
                activoFijo.setActivoFijoId(rs.getInt("proveedor_id"));
                activoFijo.setNombre(rs.getString("nombre"));
                activoFijo.setDescripcion(rs.getString("descripcion"));
                activoFijo.setActivo(rs.getBoolean("activo"));
                activosFijos.add(activoFijo);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo los activosFijos
        return activosFijos;
    }

    @Override
    public ActivoFijo buscar(int activoFijoId) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
