package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CiudadDAO;
import pe.edu.pucp.tablesoft.model.Ciudad;
import pe.edu.pucp.tablesoft.model.Pais;

/*
 * @author migue
 */
public class CiudadMySQL implements CiudadDAO{
Connection con;

    @Override
    public ArrayList<Ciudad> listarxPais(Pais pais) {
        ArrayList<Ciudad> ciudades = new ArrayList<>();
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_ciudad_pais(?)}");
            cs.setInt("_ID", pais.getPaisId());
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                Ciudad ciudad = new Ciudad();
                ciudad.getPais().setPaisId(rs.getInt("pais_id"));
                ciudad.getPais().setNombre(rs.getString("pais_nombre"));
                ciudad.setCiudadId(rs.getInt("ciudad_id"));
                ciudad.setNombre(rs.getString("ciudad_nombre"));
                
                ciudades.add(ciudad);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return ciudades;
    }
}
