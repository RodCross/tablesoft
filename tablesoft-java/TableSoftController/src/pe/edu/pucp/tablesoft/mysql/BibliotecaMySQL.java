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
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.model.Biblioteca;


public class BibliotecaMySQL implements BibliotecaDAO {

    @Override
    public int insertar(Biblioteca biblioteca) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_biblioteca(?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", biblioteca.getNombre());
            cs.setString("_ABREVIATURA", biblioteca.getAbreviatura());
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            biblioteca.setBibliotecaId(rpta);
            biblioteca.setActivo(true);
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Biblioteca biblioteca) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_biblioteca(?,?,?)}");
            cs.setInt("_ID", biblioteca.getBibliotecaId());
            cs.setString("_NOMBRE", biblioteca.getNombre());
            cs.setString("_ABREVIATURA", biblioteca.getAbreviatura());
            rpta=cs.executeUpdate();
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int eliminar(Biblioteca biblioteca) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión

            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            Connection con;
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_biblioteca(?)}");
            cs.setInt("_ID", biblioteca.getBibliotecaId());
            rpta = cs.executeUpdate();
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<Biblioteca> listar() {
        ArrayList<Biblioteca> bibliotecas=new ArrayList<>();
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
                    "{CALL listar_biblioteca()}");
            ResultSet rs=cs.executeQuery();
            // Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Biblioteca biblioteca = new Biblioteca();
                biblioteca.setBibliotecaId(rs.getInt("biblioteca_id"));
                biblioteca.setNombre(rs.getString("nombre"));
                biblioteca.setAbreviatura(rs.getString("abreviatura"));
                biblioteca.setActivo(rs.getBoolean("activo"));
                bibliotecas.add(biblioteca);
            }
            // No olvidarse de cerrar las conexiones
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        // Devolviendo las bibliotecas
        return bibliotecas;
    }
    
}
