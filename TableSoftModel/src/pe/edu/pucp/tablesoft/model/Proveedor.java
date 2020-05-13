package pe.edu.pucp.tablesoft.model;

public class Proveedor {
    private int proveedorId;
    private String nombre;

    public Proveedor() {
        
    }  
    
    public Proveedor(String nombre) {
        this.nombre = nombre;
    }

    public int getProveedorId() {
        return proveedorId;
    }

    public void setProveedorId(int proveedorId) {
        this.proveedorId = proveedorId;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    public String mostrarDatos() {
        return getProveedorId() + " - " + nombre;
    }
}