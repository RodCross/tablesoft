package pe.edu.pucp.tablesoft.model;


public class EstadoTarea {
    private int estadoId;
    private String nombre;
    private String descripcion;
    private Boolean activo;

    public EstadoTarea() {
    }
    public EstadoTarea(int id){
        this.estadoId = id;
    }

    public int getEstadoId() {
        return estadoId;
    }

    public void setEstadoId(int estadoId) {
        this.estadoId = estadoId;
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
