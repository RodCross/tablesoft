package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Equipo {
    private int equipoId;
    private ArrayList<Agente> listaAgentes;
    private ArrayList<Categoria> listaCategorias;
    private Supervisor supervisor;
    
    // Constructores
    public Equipo(int equipoId) {
        this.equipoId = equipoId;
        this.listaAgentes = new ArrayList<>();
        this.listaCategorias = new ArrayList<>();
    }
    
    public Equipo() {
        this.listaAgentes = new ArrayList<>();
        this.listaCategorias = new ArrayList<>();
    }
    
    // Getters y setters
    public int getEquipoId() {
        return equipoId;
    }

    public void setEquipoId(int equipoId) {
        this.equipoId = equipoId;
    }

    public Supervisor getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(Supervisor supervisor) {
        this.supervisor = supervisor;
    }

    public ArrayList<Agente> getListaAgentes() {
        return listaAgentes;
    }

    public void setListaAgentes(ArrayList<Agente> listaAgentes) {
        this.listaAgentes = listaAgentes;
    }

    public ArrayList<Categoria> getListaCategorias() {
        return listaCategorias;
    }

    public void setListaCategorias(ArrayList<Categoria> listaCategorias) {
        this.listaCategorias = listaCategorias;
    }
    
    // Metodos del negocio
    public void agregarAgente(Agente agente) {
        this.listaAgentes.add(agente);
    }

    public void quitarAgente(int agenteId) {
        for (Agente agente : listaAgentes) {
            if (agenteId == agente.getAgenteId()) {
                this.listaAgentes.remove(agente);
                break;
            }
        }
    }
    
//    public ArrayList<Agente> listarAgentes() { // es getListaAgentes
//        
//        return this.listaAgentes;
//    }
    
//    public ArrayList<Categoria> listarCategorias() { // es getListaCategorias
//
//        return this.listaCategorias;
//    }

    public void agregarCategoria(Categoria categoria) {
        this.listaCategorias.add(categoria);
    }

    public void quitarCategoria(int categoriaId) {
        for (Categoria categoria : listaCategorias) {
            if (categoriaId == categoria.getCategoriaId()) {
                this.listaCategorias.remove(categoria);
            }
        }
    }

    public void asignarSupervisor(Supervisor supervisor) {
        this.setSupervisor(supervisor);
    }

    public void asignarTicket(int id_agente, Ticket ticket) {
        for (Agente agente : listaAgentes) {
            if (id_agente == agente.getAgenteId()) {
                agente.agregarTicket(ticket);
            }
        }
    }
}