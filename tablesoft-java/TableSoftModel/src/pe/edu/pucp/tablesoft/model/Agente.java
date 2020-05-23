package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Agente extends Usuario {
    private int agenteId;
    private String agenteEmail;
    private ArrayList<Ticket> listaTickets;
    private Equipo equipo;
    
    // Constructores
    public Agente() {
        listaTickets = new ArrayList();
    }

    public Agente(String codigo, String dni, String nombre, String usuarioEmail, String agenteEmail) {
        super(codigo, dni, nombre, usuarioEmail);
        this.agenteEmail = agenteEmail;
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
//    public ArrayList<Ticket> listarTickets() {
//         
//        return this.listaTickets;
//    }
    
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
    
    public String mostrarDatos() {
        return getAgenteId() + " - " + getCodigo() + " - " +
            getDni() + " - " + getNombre() + " - " + getUsuarioEmail();
    }
}