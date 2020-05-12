package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Agente extends Usuario {
    private int agenteId;
    private String agenteEmail;
    private ArrayList<Ticket> listaTickets;
    private Equipo equipo;
    
    // Constructores
    public Agente(){
            listaTickets = new ArrayList();
        }

    public Agente(String codigo_pucp, String dni, String nombre) {
        super(codigo_pucp, dni, nombre);
        listaTickets = new ArrayList<>();
    }

    public Agente(String codigo_pucp, String dni, String nombre, String correo_agente) {
        super(codigo_pucp, dni, nombre);
        this.agenteEmail = correo_agente;
        listaTickets = new ArrayList<>();
    }
    
    // Getter y setter
    public int getAgenteId() {
        return agenteId;
    }

    public void setAgenteId(int agenteId) {
        this.agenteId = agenteId;
    }

    public Equipo getEquipo() {
        return equipo;
    }

    public void setEquipo(Equipo equipo) {
        this.equipo = equipo;
    }

    public String getAgenteEmail() {
        return agenteEmail;
    }

    public void setAgenteEmail(String agenteEmail) {
        this.agenteEmail = agenteEmail;
    }

    public ArrayList<Ticket> getListaTickets() {
        return listaTickets;
    }

    public void setListaTickets(ArrayList<Ticket> listaTickets) {
        this.listaTickets = listaTickets;
    }
    
    
    // Metodos del negocio
    public ArrayList<Ticket> listarTickets(){
        // FALTA
        // Actualiza el atributo lista_ticket y lo llena con los tickets asignados a este agente
        // Estos estan en la BD
        // Usa TicketDAO.listar() pero filtra solo aquellos asignaods a este agente
        // Los asigna a este objeto y devuelve la lista
        
        return this.listaTickets;
    }
    
    public void agregarTicket(Ticket ticket) {
        listaTickets.add(ticket);
    }

    public void reasignarCategoria(int id_ticket, Categoria categoria) {
        for (Ticket ticket : listaTickets) {
            if (id_ticket == ticket.getTicketId()) {
                ticket.setCategoria(categoria);
            }
        }
    }

    public void escalarTicket(int id_ticket, Proveedor proveedor) {
        for (Ticket ticket : listaTickets) {
            if (id_ticket == ticket.getTicketId()) {
                ticket.setProveedor(proveedor);
            }
        }
    }
}