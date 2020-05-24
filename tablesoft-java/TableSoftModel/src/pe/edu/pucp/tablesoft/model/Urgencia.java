package pe.edu.pucp.tablesoft.model;


public class Urgencia {
    private int urgenciaId;
    private String nombre;
    private int plazoMaximo;
    private Boolean activo;

    public Urgencia() {
        
    }

    public Urgencia(String nombre, int plazoMaximo) {
        this.nombre = nombre;
        this.plazoMaximo = plazoMaximo;
    }

    public int getUrgenciaId() {
        return this.urgenciaId;
    }

    public void setUrgenciaId(int id_urgencia) {
        this.urgenciaId = id_urgencia;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getPlazoMaximo() {
        return this.plazoMaximo;
    }

    public void setPlazoMaximo(int plazoMaximo) {
        this.plazoMaximo = plazoMaximo;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
    public String mostrarDatos() {
        return urgenciaId + " - " + nombre + " - " + plazoMaximo;
    }
}