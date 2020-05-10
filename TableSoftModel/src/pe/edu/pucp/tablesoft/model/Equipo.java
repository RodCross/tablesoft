package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Equipo {
    private int id_equipo;
    private ArrayList<Agente> lista_agentes;
    private ArrayList<Categoria> lista_categorias;
    private Supervisor supervisor;
    
    // Constructores
    public Equipo(int id_equipo) {
        this.id_equipo = id_equipo;
        this.lista_agentes = new ArrayList<>();
        this.lista_categorias = new ArrayList<>();
    }
    
    public Equipo(){
        this.lista_agentes = new ArrayList<>();
        this.lista_categorias = new ArrayList<>();
    }
    
    // Getter y setter
    public int getId_equipo() {
        return this.id_equipo;
    }

    public void setId_equipo(int id_equipo) {
        this.id_equipo = id_equipo;
    }

    public Supervisor getSupervisor() {
        return this.supervisor;
    }

    public void setSupervisor(Supervisor supervisor) {
        this.supervisor = supervisor;
    }

    public ArrayList<Agente> getLista_agentes() {
        return lista_agentes;
    }

    public void setLista_agentes(ArrayList<Agente> lista_agentes) {
        this.lista_agentes = lista_agentes;
    }

    public ArrayList<Categoria> getLista_categorias() {
        return lista_categorias;
    }

    public void setLista_categorias(ArrayList<Categoria> lista_categorias) {
        this.lista_categorias = lista_categorias;
    }
    
    // Metodos del negocio
    public void agregarAgente(Agente agente) {
        this.lista_agentes.add(agente);
    }

    public void quitarAgente(int id_agente) {
        int i;
        i = 0;
        for (Agente agente : lista_agentes) {
            if (id_agente == agente.getId_agente()) {
                this.lista_agentes.remove(i);
            }
            i++;
        }
    }
    
    public ArrayList<Agente> listarAgentes(){
        // FALTA
        // Actualiza el atributo lista_agentes y lo llena con 
        // los agentes registrados en este equipo en la BD
        // Usa AgenteDAO.listar() pero filtra solo aquellos que pertenecen a this.id_equipo
        // Los asigna a este empleado y devuelve la lista
        
        return this.lista_agentes;
    }
    
    public ArrayList<Categoria> listarCategorias(){
        // FALTA
        // Saca los datos de la BD y actualiza el atributo correspondiente
        
        return this.lista_categorias;
    }

    public void agregarCategoria(Categoria categoria) {
        this.lista_categorias.add(categoria);
    }

    public void quitarCategoria(int id_categoria) {
        int i;
        i = 0;
        for (Categoria categoria : lista_categorias) {
            if (id_categoria == categoria.getIdCategoria()) {
                this.lista_categorias.remove(i);
            }
            i++;
        }
    }

    public void asignarSupervisor(Supervisor supervisor) {
        this.setSupervisor(supervisor);
    }

    public void asignarTicket(int id_agente, Ticket ticket) {
        for (Agente agente : lista_agentes) {
            if (id_agente == agente.getId_agente()) {
                agente.agregarTicket(ticket);
            }
        }
    }
}