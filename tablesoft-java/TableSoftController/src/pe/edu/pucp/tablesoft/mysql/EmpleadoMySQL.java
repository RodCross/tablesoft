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
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.model.Biblioteca;
import pe.edu.pucp.tablesoft.model.Empleado;


public class EmpleadoMySQL implements EmpleadoDAO{
    Connection con;
    @Override
    public int insertar(Empleado empleado) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_empleado(?,?,?,?,?,?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_CODIGO", empleado.getCodigo());
            cs.setString("_NOMBRE", empleado.getNombre());
            cs.setString("_APELLIDO_PATERNO", empleado.getApellidoPaterno());
            cs.setString("_APELLIDO_MATERNO", empleado.getApellidoMaterno());
            cs.setString("_DIRECCION", empleado.getDireccion());
            cs.setString("_TELEFONO", empleado.getTelefono());
            cs.setString("_PASSWORD", empleado.getPassword());
            cs.setString("_DNI", empleado.getDni());
            cs.setString("_PERSONA_EMAIL", empleado.getPersonaEmail());
            
            cs.setInt("_BIBLIOTECA_ID", empleado.getBiblioteca().getBibliotecaId());
            
            cs.execute();
            rpta = cs.getInt("_ID");
            empleado.setEmpleadoId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Empleado empleado) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_empleado(?,?,?,?,?,?)}");
            
            cs.setInt("_ID", empleado.getEmpleadoId());
            cs.setString("_CODIGO", empleado.getCodigo());
            cs.setString("_NOMBRE", empleado.getNombre());
            cs.setString("_APELLIDO_PATERNO", empleado.getApellidoPaterno());
            cs.setString("_APELLIDO_MATERNO", empleado.getApellidoMaterno());
            cs.setString("_DIRECCION", empleado.getDireccion());
            cs.setString("_TELEFONO", empleado.getTelefono());
            cs.setString("_PASSWORD", empleado.getPassword());
            cs.setString("_DNI", empleado.getDni());
            cs.setString("_PERSONA_EMAIL", empleado.getPersonaEmail());
            
            cs.setInt("_BIBLIOTECA_ID", empleado.getBiblioteca().getBibliotecaId());
            
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(Empleado empleado) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_empleado(?)}");
            cs.setInt("_ID", empleado.getEmpleadoId());
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Empleado> listar() {
        ArrayList<Empleado> empleados = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_empleado()}");
            
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                Empleado empleado = new Empleado();
                
                empleado.setEmpleadoId(rs.getInt("empleado_id"));
                empleado.setCodigo(rs.getString("codigo"));
                empleado.setDni(rs.getString("dni"));
                empleado.setPersonaEmail(rs.getString("persona_email"));
                empleado.setActivo(rs.getBoolean("activo"));
                empleado.setNombre(rs.getString("nombre"));
                empleado.setApellidoPaterno(rs.getString("apellido_paterno"));
                empleado.setApellidoMaterno(rs.getString("apellido_materno"));
                empleado.setDireccion(rs.getString("direccion"));
                empleado.setTelefono(rs.getString("telefono"));
                empleado.setTipo(rs.getString("tipo").charAt(0));
                
                empleado.getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                empleado.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                empleado.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                empleado.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                
                empleados.add(empleado);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return empleados;
    }

    @Override
    public ArrayList<Empleado> listarxBiblioteca(Biblioteca biblioteca) {
        ArrayList<Empleado> empleados = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_empleado_biblioteca(?)}");
            cs.setInt("_ID", biblioteca.getBibliotecaId());
            
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                Empleado empleado = new Empleado();
                
                empleado.setEmpleadoId(rs.getInt("empleado_id"));
                empleado.setCodigo(rs.getString("codigo"));
                empleado.setDni(rs.getString("dni"));
                empleado.setPersonaEmail(rs.getString("persona_email"));
                empleado.setActivo(rs.getBoolean("activo"));
                empleado.setNombre(rs.getString("nombre"));
                empleado.setApellidoPaterno(rs.getString("apellido_paterno"));
                empleado.setApellidoMaterno(rs.getString("apellido_materno"));
                empleado.setDireccion(rs.getString("direccion"));
                empleado.setTelefono(rs.getString("telefono"));
                empleado.setTipo(rs.getString("tipo").charAt(0));
                
                empleado.getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                empleado.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                empleado.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                empleado.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
                
                empleados.add(empleado);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return empleados;
    }

    @Override
    public Empleado buscar(int empleadoId) {
        Empleado empleado = new Empleado();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_empleado(?)}");
            cs.setInt("_ID", empleadoId);
            
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                
                empleado.setEmpleadoId(rs.getInt("empleado_id"));
                empleado.setCodigo(rs.getString("codigo"));
                empleado.setDni(rs.getString("dni"));
                empleado.setPersonaEmail(rs.getString("persona_email"));
                empleado.setActivo(rs.getBoolean("activo"));
                empleado.setNombre(rs.getString("nombre"));
                empleado.setApellidoPaterno(rs.getString("apellido_paterno"));
                empleado.setApellidoMaterno(rs.getString("apellido_materno"));
                empleado.setDireccion(rs.getString("direccion"));
                empleado.setTelefono(rs.getString("telefono"));
                empleado.setTipo(rs.getString("tipo").charAt(0));
                
                empleado.getBiblioteca().setBibliotecaId(rs.getInt("biblioteca_id"));
                empleado.getBiblioteca().setNombre(rs.getString("biblioteca_nombre"));
                empleado.getBiblioteca().setAbreviatura(rs.getString("biblioteca_abreviatura"));
                empleado.getBiblioteca().setActivo(rs.getBoolean("biblioteca_activo"));
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return empleado;
    }

}
