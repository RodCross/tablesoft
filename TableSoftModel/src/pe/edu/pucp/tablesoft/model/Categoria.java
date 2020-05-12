package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Categoria {
    private int categoriaId;
    private String nombre;
    private ArrayList<Ticket> tickets;
    private Equipo equipo;
    
    public Categoria(int id_categoria, String nombre) {
        this.categoriaId = id_categoria;
        this.nombre = nombre;
        tickets = new ArrayList<>();
    }
    
    public Categoria(){
        tickets = new ArrayList<>();
    }

    public Equipo getEquipo() {
        return equipo;
    }

    public void setEquipo(Equipo equipo) {
        this.equipo = equipo;
    }
    
    
    public int getIdCategoria() {
        return this.categoriaId;
    }

    public void setIdCategoria(int id_categoria) {
        this.categoriaId = id_categoria;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}