package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.model.Proveedor;

public class ProveedorMySQL implements ProveedorDAO {
    
    Connection con;
    
    @Override
    public int insertar(Proveedor proveedor) {
        int rpta = 0;
        try {
            

            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_proveedor(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setString("_RUC", proveedor.getRuc());
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_DIRECCION", proveedor.getDireccion());
            cs.setInt("_CIUDAD", proveedor.getCiudad().getCiudadId());
            cs.setString("_TELEFONO", proveedor.getTelefono());
            cs.setString("_EMAIL", proveedor.getEmail());
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID");
            proveedor.setProveedorId(rpta);
            proveedor.setActivo(true);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Proveedor proveedor) {
        int rpta = 0;
        try {
            

            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL actualizar_proveedor(?,?,?,?,?,?,?)}");
            cs.setInt("_ID", proveedor.getProveedorId());
            cs.setString("_RUC", proveedor.getRuc());
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_DIRECCION", proveedor.getDireccion());
            cs.setInt("_CIUDAD", proveedor.getCiudad().getCiudadId());
            cs.setString("_TELEFONO", proveedor.getTelefono());
            cs.setString("_EMAIL", proveedor.getEmail());
            
            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Proveedor> listar() {
        ArrayList<Proveedor> proveedores=new ArrayList<>();
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_proveedor()}");
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                Proveedor proveedor = new Proveedor();
                proveedor.setProveedorId(rs.getInt("proveedor_id"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setEmail(rs.getString("email"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRuc(rs.getString("ruc"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setActivo(rs.getBoolean("activo"));
                
                proveedor.getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                proveedor.getCiudad().setNombre(rs.getString("ciudad_nombre"));
                proveedor.getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                proveedor.getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                
                proveedores.add(proveedor);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return proveedores;
    }
    
    @Override
    public Proveedor buscar(int proveedorId){
        Proveedor proveedor = new Proveedor();
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            
            CallableStatement cs = con.prepareCall(
                    "{CALL buscar_proveedor(?)}");
            cs.setInt("_ID", proveedorId);
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                proveedor.setProveedorId(rs.getInt("proveedor_id"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setEmail(rs.getString("email"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRuc(rs.getString("ruc"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setActivo(rs.getBoolean("activo"));
                                                
                proveedor.getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                proveedor.getCiudad().setNombre(rs.getString("ciudad_nombre"));
                proveedor.getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                proveedor.getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return proveedor;
    }

    @Override
    public int eliminar(Proveedor proveedor) {
        int rpta = 0;
        try {
            

            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);

            CallableStatement cs = con.prepareCall(
                    "{CALL eliminar_proveedor(?)}");
            cs.setInt("_ID", proveedor.getProveedorId());

            cs.executeUpdate();
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
            rpta = -1;
        }
        return rpta;
    }
}