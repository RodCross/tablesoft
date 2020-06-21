package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;



public class Tarea {
    private int tareaId;
    private String descripcion;
    private Agente agente;
    private LocalDateTime fechaCreacion;
    private LocalDateTime fechaCompletado;
    private Boolean completado;

    public Tarea() {
        agente = new Agente();
    }

    public Tarea(String descripcion, Agente agente) {
        this.descripcion = descripcion;
        this.agente = agente;
        this.completado = false;
    }

    public LocalDateTime getFechaCompletado() {
        return fechaCompletado;
    }

    public void setFechaCompletado(LocalDateTime fechaCompletado) {
        this.fechaCompletado = fechaCompletado;
    }

    public Boolean getCompletado() {
        return completado;
    }

    public void setCompletado(Boolean completado) {
        this.completado = completado;
    }

    public LocalDateTime getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(LocalDateTime fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Agente getAgente() {
        return agente;
    }

    public void setAgente(Agente agente) {
        this.agente = agente;
    }

    public int getTareaId() {
        return tareaId;
    }

    public void setTareaId(int tareaId) {
        this.tareaId = tareaId;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
}
