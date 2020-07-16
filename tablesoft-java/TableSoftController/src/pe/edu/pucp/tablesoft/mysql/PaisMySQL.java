/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.PaisDAO;
import pe.edu.pucp.tablesoft.model.Pais;

public class PaisMySQL implements PaisDAO{
    
    Connection con;

    @Override
    public ArrayList<Pais> listar() {
        ArrayList<Pais> paises = new ArrayList<>();
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_pais()}");
            ResultSet rs=cs.executeQuery();
            
            while(rs.next()) {
                Pais pais = new Pais();
                pais.setPaisId(rs.getInt("pais_id"));
                pais.setNombre(rs.getString("nombre"));
                
                paises.add(pais);
            }
            
            con.close();
        } catch(SQLException | ClassNotFoundException ex) {
            System.out.println(ex.getMessage());
        }
        
        return paises;
    }
    
}
