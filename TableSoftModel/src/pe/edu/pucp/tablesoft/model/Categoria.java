package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Categoria {
    private int id_categoria;
    private String nombre;
    private ArrayList<Ticket> tickets;
    
    public Categoria(int id_categoria, String nombre) {
        this.id_categoria = id_categoria;
        this.nombre = nombre;
        tickets = new ArrayList<>();
    }
    
    public Categoria(){
        tickets = new ArrayList<>();
    }

    public int getIdCategoria() {
        return this.id_categoria;
    }

    public void setIdCategoria(int id_categoria) {
        this.id_categoria = id_categoria;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}