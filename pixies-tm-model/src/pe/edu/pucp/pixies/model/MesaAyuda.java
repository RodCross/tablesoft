package pe.edu.pucp.pixies.model;

import java.util.ArrayList;

public class MesaAyuda {
    private ArrayList<Ticket> lista_tickets;
    private ArrayList<Equipo> lista_equipos;
    private SupervisorSistema supervisor;

    public MesaAyuda() {
        this.lista_tickets = new ArrayList<Ticket>();
        this.lista_equipos = new ArrayList<Equipo>();
    }

    public SupervisorSistema getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(SupervisorSistema supervisor) {
        this.supervisor = supervisor;
    }

    public void agregarCategoria(Ticket ticket) {
        this.lista_tickets.add(ticket);
    }

    public void agregarAgente(Equipo equipo) {
        this.lista_equipos.add(equipo);
    }
}