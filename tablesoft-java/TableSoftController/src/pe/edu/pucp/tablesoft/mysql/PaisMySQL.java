/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.mysql;

import java.sql.Connection;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.dao.PaisDAO;
import pe.edu.pucp.tablesoft.model.Pais;

public class PaisMySQL implements PaisDAO{
    
    Connection con;

    @Override
    public ArrayList<Pais> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
