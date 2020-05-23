package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Categoria {
    private int categoriaId;
    private String nombre;
    private ArrayList<Ticket> tickets;
    private Equipo equipo;
    
    public Categoria() {
        tickets = new ArrayList<>();
    }
    
    public Categoria(int categoriaId, String nombre, Equipo equipo) {
        this.categoriaId = categoriaId;
        this.nombre = nombre;
        tickets = new ArrayList<>();
        this.equipo = equipo;
    }
    
    public Categoria(String nombre) {
        this.nombre = nombre;
        tickets = new ArrayList<>();
    }

    public Equipo getEquipo() {
        return equipo;
    }

    public void setEquipo(Equipo equipo) {
        this.equipo = equipo;
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
    
    public String mostrarDatos() {
        return getCategoriaId() + " - " + getNombre();
    }
}