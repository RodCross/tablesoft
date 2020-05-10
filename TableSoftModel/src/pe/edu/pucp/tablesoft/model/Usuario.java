package pe.edu.pucp.tablesoft.model;

public class Usuario {
    private int codigo_pucp;
    private int dni;
    private String nombre;
    private String correo_electronico;

    public Usuario(int codigo_pucp, int dni, String nombre) {
        this.codigo_pucp = codigo_pucp;
        this.dni = dni;
        this.nombre = nombre;
    }

    public Usuario(int codigo_pucp, int dni, String nombre, String correo_electronico) {
        this.codigo_pucp = codigo_pucp;
        this.dni = dni;
        this.nombre = nombre;
        this.correo_electronico = correo_electronico;
    }

    public Usuario(){
        
    }
    
    public int getCodigoPucp() {
        return this.codigo_pucp;
    }

    public void setCodigoPucp(int codigo_pucp) {
        this.codigo_pucp = codigo_pucp;
    }

    public int getDni() {
        return this.dni;
    }

    public void setDni(int dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCorreoElectronico() {
        return this.correo_electronico;
    }

    public void setCorreoElectronico(String correo_electronico) {
        this.correo_electronico = correo_electronico;
    }
}