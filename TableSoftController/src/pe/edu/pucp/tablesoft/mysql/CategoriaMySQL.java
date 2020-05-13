package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


public class CategoriaMySQL implements CategoriaDAO{

    @Override
    public int insertar(Categoria categoria) {
        Connection con;
        int rpta = 0;
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{call INSERTAR_CATEGORIA(?,?,?)}");
           cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
           cs.setString("_NOMBRE", categoria.getNombre());
           cs.setInt("_EQUIPO", categoria.getEquipo().getEquipoId());
           cs.executeUpdate();
           rpta = cs.getInt("_ID");
           categoria.setIdCategoria(rpta);
           con.close();

        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Categoria categoria) {
        Connection con;
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_CATEGORIA(?,?,?)}");
            cs.setInt("_ID", categoria.getIdCategoria());
            cs.setString("_NOMBRE", categoria.getNombre());
            cs.setInt("_ID_EQUIPO", categoria.getEquipo().getEquipoId());
            cs.executeUpdate();
            con.close();

        } catch(Exception ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(int idCategoria) {
        Connection con;
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_CATEGORIA(?)}");
            cs.setInt("_ID", idCategoria);
            cs.executeUpdate();
            con.close();

        } catch(Exception ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Categoria> listar() {
        // Devuelve una lista de las Categorias en la BD
        // Cada categoria estara llena con su respectivo equipo lleno
        // Pero sin la lista de tickets
        ArrayList<Categoria> categorias = new ArrayList<>();
        Connection con;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            String sql = "SELECT * FROM categoria";
            PreparedStatement ps = con.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            
            //Saco una lista de equipos
            ArrayList<Equipo> equipos = new ArrayList<>();
            EquipoMySQL equipoSQL = new EquipoMySQL();
            equipos = equipoSQL.listar();
            
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setIdCategoria(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                // Agregamos su equipo correspondiente
                for(Equipo e:equipos) {
                    if(rs.getInt("id_equipo") == e.getEquipoId()) {
                        categoria.setEquipo(e);
                        break;
                    }
                }
                categorias.add(categoria);
            }

            con.close();
            
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return categorias;
    }
    
}
