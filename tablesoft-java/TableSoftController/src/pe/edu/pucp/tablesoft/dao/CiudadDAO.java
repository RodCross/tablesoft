package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Ciudad;
import pe.edu.pucp.tablesoft.model.Pais;

/*
 * @author migue
 */
public interface CiudadDAO {
    ArrayList<Ciudad> listarxPais(Pais pais);
}
