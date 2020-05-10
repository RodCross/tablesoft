package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class MesaAyuda {
    private ArrayList<Equipo> lista_equipos;
    private Administrador supervisor;

    public MesaAyuda() {
        this.lista_equipos = new ArrayList<Equipo>();
    }

    public Administrador getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(Administrador supervisor) {
        this.supervisor = supervisor;
    }

    public void agregarEquipo(Equipo equipo) {
        this.lista_equipos.add(equipo);
    }

    public void agregarSupervisor(Administrador supervisor) {
        this.setSupervisor(supervisor);
    }
}