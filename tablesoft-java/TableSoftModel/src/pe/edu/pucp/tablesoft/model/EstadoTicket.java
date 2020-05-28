package pe.edu.pucp.tablesoft.model;


public class EstadoTicket {
    private int estadoId;
    private String nombre;
    private String descripcion;
    private Boolean activo;
    
    public EstadoTicket(){
        
    }

    public EstadoTicket(String nombre, String descripcion) {
        this.nombre = nombre;
        this.descripcion = descripcion;
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
    public String mostrarDatos(){
        return this.getEstadoId() + " - " + this.getNombre() + " - " + this.getDescripcion();
    }
}
