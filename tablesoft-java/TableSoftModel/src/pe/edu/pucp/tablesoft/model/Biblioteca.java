package pe.edu.pucp.tablesoft.model;

/*
 * @author migue
 */
public class Biblioteca {
    private int bibliotecaId;
    private String nombre;
    private String abreviatura;
    private Boolean activo;

    public Biblioteca() {
    }

    public Biblioteca(String nombre, String abreviatura) {
        this.nombre = nombre;
        this.abreviatura = abreviatura;
    }
    

    public int getBibliotecaId() {
        return bibliotecaId;
    }

    public void setBibliotecaId(int bibliotecaId) {
        this.bibliotecaId = bibliotecaId;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getAbreviatura() {
        return abreviatura;
    }

    public void setAbreviatura(String abreviatura) {
        this.abreviatura = abreviatura;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
    public String mostrarDatos(){
        return this.getBibliotecaId() + " - " + this.getAbreviatura() + " - " + this.getNombre();
    }
    
}
