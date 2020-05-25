package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.ActivoFijo;

/*
 * @author migue
 */
public interface ActivoFijoDAO {
    // Metodos normales
    int insertar(ActivoFijo activoFijo);
    int actualizar(ActivoFijo activoFijo);
    int eliminar(ActivoFijo activoFijo);
    ArrayList<ActivoFijo> listar();
    ActivoFijo buscar(int activoFijoId);
}
