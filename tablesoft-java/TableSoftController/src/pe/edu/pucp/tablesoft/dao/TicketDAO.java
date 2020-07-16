/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.EstadoTicket;
import pe.edu.pucp.tablesoft.model.Ticket;


public interface TicketDAO {
    int insertar(Ticket ticket);            // Insert
                                            // No considera: ArrayLists ni agente
    int actualizar(Ticket ticket);          // Update
                                            // Consideran los ids de Agente, Empleado
                                            // Solo los ids de ActivoFijo, Proveedor, Urgencia, Categoria, Biblioteca
                                            // Considera los cambios en historialEstado e historialTransferencia 
                                            // Como los elementos de esta lista no se pueden eliminar
                                            // Si hay elementos sin id les hace insert, los demas no pueden ser actualizados
                                            // Hace los insert necesarios con TransferenciaInterna/ExternaDAO.insertar() y con CambioEstadoTicketDAO.insertar()
    ArrayList<Ticket> listar();             // Listar
                                            // Solo considera llenar:
                                            // Estado, Empleado, Urgencia, Categoria, Biblioteca
                                            // 
                                            // Si es que hay: Agente, ActivoFijo, Proveedor
    ArrayList<Ticket> listarxAgente(Agente agente);
    ArrayList<Ticket> listarxEmpleado(Empleado empleado);
    ArrayList<Ticket> listarxCategoria(Categoria agente);
    ArrayList<Ticket> listarxEstadoxEquipo(EstadoTicket estado, Equipo equipo);
    Ticket buscar(int ticketId);
}
