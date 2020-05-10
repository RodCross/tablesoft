package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Empleado extends Usuario {
    
    private int id_empleado;
    private ArrayList<Ticket> lista_tickets;

    // Constructores
    public Empleado(int codigo_pucp, int dni, String nombre) {
        super(codigo_pucp, dni, nombre);
        this.lista_tickets = new ArrayList<>();
    }

    public Empleado(int codigo_pucp, int dni, String nombre, String correo_electronico) {
        super(codigo_pucp, dni, nombre, correo_electronico);
        this.lista_tickets = new ArrayList<>();
    }
    
    public Empleado(){
        this.lista_tickets = new ArrayList<>();
    }
    
    // Getters y setters
    public int getId_empleado() {
        return id_empleado;
    }

    public void setId_empleado(int id_empleado) {
        this.id_empleado = id_empleado;
    }

    public ArrayList<Ticket> getLista_tickets() {
        return lista_tickets;
    }

    public void setLista_tickets(ArrayList<Ticket> lista_tickets) {
        this.lista_tickets = lista_tickets;
    }

    // Metodos del negocio
    public void agregarTicket(Ticket ticket) {
        lista_tickets.add(ticket);
    }

    public int obtenerEstado(int id_ticket) {
        for (Ticket ticket : lista_tickets) {
            if (id_ticket == ticket.getIdTicket()) {
                return ticket.getEstado();
            }
        }
        return -1; // not found
    }
    
    public ArrayList<Ticket> listarTickets(){
        // FALTA
        // Actualiza el atributo lista_ticket y lo llena con los tickets creados por este empleado
        // Estos ya podrian estar en la BD
        // Usa TicketDAO.listar() pero filtra solo aquellos creados por this.id_empleado
        // Los asigna a este empleado y devuelve la lista
        
        return this.lista_tickets;
    }
}