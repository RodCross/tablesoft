package pe.edu.pucp.pixies.model;

public class Categoria {
    private int id_categoria;
    private String nombre;

    public Categoria(int id_categoria, String nombre) {
        this.id_categoria = id_categoria;
        this.nombre = nombre;
    }

    public int getId_categoria() {
        return this.id_categoria;
    }

    public void setId_categoria(int id_categoria) {
        this.id_categoria = id_categoria;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}