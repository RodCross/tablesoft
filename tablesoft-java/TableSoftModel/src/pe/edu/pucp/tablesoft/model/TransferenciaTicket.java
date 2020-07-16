package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

/*
 * @author migue
 */
public class TransferenciaTicket {
    private int transferenciaId;
    private LocalDateTime fecha;
    private String comentario;
    private Agente agenteResponsable;

    public TransferenciaTicket() {
        agenteResponsable = new Agente();
    }

    public TransferenciaTicket(Agente agenteResponsable) {
        this.agenteResponsable = agenteResponsable;
    }

    public Agente getAgenteResponsable() {
        return agenteResponsable;
    }

    public void setAgenteResponsable(Agente agenteResponsable) {
        this.agenteResponsable = agenteResponsable;
    }

    public int getTransferenciaId() {
        return transferenciaId;
    }

    public void setTransferenciaId(int transferenciaId) {
        this.transferenciaId = transferenciaId;
    }

    public LocalDateTime getFecha() {
        return fecha;
    }

    public void setFecha(LocalDateTime fecha) {
        this.fecha = fecha;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }
    
}
