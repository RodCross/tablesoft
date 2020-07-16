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
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.PersonaDAO;
import pe.edu.pucp.tablesoft.model.Persona;


public class PersonaMySQL implements PersonaDAO{
    
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    
    @Override
    public Persona verificarPersona(String email,String password) {
        Persona persona=null;
        try{
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            cs = con.prepareCall("{call verificar_persona(?,?)}");
            cs.setString("_EMAIL", email);
            cs.setString("_PASSWORD", password);
            rs = cs.executeQuery();
            if(rs.next()){
                persona=new Persona();
                persona.setCodigo(rs.getString("codigo"));
                persona.setTipo(rs.getString("tipo").charAt(0));
                persona.setDni(rs.getString("dni"));
                persona.setPersonaEmail(rs.getString("persona_email"));
                persona.setNombre(rs.getString("nombre"));
                persona.setApellidoPaterno(rs.getString("apellido_paterno"));
                persona.setApellidoMaterno(rs.getString("apellido_materno"));
                persona.setDireccion(rs.getString("direccion"));
                persona.setTelefono(rs.getString("telefono"));
                persona.setActivo(rs.getBoolean("activo"));
            }   
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close(); con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return persona;
    }

    @Override
    public int verificarCorreo(String email) {
        int rpta=-1;
        try{
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            cs = con.prepareCall("{call verificar_correo(?)}");
            cs.setString("_EMAIL", email);
            rs = cs.executeQuery();
            if(rs.next()){
                rpta=rs.getInt(1);
            }   
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close(); con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return rpta;
    }

    @Override
    public int actualizarPass(String email, String password) {
        int rpta=-1;
        try{
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            cs = con.prepareCall("{call actualizar_pass(?,?)}");
            cs.setString("_EMAIL", email);
            cs.setString("_PASS", password);
            
            cs.executeUpdate();
            rpta = 1;
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return rpta;
    }

    @Override
    public Persona buscarxEmail(String email) {
        Persona persona = new Persona();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call buscar_persona_email(?)}");
            cs.setString("_EMAIL", email);
            
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                persona.setNombre(rs.getString("nombre"));
                persona.setApellidoPaterno(rs.getString("apellido_paterno"));
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return persona;
    }    
}
