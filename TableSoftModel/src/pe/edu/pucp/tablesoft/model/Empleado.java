package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Empleado extends Usuario {
    
    private int empleadoId;
    private ArrayList<Ticket> listaTickets;

    // Constructores
    
    public Empleado() {
        this.listaTickets = new ArrayList<>();
    }
    
    public Empleado(String codigo, String dni, String nombre, String usuarioEmail) {
        super(codigo, dni, nombre, usuarioEmail);
        this.listaTickets = new ArrayList<>();
    }
    
    // Getters y setters

    public int getEmpleadoId() {
        return empleadoId;
    }

    public void setEmpleadoId(int empleadoId) {
        this.empleadoId = empleadoId;
    }

    public ArrayList<Ticket> getListaTickets() {
        return listaTickets;
    }

    public void setListaTickets(ArrayList<Ticket> listaTickets) {
        this.listaTickets = listaTickets;
    }

    // Metodos del negocio
    public void agregarTicket(Ticket ticket) {
        listaTickets.add(ticket);
    }

    public String obtenerEstado(int id_ticket) {
        for (Ticket ticket : listaTickets) {
            if (id_ticket == ticket.getTicketId()) {
                return ticket.getEstado();
            }
        }
        return ""; // not found
    }
    
    public ArrayList<Ticket> listarTickets() {
        // FALTA
        // Actualiza el atributo lista_ticket y lo llena con los tickets creados por este empleado
        // Estos ya podrian estar en la BD
        // Usa TicketDAO.listar() pero filtra solo aquellos creados por this.id_empleado
        // Los asigna a este empleado y devuelve la lista
        
        return this.listaTickets;
    }
}