package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

public class Ticket {
    private int id_ticket;
    private int id_categoria;
    private int id_urgencia;
    private int id_proveedor;
    private int estado;
    private String info_adicional;
    private int id_activo_fijo;
    private LocalDateTime fecha_envio;
    private LocalDateTime fecha_primera_respuesta;
    private LocalDateTime fecha_cierre;

    // Ticket no se inicializa con un id_proveedor
    public Ticket(int id_ticket, int id_categoria, int id_urgencia, int estado, String info_adicional,
            int id_activo_fijo, LocalDateTime fecha_envio, LocalDateTime fecha_primera_respuesta,
            LocalDateTime fecha_cierre) {
        this.id_ticket = id_ticket;
        this.id_categoria = id_categoria;
        this.id_urgencia = id_urgencia;
        this.estado = estado;
        this.info_adicional = info_adicional;
        this.id_activo_fijo = id_activo_fijo;
        this.fecha_envio = fecha_envio;
        this.fecha_primera_respuesta = fecha_primera_respuesta;
        this.fecha_cierre = fecha_cierre;
    }

    public int getIdTicket() {
        return this.id_ticket;
    }

    public void setIdTicket(int id_ticket) {
        this.id_ticket = id_ticket;
    }

    public int getIdCategoria() {
        return this.id_categoria;
    }

    public void setIdCategoria(int id_categoria) {
        this.id_categoria = id_categoria;
    }

    public int getIdUrgencia() {
        return this.id_urgencia;
    }

    public void setIdUrgencia(int id_urgencia) {
        this.id_urgencia = id_urgencia;
    }

    public int getIdProveedor() {
        return this.id_proveedor;
    }

    public void setIdProveedor(int id_proveedor) {
        this.id_proveedor = id_proveedor;
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

    public void reasignarCategoria(int id_categoria) {
        this.setIdCategoria(id_categoria);
    }

    public void escalar(int id_proveedor) {
        this.setIdProveedor(id_proveedor);
    }
}