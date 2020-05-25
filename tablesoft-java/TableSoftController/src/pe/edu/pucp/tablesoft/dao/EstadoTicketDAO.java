package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.EstadoTicket;

/*
 * @author migue
 */
public interface EstadoTicketDAO {
    // Metodos normales
    int insertar(EstadoTicket estadoTicket);
    int actualizar(EstadoTicket estadoTicket);
    int eliminar(EstadoTicket estadoTicket);
    ArrayList<EstadoTicket> listar();
    EstadoTicket buscar(int estadoTicketId);
}
