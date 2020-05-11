/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.model.Proveedor;


public class ProveedorMySQL implements ProveedorDAO {
    
    Connection con;
    
    @Override
    public int insertar(Proveedor proveedor) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_PROVEEDOR(?)}");
            cs.setString(1, proveedor.getNombre());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_EMPLEADO");
            con.close();
         }catch(Exception ex){
             System.out.println(ex.getMessage());
         }
         return rpta;
    }

    @Override
    public int actualizar(Proveedor proveedor) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idProveedor) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Proveedor> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
