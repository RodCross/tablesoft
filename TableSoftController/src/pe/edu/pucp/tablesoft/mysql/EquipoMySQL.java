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
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Supervisor;


public class EquipoMySQL implements EquipoDAO{
 
    @Override
    public int insertar(Equipo equipo) {
        Connection con;
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_EQUIPO(?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            con.close();
            
         }catch(Exception ex){
             System.out.println(ex.getMessage());
         }
         return rpta;
    }

    @Override
    public int actualizar(Equipo equipo) {
        // No puede actualizar el identificador
        throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public int eliminar(int idEquipo) {
        Connection con;
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_EQUIPO(?)}");
            cs.setInt("_ID", idEquipo);
            cs.executeUpdate();
            
            con.close();
            
         }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = -1;
         }
         return rpta;
    }

    @Override
    public ArrayList<Equipo> listar() {
        // Devuelve una lista de los Equipos en la BD
        // Cada equipo estara lleno con su respectiva lista de categorias,
        // agentes y supervisor. Cada agente solo tendra su id.
        ArrayList<Equipo> equipos = new ArrayList<>();
        Connection con;
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            String sql = "SELECT * FROM EQUIPO";
            PreparedStatement ps = con.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Equipo equipo = new Equipo();
                equipo.setId_equipo(rs.getInt("equipo_id"));
                equipos.add(equipo);
            }
            
            for(Equipo e : equipos){
                // Para cada equipo buscamos sus agentes y su supervisor
                sql = "SELECT * FROM AGENTE WHERE equipo_id = " + e.getId_equipo();
                ps = con.prepareStatement(sql);
                rs = ps.executeQuery();
                while(rs.next()){
                    // Verificar el rol
                    String rol = rs.getString("rol");
                    if("Supervisor".equals(rol)){
                        Supervisor sup = new Supervisor();
                        sup.setAgenteEmail(rs.getString("agente_email"));
                        sup.setAgenteId(rs.getInt("agente_id"));
                        sup.setCodigoPucp(rs.getString("codigo"));
                    }
                }
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return equipos;
    }
    
}
