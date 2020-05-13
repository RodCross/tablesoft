package pe.edu.pucp.tablesoft.model;

public class Usuario {
    private String codigo;
    private String dni;
    private String nombre;
    private String usuarioEmail;

    public Usuario() {
        
    }

    public Usuario(String codigo, String dni, String nombre, String usuarioEmail) {
        this.codigo = codigo;
        this.dni = dni;
        this.nombre = nombre;
        this.usuarioEmail = usuarioEmail;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUsuarioEmail() {
        return usuarioEmail;
    }

    public void setUsuarioEmail(String usuarioEmail) {
        this.usuarioEmail = usuarioEmail;
    }
}