package pe.edu.pucp.tablesoft.model;

public class Persona {
    private String codigo;
    private String dni;
    private String nombre;
    private String personaEmail;

    public Persona() {
        
    }

    public Persona(String codigo) {
        this.codigo = codigo;
    }

    public Persona(String codigo, String dni, String nombre, String personaEmail) {
        this.codigo = codigo;
        this.dni = dni;
        this.nombre = nombre;
        this.personaEmail = personaEmail;
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

    public String getPersonaEmail() {
        return personaEmail;
    }

    public void setPersonaEmail(String personaEmail) {
        this.personaEmail = personaEmail;
    }
}