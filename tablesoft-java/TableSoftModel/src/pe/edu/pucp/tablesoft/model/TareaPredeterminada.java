package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;


public class TareaPredeterminada {
    private int tareaPredeterminadaId;
    private LocalDateTime fechaCreacion;
    private String descripcion;
    private Boolean activo;

    public TareaPredeterminada() {
    }

    public TareaPredeterminada(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getTareaPredeterminadaId() {
        return tareaPredeterminadaId;
    }

    public void setTareaPredeterminadaId(int tareaPredeterminadaId) {
        this.tareaPredeterminadaId = tareaPredeterminadaId;
    }

    public LocalDateTime getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(LocalDateTime fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    
}
