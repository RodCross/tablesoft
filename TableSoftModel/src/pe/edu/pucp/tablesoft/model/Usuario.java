package pe.edu.pucp.tablesoft.model;

public class Usuario {
    private String codigoPUCP;
    private String dni;
    private String nombre;
    private String emailUsuario;

    public Usuario(String codigo_pucp, String dni, String nombre) {
        this.codigoPUCP = codigo_pucp;
        this.dni = dni;
        this.nombre = nombre;
    }

    public Usuario(String codigo_pucp, String dni, String nombre, String correo_electronico) {
        this.codigoPUCP = codigo_pucp;
        this.dni = dni;
        this.nombre = nombre;
        this.emailUsuario = correo_electronico;
    }

    public Usuario(){
        
    }
    
    public String getCodigoPucp() {
        return this.codigoPUCP;
    }

    public void setCodigoPucp(String codigo_pucp) {
        this.codigoPUCP = codigo_pucp;
    }

    public String getDni() {
        return this.dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCorreoElectronico() {
        return this.emailUsuario;
    }

    public void setCorreoElectronico(String correo_electronico) {
        this.emailUsuario = correo_electronico;
    }
}