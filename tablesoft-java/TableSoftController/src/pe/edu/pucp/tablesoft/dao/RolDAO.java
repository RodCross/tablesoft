package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Rol;

/*
 * @author migue
 */
public interface RolDAO {
    // Metodos normales
    int insertar(Rol rol);
    int actualizar(Rol rol);
    int eliminar(Rol rol);
    ArrayList<Rol> listar();
}
