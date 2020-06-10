package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Tarea;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public interface TareaDAO {
    // Insertar nueva tarea
    // Necesita id del agente y el id del ticket que corresponde para ingresarlos como FKs
    int insertar(Tarea tarea, Ticket ticket);
    int actualizar(Tarea tarea, Agente agente);
    int eliminar(Tarea tarea);
    // Solo tiene sentido listar las tareas correspondientes a un ticket particular
    // Ticket debe contar con su id
    ArrayList<Tarea> listarxTicket(Ticket ticket);
}
