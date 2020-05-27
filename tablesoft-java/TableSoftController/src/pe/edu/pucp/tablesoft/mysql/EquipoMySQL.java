package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.model.Equipo;


public class EquipoMySQL implements EquipoDAO{
    Connection con;
    @Override
    public int insertar(Equipo equipo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call insertar_equipo(?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", equipo.getNombre());
            cs.setString("_DESCRIPCION", equipo.getDescripcion());
            cs.setTimestamp("_FECHA_CREACION", Timestamp.valueOf(LocalDateTime.now()));
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            con.close();
            equipo.setEquipoId(rpta);
            equipo.setActivo(true);

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Equipo equipo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call actualizar_equipo(?,?,?,?)}");
            cs.setInt("_ID", equipo.getEquipoId());
            cs.setString("_NOMBRE", equipo.getNombre());
            cs.setString("_DESCRIPCION", equipo.getDescripcion());
            cs.setTimestamp("_FECHA", Timestamp.valueOf(equipo.getFechaCreacion()));
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(Equipo equipo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call eliminar_equipo(?)}");
            cs.setInt("_ID", equipo.getEquipoId());
            
            cs.executeUpdate();

            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Equipo> listar() {
        
        ArrayList<Equipo> equipos = new ArrayList<>();
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_equipo()}");
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()){
                Equipo equipo = new Equipo();
                
                equipo.setEquipoId(rs.getInt("equipo_id"));
                equipo.setDescripcion(rs.getString("descripcion"));
                equipo.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                equipo.setNombre(rs.getString("nombre"));
                equipo.setActivo(true);
                
                equipos.add(equipo);
            }
            
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return equipos;
    }

    @Override
    public Equipo buscar(int equipoId) {
        Equipo equipo = new Equipo();
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            CallableStatement cs = con.prepareCall(
                    "{call buscar_equipo(?)}");
            cs.setInt("_ID", equipoId);
            ResultSet rs=cs.executeQuery();
            
            //CategoriaDAO daoCategoria = new CategoriaMySQL();
            while(rs.next()){
                
                equipo.setEquipoId(rs.getInt("equipo_id"));
                equipo.setDescripcion(rs.getString("descripcion"));
                equipo.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                equipo.setNombre(rs.getString("nombre"));
                equipo.setActivo(true);
                
                //equipo.setListaCategorias(daoCategoria.listarxEquipo(equipo));
            }
            
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return equipo;
    }
    
}
