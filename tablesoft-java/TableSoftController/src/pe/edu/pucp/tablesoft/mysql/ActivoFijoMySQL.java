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

            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_activo_fijo(?,?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", activoFijo.getNombre());
            cs.setString("_CODIGO", activoFijo.getCodigo());
            cs.setString("_MARCA", activoFijo.getMarca());
            cs.setString("_TIPO", activoFijo.getTipo());
            cs.executeUpdate();
            
            rpta = cs.getInt("_ID");
            activoFijo.setActivoFijoId(rpta);
            activoFijo.setActivo(true);
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

            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_activo_fijo(?,?,?,?,?)}");
            cs.setInt("_ID", activoFijo.getActivoFijoId());
            cs.setString("_NOMBRE", activoFijo.getNombre());
            cs.setString("_CODIGO", activoFijo.getCodigo());
            cs.setString("_MARCA", activoFijo.getMarca());
            cs.setString("_TIPO", activoFijo.getTipo());
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

            Class.forName("com.mysql.cj.jdbc.Driver");

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

            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_activo_fijo()}");
            ResultSet rs=cs.executeQuery();

            while(rs.next()) {
                ActivoFijo activoFijo = new ActivoFijo();
                activoFijo.setActivoFijoId(rs.getInt("activo_fijo_id"));
                activoFijo.setNombre(rs.getString("nombre"));
                activoFijo.setCodigo(rs.getString("codigo"));
                activoFijo.setMarca(rs.getString("marca"));
                activoFijo.setTipo(rs.getString("tipo"));
                activoFijo.setActivo(rs.getBoolean("activo"));
                activosFijos.add(activoFijo);
            }

            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }

        return activosFijos;
    }

    @Override
    public ActivoFijo buscar(int activoFijoId) {
        ActivoFijo activoFijo = new ActivoFijo();
        try {

            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_activo_fijo(?)}");
            cs.setInt("_ID", activoFijoId);
            ResultSet rs=cs.executeQuery();

            while(rs.next()) {
                
                activoFijo.setActivoFijoId(rs.getInt("proveedor_id"));
                activoFijo.setNombre(rs.getString("nombre"));
                activoFijo.setCodigo(rs.getString("codigo"));
                activoFijo.setMarca(rs.getString("marca"));
                activoFijo.setTipo(rs.getString("tipo"));
                activoFijo.setActivo(rs.getBoolean("activo"));
            }

            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }

        return activoFijo;
    }
    
}
