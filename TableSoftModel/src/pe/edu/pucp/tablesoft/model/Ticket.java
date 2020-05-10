package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

public class Ticket {
    private int id_ticket;
    private Urgencia urgencia;
    private Categoria categoria;
    private Proveedor proveedor;
    private int estado;
    private String info_adicional;
    private int id_activo_fijo;
    private LocalDateTime fecha_envio;
    private LocalDateTime fecha_primera_respuesta;
    private LocalDateTime fecha_cierre;

    private Usuario creador;
    private Agente agente;
    
    // Ticket no se inicializa con un id_proveedor
    public Ticket(int id_ticket, Categoria categoria, Urgencia urgencia, int estado, String info_adicional,
            int id_activo_fijo, LocalDateTime fecha_envio, LocalDateTime fecha_primera_respuesta,
            LocalDateTime fecha_cierre) {
        this.id_ticket = id_ticket;
        this.categoria = categoria;
        this.urgencia = urgencia;
        this.estado = estado;
        this.info_adicional = info_adicional;
        this.id_activo_fijo = id_activo_fijo;
        this.fecha_envio = fecha_envio;
        this.fecha_primera_respuesta = fecha_primera_respuesta;
        this.fecha_cierre = fecha_cierre;
    }
    public Ticket(){
        
    }
    
    public int getIdTicket() {
        return this.id_ticket;
    }

    public void setIdTicket(int id_ticket) {
        this.id_ticket = id_ticket;
    }

    public Urgencia getUrgencia() {
        return urgencia;
    }

    public void setUrgencia(Urgencia urgencia) {
        this.urgencia = urgencia;
    }

    public Categoria getCategoria() {
        return categoria;
    }
    
    public void setCategoria(Categoria categoria) { // Reasignar categoria
        this.categoria = categoria;
    }

    public Proveedor getProveedor() {
        return proveedor;
    }
    
    public void setProveedor(Proveedor proveedor) { // Escalar
        this.proveedor = proveedor;
    }

    public int getEstado() {
        return this.estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public String getInfoAdicional() {
        return this.info_adicional;
    }

    public void setInfoAdicional(String info_adicional) {
        this.info_adicional = info_adicional;
    }

    public int getIdActivoFijo() {
        return this.id_activo_fijo;
    }

    public void setIdActivoFijo(int id_activo_fijo) {
        this.id_activo_fijo = id_activo_fijo;
    }

    public LocalDateTime getFechaEnvio() {
        return this.fecha_envio;
    }

    public void setFechaEnvio(LocalDateTime fecha_envio) {
        this.fecha_envio = fecha_envio;
    }

    public LocalDateTime getFechaPrimeraRespuesta() {
        return this.fecha_primera_respuesta;
    }

    public void setFechaPrimeraRespuesta(LocalDateTime fecha_primera_respuesta) {
        this.fecha_primera_respuesta = fecha_primera_respuesta;
    }

    public LocalDateTime getFechaCierre() {
        return this.fecha_cierre;
    }

    public void setFechaCierre(LocalDateTime fecha_cierre) {
        this.fecha_cierre = fecha_cierre;
    }
}