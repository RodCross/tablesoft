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
import pe.edu.pucp.tablesoft.dao.UsuarioDAO;
import pe.edu.pucp.tablesoft.model.Usuario;


public class UsuarioMySQL implements UsuarioDAO {
    @Override
    public int insertar(Usuario usuario) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL insertar_usuario(?,?,?,?)}");
            
            cs.setString(1, usuario.getCodigo());
            cs.setString(2, usuario.getDni());
            cs.setString(3, usuario.getNombre());
            cs.setString(4, usuario.getUsuarioEmail());
            
            cs.executeUpdate();
            
            con.close();
            res = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Usuario usuario) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL actualizar_usuario(?,?,?,?)}");
            
            cs.setString(1, usuario.getCodigo());
            cs.setString(2, usuario.getDni());
            cs.setString(3, usuario.getNombre());
            cs.setString(4, usuario.getUsuarioEmail());
            
            res = cs.executeUpdate();
           
            con.close();
            res = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int eliminar(String codigo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL eliminar_usuario(?)}");
            
            cs.setString(1, codigo);
            
            cs.executeUpdate();

            con.close();
            res = 1;
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public ArrayList<Usuario> listar() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall("{CALL listar_usuario()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Usuario usuario = new Usuario();
                usuario.setCodigo(rs.getString("codigo"));
                usuario.setDni(rs.getString("dni"));
                usuario.setNombre(rs.getString("nombre"));
                usuario.setUsuarioEmail(rs.getString("usuario_email"));
                usuarios.add(usuario);
            }
            //cerrar conexion
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        //Devolviendo los usuarios
        return usuarios;
    }
    
}
