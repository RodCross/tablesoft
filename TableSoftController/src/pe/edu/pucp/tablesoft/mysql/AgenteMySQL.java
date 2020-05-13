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
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Equipo;


public class AgenteMySQL implements AgenteDAO{

    @Override
    public int insertar(Agente agente) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call INSERTAR_AGENTE(?,?,?,?)}");
            
            cs.registerOutParameter("agente_id", java.sql.Types.INTEGER);
            cs.setString(2, agente.getCodigoPucp());
            cs.setString(3, agente.getAgenteEmail());
            cs.setString(4, "Agente");
            
            res =cs.executeUpdate();
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Agente agente) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call ACTUALIZAR_AGENTE(?,?,?,?,?)}");
            
            cs.setInt(1, agente.getAgenteId());
            cs.setString(2, agente.getCodigoPucp());
            cs.setString(3, agente.getAgenteEmail());
            cs.setString(4, "Agente");
            cs.setInt(5, agente.getEquipo().getId_equipo());
            
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
    public int eliminar(int idAgente) {
        int res = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{call ELIMINAR_AGENTE(?)}");
            
            cs.setInt(1, idAgente);
            
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
    public ArrayList<Agente> listar() {
        ArrayList<Agente> agentes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            //Ejecutar una sentencia
            CallableStatement cs = con.prepareCall("{call LISTAR_AGENTE()}");
            ResultSet rs=cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Agente agente = new Agente();
                agente.setAgenteId(rs.getInt("agente_id"));
                agente.setCodigoPucp(rs.getString("codigo"));
                agente.setDni(rs.getString("dni"));
                agente.setNombre(rs.getString("nombre"));
                agente.setCorreoElectronico(rs.getString("usuario_email"));
                agente.setAgenteEmail(rs.getString("agente_email"));
                Equipo equipo = new Equipo(rs.getInt("equipo_id"));
                agente.setEquipo(equipo);
                agentes.add(agente);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los empleados
        return agentes;
    }
    
}
