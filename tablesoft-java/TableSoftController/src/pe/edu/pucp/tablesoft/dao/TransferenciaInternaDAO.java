package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.TransferenciaInterna;

/*
 * @author migue
 */
public interface TransferenciaInternaDAO {
    // Solo puede insertar - no actualiza, de ticket solo interesa el id
    int insertar(TransferenciaInterna transferenciaInterna, Ticket ticket);
    // Solo tiene sentido listar por ticket (solo interesa el id)
    ArrayList<TransferenciaInterna> listarxTicket(Ticket ticket);
}
