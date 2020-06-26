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
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


public class EquipoMySQL implements EquipoDAO{
    Connection con;
    @Override
    public int insertar(Equipo equipo) {
        int rpta = 0;
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call insertar_equipo(?,?,?,?)}");
            
            LocalDateTime temp = LocalDateTime.now();
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", equipo.getNombre());
            cs.setString("_DESCRIPCION", equipo.getDescripcion());
            cs.setTimestamp("_FECHA_CREACION", Timestamp.valueOf(temp));
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            
            for(Agente a: equipo.getListaAgentes()){
                cs = con.prepareCall("{call actualizar_agente_equipo(?,?)}");
                cs.setInt("_ID", a.getAgenteId());
                cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
                
                cs.executeUpdate();
            }
            
            for(Categoria c : equipo.getListaCategorias()){
                cs = con.prepareCall(
                "{call insertar_categoria_equipo(?,?)}");
                cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
                cs.setInt("_CATEGORIA_ID", c.getCategoriaId());

                cs.executeUpdate();
            }
            
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call actualizar_equipo(?,?,?)}");
            cs.setInt("_ID", equipo.getEquipoId());
            cs.setString("_NOMBRE", equipo.getNombre());
            cs.setString("_DESCRIPCION", equipo.getDescripcion());
            
            cs.executeUpdate();
            
            for(Agente a: equipo.getListaAgentes()){
                cs = con.prepareCall("{call actualizar_agente_equipo(?,?)}");
                cs.setInt("_ID", a.getAgenteId());
                cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
                
                cs.executeUpdate();
            }
            
            for(Categoria c : equipo.getListaCategorias()){
                if(c.getActivo()){
                    cs = con.prepareCall(
                    "{call insertar_categoria_equipo(?,?)}");
                    cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
                    cs.setInt("_CATEGORIA_ID", c.getCategoriaId());

                    cs.executeUpdate();
                }
                else{
                    cs = con.prepareCall(
                    "{CALL eliminar_categoria_equipo(?,?)}");
                    cs.setInt("_ID_CATEGORIA", c.getCategoriaId());
                    cs.setInt("_ID_EQUIPO", equipo.getEquipoId());
            
                    cs.executeUpdate();
                }
            }
            
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
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
            for (Equipo e: equipos){
                cs = con.prepareCall("{call listar_agente_equipo(?)}");
                cs.setInt("_ID", e.getEquipoId());
                rs = cs.executeQuery();
                
                while(rs.next()){
                    Agente agente = new Agente();
                
                    agente.setAgenteId(rs.getInt("agente_id"));
                    agente.setCodigo(rs.getString("codigo"));
                    agente.setDni(rs.getString("dni"));
                    agente.setPersonaEmail(rs.getString("persona_email"));
                    agente.setAgenteEmail(rs.getString("agente_email"));
                    agente.setActivo(rs.getBoolean("activo"));
                    agente.setNombre(rs.getString("nombre"));
                    agente.setApellidoPaterno(rs.getString("apellido_paterno"));
                    agente.setApellidoMaterno(rs.getString("apellido_materno"));
                    agente.setDireccion(rs.getString("direccion"));
                    agente.setTelefono(rs.getString("telefono"));
                    agente.setTipo(rs.getString("tipo").charAt(0));

                    agente.getEquipo().setEquipoId(rs.getInt("equipo_id"));
                    agente.getEquipo().setDescripcion(rs.getString("equipo_descripcion"));
                    agente.getEquipo().setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                    agente.getEquipo().setNombre(rs.getString("equipo_nombre"));
                    agente.getEquipo().setActivo(rs.getBoolean("equipo_activo"));

                    agente.getRol().setRolId(rs.getInt("rol_id"));
                    agente.getRol().setNombre(rs.getString("rol_nombre"));
                    agente.getRol().setDescripcion(rs.getString("rol_descripcion"));
                    agente.getRol().setActivo(rs.getBoolean("rol_activo"));

                    e.getListaAgentes().add(agente);
                }
                
                cs = con.prepareCall("{call listar_categoria_equipo(?)}");
                cs.setInt("_ID", e.getEquipoId());
                rs = cs.executeQuery();
                
                while(rs.next()){
                    Categoria categoria = new Categoria();
                    categoria.setCategoriaId(rs.getInt("categoria_id"));
                    categoria.setNombre(rs.getString("nombre"));
                    categoria.setDescripcion(rs.getString("descripcion"));
                    categoria.setActivo(rs.getBoolean("activo"));
                    
                    e.getListaCategorias().add(categoria);
                }
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
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            CallableStatement cs = con.prepareCall(
                    "{call buscar_equipo(?)}");
            cs.setInt("_ID", equipoId);
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()){
                
                equipo.setEquipoId(rs.getInt("equipo_id"));
                equipo.setDescripcion(rs.getString("descripcion"));
                equipo.setFechaCreacion(rs.getTimestamp("fecha_creacion").toLocalDateTime());
                equipo.setNombre(rs.getString("nombre"));
                equipo.setActivo(true);
                
            }
            
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return equipo;
    }

    @Override
    public int agregarCategoria(Equipo equipo, Categoria categoria) {
        int rpta = 0;
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{call insertar_categoria_equipo(?,?)}");
            cs.setInt("_EQUIPO_ID", equipo.getEquipoId());
            cs.setInt("_CATEGORIA_ID", categoria.getCategoriaId());
            
            cs.executeUpdate();

            con.close();

        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }
    
    @Override
    public int quitarCategoria(Equipo equipo, Categoria categoria) {
        int rpta = 0;
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
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
    
}
