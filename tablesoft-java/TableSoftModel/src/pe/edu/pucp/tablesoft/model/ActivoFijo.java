package pe.edu.pucp.tablesoft.model;


public class ActivoFijo {
    private int activoFijoId;
    private String nombre;
    private String descripcion;
    private Boolean activo;
    
    public ActivoFijo(){
    }

    public int getActivoFijoId() {
        return activoFijoId;
    }

    public void setActivoFijoId(int activoFijoId) {
        this.activoFijoId = activoFijoId;
    }

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

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
}
