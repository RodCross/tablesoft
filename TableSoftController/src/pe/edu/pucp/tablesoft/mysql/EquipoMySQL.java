package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Supervisor;


public class EquipoMySQL implements EquipoDAO{
 
    @Override
    public int insertar(Equipo equipo) {
        Connection con;
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call insertar_equipo(?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            con.close();
            equipo.setEquipoId(rpta);

        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Equipo equipo) {
        // No puede actualizar el identificador
        throw new UnsupportedOperationException("No se puede actualizar.");
    }

    @Override
    public int eliminar(int idEquipo) {
        Connection con;
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call eliminar_equipo(?)}");
            cs.setInt("_ID", idEquipo);
            cs.executeUpdate();

            con.close();

        } catch(Exception ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Equipo> listar() {
        // Devuelve una lista de los Equipos en la BD
        // Cada equipo estara lleno con su respectiva lista de categorias,
        // agentes y supervisor.
        ArrayList<Equipo> equipos = new ArrayList<>();
        Connection con;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_equipo_agentes()}");
            ResultSet rs=cs.executeQuery();
            
            int equipo_id_anterior = 0, equipo_id_actual;
            Equipo equipo = new Equipo();
            while(rs.next()) {
                equipo_id_actual = rs.getInt("equipo_id");
                if(equipo_id_actual != equipo_id_anterior){
                    equipo = new Equipo();
                    equipos.add(equipo);
                    equipo.setEquipoId(equipo_id_actual);
                }
                try{
                    String rol = rs.getString("rol");
                    if("Supervisor".equals(rol)){
                        Supervisor sup = new Supervisor();
                        sup.setAgenteEmail(rs.getString("agente_email"));
                        sup.setAgenteId(rs.getInt("agente_id"));
                        sup.setCodigo(rs.getString("codigo"));
                        sup.setDni(rs.getString("dni"));
                        sup.setUsuarioEmail(rs.getString("usuario_email"));
                        sup.setNombre(rs.getString("nombre"));
                        sup.setEquipo(equipo);
                        equipo.asignarSupervisor(sup);
                    }
                    if("Agente".equals(rol)){
                        Agente ag = new Agente();
                        ag.setAgenteEmail(rs.getString("agente_email"));
                        ag.setAgenteId(rs.getInt("agente_id"));
                        ag.setCodigo(rs.getString("codigo"));
                        ag.setEquipo(equipo);
                        ag.setDni(rs.getString("dni"));
                        ag.setUsuarioEmail(rs.getString("usuario_email"));
                        ag.setNombre(rs.getString("nombre"));
                        equipo.agregarAgente(ag);
                    }
                    
                } catch(Exception ex){
                    System.out.println(ex.getMessage());
                }
                equipo_id_anterior = equipo_id_actual;
            }
            
            for(Equipo e : equipos) {
                // Para cada equipo buscamos sus categorias
                String sql;
                sql = "SELECT * FROM CATEGORIA WHERE equipo_id = " + e.getEquipoId();
                PreparedStatement ps;
                ps = con.prepareStatement(sql);
                rs = ps.executeQuery();
                while(rs.next()) {
                    Categoria cat = new Categoria();
                    cat.setCategoriaId(rs.getInt("categoria_id"));
                    cat.setNombre(rs.getString("nombre"));
                    cat.setEquipo(e);
                    e.agregarCategoria(cat);
                }
            }
            con.close();
            
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return equipos;
    }
    
}
