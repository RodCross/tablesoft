/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Ticket;


public interface TicketDAO {
    int insertar(Ticket ticket);
    int actualizar(Ticket ticket);
    int eliminar(int idTicket);
    ArrayList<Ticket> listar();
}
