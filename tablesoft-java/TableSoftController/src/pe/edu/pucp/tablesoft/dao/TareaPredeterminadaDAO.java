package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.TareaPredeterminada;

/*
 * @author migue
 */
public interface TareaPredeterminadaDAO {
    // Insertar nueva tarea predeterminada
    // Necesita id de la categoria que corresponde para ingresarlo como FKs
    int insertar(TareaPredeterminada tareaPred, Categoria categoria);
    int actualizar(TareaPredeterminada tareaPred);
    int eliminar(TareaPredeterminada tareaPred);
    // Solo tiene sentido listar las tareas pred correspondientes a una categoria particular
    // Categoria debe contar con su id
    ArrayList<TareaPredeterminada> listarxCategoria(Categoria categoria);
}
