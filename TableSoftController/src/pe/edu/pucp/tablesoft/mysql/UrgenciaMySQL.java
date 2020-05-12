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
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.model.Urgencia;


public class UrgenciaMySQL implements UrgenciaDAO{

    @Override
    public int insertar(Urgencia urgencia) {
        int rpta = 0;
        Connection con;
         try{             
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_URGENCIA(?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", urgencia.getNombre());
            cs.setInt("_TIEMPO", urgencia.getPlazoMaximo());
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            con.close();
         }catch(Exception ex){
             System.out.println(ex.getMessage());
         }
         return rpta;
    }

    @Override
    public int actualizar(Urgencia urgencia) {
        int rpta = 0;
        Connection con;
         try{             
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_URGENCIA(?,?,?,?)}");
            cs.registerOutParameter("_REALIZADO", java.sql.Types.INTEGER);
            cs.setInt("_ID", urgencia.getUrgenciaId());
            cs.setString("_NOMBRE", urgencia.getNombre());
            cs.setInt("_TIEMPO", urgencia.getPlazoMaximo());
            cs.executeUpdate();
            rpta = cs.getInt("_REALIZADO");
            con.close();
         }catch(Exception ex){
             System.out.println(ex.getMessage());
         }
         return rpta;
    }

    @Override
    public int eliminar(int idUrgencia) {
        Connection con;
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_URGENCIA(?,?)}");
            cs.registerOutParameter("_REALIZADO", java.sql.Types.INTEGER);
            cs.setInt("_ID", idUrgencia);
            cs.executeUpdate();
            rpta = cs.getInt("_REALIZADO");
            con.close();
         }catch(Exception ex){
             System.out.println(ex.getMessage());
         }
         return rpta;
    }

    @Override
    public ArrayList<Urgencia> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
