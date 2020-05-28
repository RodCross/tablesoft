package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

/*
 * @author migue
 */
public class Comentario {
    private int comentarioId;
    private Persona autor;
    private LocalDateTime fecha;
    private String texto;

    public Comentario() {
        autor = new Persona();
    }

    public Comentario(Persona autor, String texto) {
        this.autor = autor;
        this.texto = texto;
    }
    public Comentario(Agente agente, String texto){
        this.autor = (Persona)agente;
        this.texto = texto;
    }
    public Comentario(Empleado empleado, String texto){
        this.autor = (Persona)empleado;
        this.texto = texto;
    }

    public int getComentarioId() {
        return comentarioId;
    }

    public void setComentarioId(int comentarioId) {
        this.comentarioId = comentarioId;
    }

    public Persona getAutor() {
        return autor;
    }

    public void setAutor(Persona autor) {
        this.autor = autor;
    }

    public LocalDateTime getFecha() {
        return fecha;
    }

    public void setFecha(LocalDateTime fecha) {
        this.fecha = fecha;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }
    public String mostrarDatos(){
        return this.getComentarioId() + " - " + this.getAutor().getCodigo() + " - " + this.getTexto();
    }
}
