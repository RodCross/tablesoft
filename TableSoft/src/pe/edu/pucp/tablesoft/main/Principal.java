package pe.edu.pucp.tablesoft.main;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.dao.UsuarioDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Proveedor;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.model.Usuario;
import pe.edu.pucp.tablesoft.mysql.AgenteMySQL;
import pe.edu.pucp.tablesoft.mysql.CategoriaMySQL;
import pe.edu.pucp.tablesoft.mysql.EmpleadoMySQL;
import pe.edu.pucp.tablesoft.mysql.EquipoMySQL;
import pe.edu.pucp.tablesoft.mysql.ProveedorMySQL;
import pe.edu.pucp.tablesoft.mysql.TicketMySQL;
import pe.edu.pucp.tablesoft.mysql.UrgenciaMySQL;
import pe.edu.pucp.tablesoft.mysql.UsuarioMySQL;

public class Principal {
    public static void main(String[] args) {
        TicketDAO ticketDao = new TicketMySQL();
        ArrayList<Ticket> tickets;
        
        tickets = ticketDao.listar();
        for (Ticket ticket : tickets) {
            System.out.println(ticket.mostrarDatos());
        }
    }
}