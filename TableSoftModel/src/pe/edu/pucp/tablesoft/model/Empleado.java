package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Empleado extends Usuario {
    private int id_usuario_sist_bibl;
    private ArrayList<Ticket> lista_tickets;

    public Empleado(int codigo_pucp, int dni, String nombre) {
        super(codigo_pucp, dni, nombre);
        this.lista_tickets = new ArrayList<>();
    }

    public Empleado(int codigo_pucp, int dni, String nombre, String correo_electronico) {
        super(codigo_pucp, dni, nombre, correo_electronico);
        this.lista_tickets = new ArrayList<>();
    }

    public int getIdUsuarioSistBibl() {
        return this.id_usuario_sist_bibl;
    }

    public void setIdUsuarioSistBibl(int id_usuario_sist_bibl) {
        this.id_usuario_sist_bibl = id_usuario_sist_bibl;
    }

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
}