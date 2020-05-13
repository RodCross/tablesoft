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
        ArrayList<Urgencia> urgencias=new ArrayList<>();
        Connection con;
        try{
            // Registrar el jar de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            // executeQuery se usa para listados
            // executeUpdate se usa para insert, update, delete
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_URGENCIA()}");
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Urgencia urgencia=new Urgencia();
                urgencia.setUrgenciaId(rs.getInt("urgencia_id"));
                urgencia.setNombre(rs.getString("nombre"));
                urgencia.setPlazoMaximo(rs.getInt("horas_plazo_maximo"));
                urgencias.add(urgencia);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        // Devolviendo los empleados
        return urgencias;
    }
    
}
