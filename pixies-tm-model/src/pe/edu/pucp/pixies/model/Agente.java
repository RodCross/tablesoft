package pe.edu.pucp.pixies.model;

import java.util.ArrayList;

public class Agente extends UsuarioPUCP {
    private int id_agente;
    private String correo_agente;
    private ArrayList<Ticket> lista_tickets;

    public Agente(int codigo_pucp, int dni, String nombre) {
        super(codigo_pucp, dni, nombre);
        lista_tickets = new ArrayList<>();
    }

    public Agente(int codigo_pucp, int dni, String nombre, String correo_agente) {
        super(codigo_pucp, dni, nombre);
        this.correo_agente = correo_agente;
        lista_tickets = new ArrayList<>();
    }

    public int getIdAgente() {
        return this.id_agente;
    }

    public void setIdAgente(int id_agente) {
        this.id_agente = id_agente;
    }

    public String getCorreoAgente() {
        return this.correo_agente;
    }

    public void setCorreoAgente(String correo_agente) {
        this.correo_agente = correo_agente;
    }

    public void agregarTicket(Ticket ticket) {
        lista_tickets.add(ticket);
    }
}