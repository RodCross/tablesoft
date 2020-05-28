package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


public class CategoriaMySQL implements CategoriaDAO{
    Connection con;
    @Override
    public int insertar(Categoria categoria) {
        int rpta = 0;
        try {
           //Registrar el JAR de conexión
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.urlMySQL, 
                   DBManager.user, DBManager.password);

           CallableStatement cs = con.prepareCall(
                   "{CALL insertar_categoria(?,?,?)}");
           
           cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
           cs.setString("_NOMBRE", categoria.getNombre());
           cs.setString("_DESCRIPCION", categoria.getDescripcion());
           
           cs.executeUpdate();
           rpta = cs.getInt("_ID");
           categoria.setCategoriaId(rpta);
           categoria.setActivo(true);
           con.close();
           
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Categoria categoria) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_categoria(?,?,?)}");
            cs.setInt("_ID", categoria.getCategoriaId());
            cs.setString("_NOMBRE", categoria.getNombre());
            cs.setString("_DESCRIPCION", categoria.getDescripcion());

            cs.executeUpdate();
            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public int eliminar(Categoria categoria) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_categoria(?)}");
            cs.setInt("_ID", categoria.getCategoriaId());
            cs.executeUpdate();
            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Categoria> listar() {
        ArrayList<Categoria> categorias = new ArrayList<>();
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_categoria()}");
            ResultSet rs=cs.executeQuery();
            
            //TareaPredeterminadaDAO daoTareasPred = new TareaPredeterminadaMySQL();
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                //categoria.setTareasPredeterminadas(daoTareasPred.listarxCategoria(categoria));
                categorias.add(categoria);
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categorias;
    }

    @Override
    public ArrayList<Categoria> listarxEquipo(Equipo equipo) {
        ArrayList<Categoria> categorias = new ArrayList<>();
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_categoria_equipo(?)}");
            cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
            ResultSet rs=cs.executeQuery();
            
            //TareaPredeterminadaDAO daoTareasPred = new TareaPredeterminadaMySQL();
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                //categoria.setTareasPredeterminadas(daoTareasPred.listarxCategoria(categoria));
                categorias.add(categoria);
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categorias;
    } 

    @Override
    public int eliminarDeEquipo(Categoria categoria, Equipo equipo) {
        int rpta = 0;
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_categoria_equipo(?,?)}");
            cs.setInt("_ID_CATEGORIA", categoria.getCategoriaId());
            cs.setInt("_ID_EQUIPO", equipo.getEquipoId());
            
            cs.executeUpdate();
            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public Categoria buscar(int categoriaId) {
        Categoria categoria = new Categoria();
        try {
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call buscar_categoria(?)}");
            cs.setInt("_ID", categoriaId);
            ResultSet rs=cs.executeQuery();
            
            //TareaPredeterminadaDAO daoTareasPred = new TareaPredeterminadaMySQL();
            while(rs.next()) {
                
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                //categoria.setTareasPredeterminadas(daoTareasPred.listarxCategoria(categoria));
                
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categoria;
    }
}
