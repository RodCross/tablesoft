package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Biblioteca;

/*
 * @author migue
 */
public interface BibliotecaDAO {
    // Metodos normales
    int insertar(Biblioteca biblioteca);
    int actualizar(Biblioteca biblioteca);
    int eliminar(Biblioteca biblioteca);
    ArrayList<Biblioteca> listar();
}
