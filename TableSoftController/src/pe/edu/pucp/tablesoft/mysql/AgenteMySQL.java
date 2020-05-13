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
import pe.edu.pucp.tablesoft.model.Administrador;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Supervisor;


public class AgenteMySQL implements AgenteDAO{

    @Override
    public int insertar(Agente agente) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            String rol;
            if (agente instanceof Administrador) {
                rol = "Administrador";
            }
            else if (agente instanceof Supervisor) {
                rol = "Supervisor";
            }
            else {
                rol = "Agente";
            }
            
            CallableStatement cs = con.prepareCall("{CALL insertar_agente(?,?,?,?,?,?,?)}");
            cs.registerOutParameter(1, java.sql.Types.INTEGER);
            cs.setString(2, agente.getCodigo());
            cs.setString(3, agente.getDni());
            cs.setString(4, agente.getNombre());
            cs.setString(5, agente.getUsuarioEmail());
            cs.setString(6, agente.getAgenteEmail());
            cs.setString(7, rol);
            cs.executeUpdate();
            res = cs.getInt(1);
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Agente agente) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL actualizar_agente(?,?,?,?,?)}");
            
            cs.setInt(1, agente.getAgenteId());
            cs.setString(2, agente.getCodigo());
            cs.setString(3, agente.getAgenteEmail());
            cs.setString(4, "Agente");
            cs.setInt(5, agente.getEquipo().getEquipoId());
            
            cs.executeUpdate();
            res = 1;
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int eliminar(int agenteId) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL eliminar_agente(?)}");
            
            cs.setInt(1, agenteId);
            
            cs.executeUpdate();
            res = 1;
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public ArrayList<Agente> listar() {
        ArrayList<Agente> agentes = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            //Ejecutar una sentencia
            CallableStatement cs = con.prepareCall("{CALL listar_agente()}");
            ResultSet rs=cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Agente agente = new Agente();
                agente.setAgenteId(rs.getInt("agente_id"));
                agente.setCodigo(rs.getString("codigo"));
                agente.setDni(rs.getString("dni"));
                agente.setNombre(rs.getString("nombre"));
                agente.setUsuarioEmail(rs.getString("usuario_email"));
                agente.setAgenteEmail(rs.getString("agente_email"));
                Equipo equipo = new Equipo(rs.getInt("equipo_id"));
                agente.setEquipo(equipo);
                agentes.add(agente);
            }
            //cerrar conexion
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        //Devolviendo los agentes
        return agentes;
    }
    
}
