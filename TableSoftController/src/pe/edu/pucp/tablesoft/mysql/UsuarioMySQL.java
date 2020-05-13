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


public class UsuarioMySQL implements UsuarioDAO{

    @Override
    public int insertar(Usuario usuario) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call INSERTAR_USUARIO(?,?,?,?)}");
            
            cs.setString(1, usuario.getCodigoPucp());
            cs.setString(2, usuario.getDni());
            cs.setString(3, usuario.getNombre());
            cs.setString(4, usuario.getCorreoElectronico());
            
            cs.executeUpdate();
            res = 1;
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Usuario usuario) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call ACTUALIZAR_USUARIO(?,?,?,?)}");
            
            cs.setString(1, usuario.getCodigoPucp());
            cs.setString(2, usuario.getDni());
            cs.setString(3, usuario.getNombre());
            cs.setString(4, usuario.getCorreoElectronico());
            
            cs.executeUpdate();
            res = 1;
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int eliminar(int idUsuario) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call ELIMINAR_USUARIO(?)}");
            
            cs.setInt(1, idUsuario);
            
            cs.executeUpdate();
            res = 1;
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public ArrayList<Usuario> listar() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall("{call LISTAR_USUARIO()}");
            ResultSet rs=cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Usuario usuario = new Usuario();
                usuario.setCodigoPucp(rs.getString("codigo"));
                usuario.setDni(rs.getString("dni"));
                usuario.setNombre(rs.getString("nombre"));
                usuario.setCorreoElectronico(rs.getString("usuario_email"));
                usuarios.add(usuario);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los empleados
        return usuarios;
    }
    
}
