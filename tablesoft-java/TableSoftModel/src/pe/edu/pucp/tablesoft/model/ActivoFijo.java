package pe.edu.pucp.tablesoft.model;


public class ActivoFijo {
    private int activoFijoId;
    private String nombre;
    private String codigo;
    private String marca;
    private String tipo;
    private Boolean activo;
    
    public ActivoFijo(){
    }

    public ActivoFijo(String nombre, String codigo, String tipo, String marca) {
        this.nombre = nombre;
        this.codigo = codigo;
        this.tipo = tipo;
        this.marca = marca;
    }

    public int getActivoFijoId() {
        return activoFijoId;
    }

    public void setActivoFijoId(int activoFijoId) {
        this.activoFijoId = activoFijoId;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
    public String mostrarDatos(){
        return this.activoFijoId + " - " + this.getNombre() + " - " + this.getCodigo();
    }
}
