package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Agente extends Usuario {
    private int id_agente;
    private String correo_agente;
    private ArrayList<Ticket> lista_tickets;
    private Equipo equipo;

    public int getId_agente() {
        return id_agente;
    }

    public void setId_agente(int id_agente) {
        this.id_agente = id_agente;
    }

    public Equipo getEquipo() {
        return equipo;
    }

    public void setEquipo(Equipo equipo) {
        this.equipo = equipo;
    }

    public String getCorreo_agente() {
        return correo_agente;
    }

    public void setCorreo_agente(String correo_agente) {
        this.correo_agente = correo_agente;
    }
    
    public Agente(){
        lista_tickets = new ArrayList();
    }

    public Agente(int codigo_pucp, int dni, String nombre) {
        super(codigo_pucp, dni, nombre);
        lista_tickets = new ArrayList<>();
    }

    public Agente(int codigo_pucp, int dni, String nombre, String correo_agente) {
        super(codigo_pucp, dni, nombre);
        this.correo_agente = correo_agente;
        lista_tickets = new ArrayList<>();
    }

    public void agregarTicket(Ticket ticket) {
        lista_tickets.add(ticket);
    }

    public void reasignarCategoria(int id_ticket, Categoria categoria) {
        for (Ticket ticket : lista_tickets) {
            if (id_ticket == ticket.getIdTicket()) {
                ticket.setCategoria(categoria);
            }
        }
    }

    public void escalarTicket(int id_ticket, Proveedor proveedor) {
        for (Ticket ticket : lista_tickets) {
            if (id_ticket == ticket.getIdTicket()) {
                ticket.setProveedor(proveedor);
            }
        }
    }
}