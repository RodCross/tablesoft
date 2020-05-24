package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

/*
 * @author migue
 */

public class EventoEstadoTicket {
    private int eventoEstadoTicketId;
    private LocalDateTime fechaCambioEstado;
    private String comentario;
    private Agente agenteResponsable;
    private EstadoTicket estadoTo;

    // Si o si debe tener un agente responsable
    // pero que entra como una referencia
    public EventoEstadoTicket(Agente agenteResponsable) {
        this.agenteResponsable = agenteResponsable;
    }

    public EstadoTicket getEstadoTo() {
        return estadoTo;
    }

    public void setEstadoTo(EstadoTicket estadoTo) {
        this.estadoTo = estadoTo;
    }

    public int getEventoEstadoTicketId() {
        return eventoEstadoTicketId;
    }

    public void setEventoEstadoTicketId(int eventoEstadoTicketId) {
        this.eventoEstadoTicketId = eventoEstadoTicketId;
    }

    public LocalDateTime getFechaCambioEstado() {
        return fechaCambioEstado;
    }

    public void setFechaCambioEstado(LocalDateTime fechaCambioEstado) {
        this.fechaCambioEstado = fechaCambioEstado;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }

    public Agente getAgenteResponsable() {
        return agenteResponsable;
    }

    public void setAgenteResponsable(Agente agenteResponsable) {
        this.agenteResponsable = agenteResponsable;
    }
    
}
