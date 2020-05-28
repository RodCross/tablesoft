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
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Equipo;


public class AgenteMySQL implements AgenteDAO{
    Connection con;
    
    @Override
    public int insertar(Agente agente) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_agente(?,?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_CODIGO", agente.getCodigo());
            cs.setString("_NOMBRE", agente.getNombre());
            cs.setString("_DNI", agente.getDni());
            cs.setString("_PERSONA_EMAIL", agente.getPersonaEmail());
            cs.setString("_AGENTE_EMAIL", agente.getAgenteEmail());
            cs.setInt("_ROL_ID", agente.getRol().getRolId());
            
            cs.execute();
            rpta = cs.getInt("_ID");
            agente.setAgenteId(rpta);
            agente.setActivo(true);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Agente agente) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_agente(?,?,?,?,?,?,?,?)}");
            
            cs.setInt("_ID", agente.getAgenteId());
            cs.setString("_CODIGO", agente.getCodigo());
            cs.setString("_NOMBRE", agente.getNombre());
            cs.setString("_DNI", agente.getDni());
            cs.setString("_PERSONA_EMAIL", agente.getPersonaEmail());
            cs.setString("_AGENTE_EMAIL", agente.getAgenteEmail());
            cs.setInt("_ROL_ID", agente.getRol().getRolId());
            cs.setInt("_EQUIPO_ID", agente.getEquipo().getEquipoId());
            
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Agente> listar() {
        ArrayList<Agente> agentes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_agente()}");
            
            ResultSet rs = cs.executeQuery();
            
            EquipoDAO daoEquipo = new EquipoMySQL();
            RolDAO daoRol = new RolMySQL();
            while(rs.next()){
                Agente agente = new Agente();
                
                agente.setAgenteId(rs.getInt("agente_id"));
                agente.setCodigo(rs.getString("codigo"));
                agente.setDni(rs.getString("dni"));
                agente.setPersonaEmail(rs.getString("persona_email"));
                agente.setAgenteEmail(rs.getString("agente_email"));
                agente.setActivo(rs.getBoolean("activo"));
                agente.setNombre(rs.getString("nombre"));
                
                agente.setEquipo(daoEquipo.buscar(rs.getInt("equipo_id")));
                agente.setRol(daoRol.buscar(rs.getInt("rol_id")));
                agentes.add(agente);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return agentes;
    }

    @Override
    public int eliminar(Agente agente) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_agente(?)}");
            cs.setInt("_ID", agente.getAgenteId());
            
            cs.execute();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Agente> listarxEquipo(Equipo equipo) {
        ArrayList<Agente> agentes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_agente_equipo(?)}");
            cs.setInt("_ID", equipo.getEquipoId());
            
            ResultSet rs = cs.executeQuery();
            
            
            RolDAO daoRol = new RolMySQL();
            while(rs.next()){
                Agente agente = new Agente();
                
                agente.setAgenteId(rs.getInt("agente_id"));
                agente.setCodigo(rs.getString("codigo"));
                agente.setDni(rs.getString("dni"));
                agente.setPersonaEmail(rs.getString("persona_email"));
                agente.setAgenteEmail(rs.getString("agente_email"));
                agente.setActivo(rs.getBoolean("activo"));
                agente.setNombre(rs.getString("nombre"));
                
                agente.setEquipo(equipo);
                agente.setRol(daoRol.buscar(rs.getInt("rol_id")));
                agentes.add(agente);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return agentes;
    }

    @Override
    public Agente buscar(int agenteId) {
        Agente agente = new Agente();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_agente(?)}");
            cs.setInt("_ID", agenteId);
            
            ResultSet rs = cs.executeQuery();
            
            EquipoDAO daoEquipo = new EquipoMySQL();
            RolDAO daoRol = new RolMySQL();
            while(rs.next()){
                
                
                agente.setAgenteId(rs.getInt("agente_id"));
                agente.setCodigo(rs.getString("codigo"));
                agente.setDni(rs.getString("dni"));
                agente.setPersonaEmail(rs.getString("persona_email"));
                agente.setAgenteEmail(rs.getString("agente_email"));
                agente.setActivo(rs.getBoolean("activo"));
                agente.setNombre(rs.getString("nombre"));
                
                agente.setEquipo(daoEquipo.buscar(rs.getInt("equipo_id")));
                agente.setRol(daoRol.buscar(rs.getInt("rol_id")));
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return agente;
    }
    
}
