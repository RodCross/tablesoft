package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class Equipo {
    private int equipoId;
    private String nombre;
    private String descripcion;
    private LocalDateTime fechaCreacion;
    private Boolean activo;
    
    private ArrayList<Agente> listaAgentes;
    private ArrayList<Categoria> listaCategorias;
    
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

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public LocalDateTime getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(LocalDateTime fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
    public int getEquipoId() {
        return equipoId;
    }

    public void setEquipoId(int equipoId) {
        this.equipoId = equipoId;
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

    public void quitarAgente(Agente ag) {
        for (Agente agente : listaAgentes) {
            if (ag.getAgenteId() == agente.getAgenteId()) {
                this.listaAgentes.remove(agente);
                break;
            }
        }
    }

    public void agregarCategoria(Categoria categoria) {
        this.listaCategorias.add(categoria);
    }

    public void quitarCategoria(int categoriaId) {
        for (Categoria categoria : listaCategorias) {
            if (categoriaId == categoria.getCategoriaId()) {
                this.listaCategorias.remove(categoria);
                break;
            }
        }
    }
    
    public ArrayList<Agente> filtrarAgentexRol(Rol rol){
        ArrayList<Agente> listaFiltrada = new ArrayList<>();
        for(Agente ag : listaAgentes){
            if(ag.getRol().getRolId() == rol.getRolId()){
                listaFiltrada.add(ag);
            }
        }
        return listaFiltrada;
    }
}