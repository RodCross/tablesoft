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
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.TareaPredeterminada;

/*
 * @author migue
 */
public class TareaPredeterminadaMySQL implements TareaPredeterminadaDAO {
    Connection con;
    
    @Override
    public int insertar(TareaPredeterminada tareaPred, Categoria categoria) {
        
        int rpta = 0;
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{CALL insertar_tarea_predeterminada(?,?,?,?)}");
           
           cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
           cs.setInt("_CATEGORIA_ID", categoria.getCategoriaId());
           cs.setString("_DESCRIPCION", tareaPred.getDescripcion());
           cs.setTimestamp("_FECHA_CREACION", Timestamp.valueOf(LocalDateTime.now()));
           
           cs.executeUpdate();
           rpta = cs.getInt("_ID");
           tareaPred.setTareaPredeterminadaId(rpta);
           con.close();
           
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(TareaPredeterminada tareaPred) {
        int rpta = 0;
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{CALL actualizar_tarea_predeterminada(?,?,?)}");
           
           cs.setInt("_ID", tareaPred.getTareaPredeterminadaId());
           cs.setString("_DESCRIPCION", tareaPred.getDescripcion());
           cs.setTimestamp("_FECHA_CREACION", Timestamp.valueOf(LocalDateTime.now()));
           
           cs.executeUpdate();
           con.close();
           
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(TareaPredeterminada tareaPred) {
        int rpta = 0;
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{CALL eliminar_tarea_predeterminada(?)}");
           
           cs.setInt("_ID", tareaPred.getTareaPredeterminadaId());
                      
           cs.executeUpdate();
           con.close();
           
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<TareaPredeterminada> listarxCategoria(Categoria categoria) {
        ArrayList<TareaPredeterminada> tareas = new ArrayList<>();
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{CALL listar_tarea_predeterminada_categoria(?)}");
           
           cs.setInt("_ID", categoria.getCategoriaId());
           
           ResultSet rs = cs.executeQuery();
           
           while(rs.next()){
               TareaPredeterminada tarea = new TareaPredeterminada();
               
               tarea.setTareaPredeterminadaId(rs.getInt("tareas_predeterminadas_id"));
               tarea.setDescripcion(rs.getString("descripcion"));
               tarea.setFechaCreacion(rs.getTimestamp("fecha").toLocalDateTime());
               tarea.setActivo(true);
           }
           
           con.close();
           
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return tareas;
    }

}
