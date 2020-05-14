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
                rol = "ADMINISTRADOR";
            }
            else if (agente instanceof Supervisor) {
                rol = "SUPERVISOR";
            }
            else {
                rol = "AGENTE";
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
            agente.setAgenteId(res);
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Agente agente) {
        int res = 0;
        
        String rol;
        if (agente instanceof Administrador) {
            rol = "ADMINISTRADOR";
        }
        else if (agente instanceof Supervisor) {
            rol = "SUPERVISOR";
        }
        else {
            rol = "AGENTE";
        }
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL actualizar_agente(?,?,?,?,?,?,?,?)}");
            
            cs.setInt(1, agente.getAgenteId());
            cs.setString(2, agente.getCodigo());
            cs.setString(3, agente.getDni());
            cs.setString(4, agente.getNombre());
            cs.setString(5, agente.getUsuarioEmail());
            cs.setString(6, agente.getAgenteEmail());
            cs.setString(7, rol);
            cs.setInt(8, agente.getEquipo().getEquipoId());
            
            res = cs.executeUpdate();
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
                Equipo equipo;
                String rol = rs.getString("rol");
                if(null != rol)switch (rol) {
                    case "AGENTE":
                        Agente agente = new Agente();
                        agente.setAgenteId(rs.getInt("agente_id"));
                        agente.setCodigo(rs.getString("codigo"));
                        agente.setDni(rs.getString("dni"));
                        agente.setNombre(rs.getString("nombre"));
                        agente.setUsuarioEmail(rs.getString("usuario_email"));
                        agente.setAgenteEmail(rs.getString("agente_email"));
                        equipo = new Equipo(rs.getInt("equipo_id"));
                        agente.setEquipo(equipo);
                        agentes.add(agente);
                        break;
                    case "SUPERVISOR":
                        Supervisor sup = new Supervisor();
                        sup.setAgenteId(rs.getInt("agente_id"));
                        sup.setCodigo(rs.getString("codigo"));
                        sup.setDni(rs.getString("dni"));
                        sup.setNombre(rs.getString("nombre"));
                        sup.setUsuarioEmail(rs.getString("usuario_email"));
                        sup.setAgenteEmail(rs.getString("agente_email"));
                        equipo = new Equipo(rs.getInt("equipo_id"));
                        sup.setEquipo(equipo);
                        agentes.add(sup);
                        break;
                    case "ADMINISTRADOR":
                        Administrador admin = new Administrador();
                        admin.setAgenteId(rs.getInt("agente_id"));
                        admin.setCodigo(rs.getString("codigo"));
                        admin.setDni(rs.getString("dni"));
                        admin.setNombre(rs.getString("nombre"));
                        admin.setUsuarioEmail(rs.getString("usuario_email"));
                        admin.setAgenteEmail(rs.getString("agente_email"));
                        equipo = new Equipo(rs.getInt("equipo_id"));
                        admin.setEquipo(equipo);
                        agentes.add(admin);
                        break;
                    default:
                        break;
                }
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
