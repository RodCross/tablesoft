package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.TareaPredeterminada;


public class CategoriaMySQL implements CategoriaDAO{
    Connection con;
    @Override
    public int insertar(Categoria categoria) {
        int rpta = 0;
        try {
           
           Class.forName("com.mysql.cj.jdbc.Driver");
           
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_categoria()}");
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                categoria.setActivo(rs.getBoolean("activo"));
                categorias.add(categoria);
            }
            
            for(Categoria cat : categorias){
                cs = con.prepareCall("{call listar_tarea_predeterminada_categoria(?)}");
                cs.setInt("_ID", cat.getCategoriaId());
                rs = cs.executeQuery();
                
                while(rs.next()){
                    TareaPredeterminada tarea = new TareaPredeterminada();
                    
                    tarea.setTareaPredeterminadaId(rs.getInt("tareas_predeterminadas_id"));
                    tarea.setDescripcion(rs.getString("descripcion"));
                    tarea.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                    tarea.setActivo(rs.getBoolean("activo"));
                    
                    cat.agregarTareaPredeterminada(tarea);
                }
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
            Class.forName("com.mysql.cj.jdbc.Driver");
           
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_categoria_equipo(?)}");
            cs.setInt("_ID", equipo.getEquipoId());
            ResultSet rs=cs.executeQuery();
            
            
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                categoria.setActivo(rs.getBoolean("activo"));
                categorias.add(categoria);
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categorias;
    }
    
    @Override public ArrayList<Categoria> listarDisponibles(){
        ArrayList<Categoria> categorias = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
           
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call listar_categoria_disponibles()}");
            ResultSet rs=cs.executeQuery();
            
            
            while(rs.next()) {
                Categoria categoria = new Categoria();
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                categoria.setActivo(rs.getBoolean("activo"));
                categorias.add(categoria);
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categorias;
    }

    @Override
    public Categoria buscar(int categoriaId) {
        Categoria categoria = new Categoria();
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call buscar_categoria(?)}");
            cs.setInt("_ID", categoriaId);
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                categoria.setCategoriaId(rs.getInt("categoria_id"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setDescripcion(rs.getString("descripcion"));
                categoria.setActivo(rs.getBoolean("activo"));
            }
            
            cs = con.prepareCall("{call listar_tarea_predeterminada_categoria(?)}");
            cs.setInt("_ID", categoriaId);
            rs = cs.executeQuery();
            
            while(rs.next()){
                TareaPredeterminada tarea = new TareaPredeterminada();
                    
                tarea.setTareaPredeterminadaId(rs.getInt("tareas_predeterminadas_id"));
                tarea.setDescripcion(rs.getString("descripcion"));
                tarea.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                tarea.setActivo(rs.getBoolean("activo"));

                categoria.agregarTareaPredeterminada(tarea);
            }

            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return categoria;
    }
}
