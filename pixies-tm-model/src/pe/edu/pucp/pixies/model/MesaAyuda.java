package pe.edu.pucp.pixies.model;

import java.util.ArrayList;

public class MesaAyuda {
    private ArrayList<Equipo> lista_equipos;
    private SupervisorSistema supervisor;

    public MesaAyuda() {
        this.lista_equipos = new ArrayList<Equipo>();
    }

    public SupervisorSistema getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(SupervisorSistema supervisor) {
        this.supervisor = supervisor;
    }

    public void agregarEquipo(Equipo equipo) {
        this.lista_equipos.add(equipo);
    }
}