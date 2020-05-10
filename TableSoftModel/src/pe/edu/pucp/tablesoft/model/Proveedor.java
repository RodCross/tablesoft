package pe.edu.pucp.tablesoft.model;

public class Proveedor {
    private int id_proveedor;
    private String nombre;

    public Proveedor(int id_proveedor, String nombre) {
        this.id_proveedor = id_proveedor;
        this.nombre = nombre;
    }

    public int getId_proveedor() {
        return this.id_proveedor;
    }

    public void setId_proveedor(int id_proveedor) {
        this.id_proveedor = id_proveedor;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}