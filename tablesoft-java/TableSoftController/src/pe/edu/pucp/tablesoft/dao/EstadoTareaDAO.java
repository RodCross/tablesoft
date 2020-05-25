package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.EstadoTarea;

/*
 * @author migue
 */
public interface EstadoTareaDAO {
    // Metodos normales
    int insertar(EstadoTarea estadoTarea);
    int actualizar(EstadoTarea estadoTarea);
    int eliminar(EstadoTarea estadoTarea);
    ArrayList<EstadoTarea> listar();
}
