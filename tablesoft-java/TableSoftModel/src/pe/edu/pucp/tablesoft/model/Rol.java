package pe.edu.pucp.tablesoft.model;

/*
 * @author migue
 */
public class Rol {
    private int rolId;
    private String nombre;
    private String descripcion;
    private boolean activo;

    public Rol(String nombre, String descripcion) {
        this.nombre = nombre;
        this.descripcion = descripcion;
    }

    public Rol() {
    }

    public int getRolId() {
        return rolId;
    }

    public void setRolId(int rolId) {
        this.rolId = rolId;
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

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public String mostrarDatos(){
        return this.getRolId() + " - "+ this.getNombre() + " - " + this.getDescripcion();
    }
}
