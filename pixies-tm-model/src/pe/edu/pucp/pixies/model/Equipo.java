package pe.edu.pucp.pixies.model;

import java.util.ArrayList;

public class Equipo {
    private int id_equipo;
    private ArrayList<Agente> lista_agentes;
    private ArrayList<Categoria> lista_categorias;
    private SupervisorEquipo supervisor;

    public Equipo(int id_equipo) {
        this.id_equipo = id_equipo;
        this.lista_agentes = new ArrayList<Agente>();
        this.lista_categorias = new ArrayList<Categoria>();
    }

    public int getId_equipo() {
        return this.id_equipo;
    }

    public void setId_equipo(int id_equipo) {
        this.id_equipo = id_equipo;
    }

    public SupervisorEquipo getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(SupervisorEquipo supervisor) {
        this.supervisor = supervisor;
    }

    public void agregarAgente(Agente agente) {
        this.lista_agentes.add(agente);
    }

    public void quitarAgente(int id_agente) {
        for (Agente agente : lista_agentes) {
            if (id_agente == agente.getIdAgente()) {
                this.lista_agentes.remove(id_agente);
            }
        }
    }

    public void agregarCategoria(Categoria categoria) {
        this.lista_categorias.add(categoria);
    }

    public void quitarCategoria(int id_categoria) {
        for (Categoria categoria : lista_categorias) {
            if (id_categoria == categoria.getIdCategoria()) {
                this.lista_categorias.remove(id_categoria);
            }
        }
    }
}