package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.TransferenciaExterna;

/*
 * @author migue
 */
public interface TransferenciaExternaDAO {
    // Solo puede insertar - no actualiza, de ticket solo interesa el id
    int insertar(TransferenciaExterna transferenciaExterna, Ticket ticket);
    // Solo tiene sentido listar por ticket (solo interesa el id)
    ArrayList<TransferenciaExterna> listarxTicket(Ticket ticket);
}
