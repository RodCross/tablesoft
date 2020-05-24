package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;


public class Categoria {
    private int categoriaId;
    private String nombre;
    private String descripcion;
    private Boolean activo;
    
    private ArrayList<TareaPredeterminada> tareasPredeterminadas;
    
    public Categoria() {
        tareasPredeterminadas = new ArrayList<>();
    }
    
    public Categoria(int categoriaId, String nombre) {
        this.categoriaId = categoriaId;
        this.nombre = nombre;
        tareasPredeterminadas = new ArrayList<>();
    }
    
    public Categoria(String nombre) {
        this.nombre = nombre;  
        tareasPredeterminadas = new ArrayList<>();
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }

    public ArrayList<TareaPredeterminada> getTareasPredeterminadas() {
        return tareasPredeterminadas;
    }

    public void setTareasPredeterminadas(ArrayList<TareaPredeterminada> tareasPredeterminadas) {
        this.tareasPredeterminadas = tareasPredeterminadas;
    }
    
    public int getCategoriaId() {
        return this.categoriaId;
    }

    public void setCategoriaId(int categoriaId) {
        this.categoriaId = categoriaId;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    // Metodos del negocio
    
    public void agregarTareaPredeterminada(TareaPredeterminada tarea){
        this.tareasPredeterminadas.add(tarea);
    }
    
    public String mostrarDatos() {
        return getCategoriaId() + " - " + getNombre();
    }
}