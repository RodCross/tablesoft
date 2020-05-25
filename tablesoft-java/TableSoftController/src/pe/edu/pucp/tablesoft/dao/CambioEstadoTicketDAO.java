package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.CambioEstadoTicket;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public interface CambioEstadoTicketDAO {
    // Solo puede insertar - no actualiza, de ticket solo interesa el id
    int insertar(CambioEstadoTicket cambioEstado, Ticket ticket);
    // Solo tiene sentido listar por ticket (solo interesa el id)
    ArrayList<CambioEstadoTicket> listar(Ticket ticket);
}
