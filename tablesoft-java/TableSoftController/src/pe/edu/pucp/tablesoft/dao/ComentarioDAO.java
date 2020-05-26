package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Comentario;
import pe.edu.pucp.tablesoft.model.Persona;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public interface ComentarioDAO {
    // Insertar nuevo comentario
    // Necesita id del autor y el id del ticket que corresponde para ingresarlos como FKs
    int insertar(Comentario comentario, Persona autor, Ticket ticket);
    // Solo tiene sentido listar los comentarios correspondientes a un ticket particular
    // Ticket debe contar con su id
    ArrayList<Comentario> listarxTicket(Ticket ticket);
}
