package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

public class Ticket {
    private int ticketId;
    private String estado;
    private String infoAdicional;
    private String alumnoEmail;
    private LocalDateTime fechaEnvio;
    private LocalDateTime fechaPrimeraRespuesta;
    private LocalDateTime fechaCierre;
    private int activoFijoId;
    private Empleado empleado;
    private Agente agente;
    private Urgencia urgencia;
    private Proveedor proveedor;
    private Categoria categoria;
    
    public Ticket() {
        
    }
    
    public Ticket(String estado, LocalDateTime fechaEnvio, Urgencia urgencia, Categoria categoria) {
        this.estado = estado;
        this.fechaEnvio = fechaEnvio;
        this.urgencia = urgencia;
        this.categoria = categoria;
        this.activoFijoId = 0;
    }

    public int getTicketId() {
        return ticketId;
    }

    public void setTicketId(int ticketId) {
        this.ticketId = ticketId;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getInfoAdicional() {
        return infoAdicional;
    }

    public void setInfoAdicional(String infoAdicional) {
        this.infoAdicional = infoAdicional;
    }

    public String getAlumnoEmail() {
        return alumnoEmail;
    }

    public void setAlumnoEmail(String alumnoEmail) {
        this.alumnoEmail = alumnoEmail;
    }

    public LocalDateTime getFechaEnvio() {
        return fechaEnvio;
    }

    public void setFechaEnvio(LocalDateTime fechaEnvio) {
        this.fechaEnvio = fechaEnvio;
    }

    public LocalDateTime getFechaPrimeraRespuesta() {
        return fechaPrimeraRespuesta;
    }

    public void setFechaPrimeraRespuesta(LocalDateTime fechaPrimeraRespuesta) {
        this.fechaPrimeraRespuesta = fechaPrimeraRespuesta;
    }

    public LocalDateTime getFechaCierre() {
        return fechaCierre;
    }

    public void setFechaCierre(LocalDateTime fechaCierre) {
        this.fechaCierre = fechaCierre;
    }

    public int getActivoFijoId() {
        return activoFijoId;
    }

    public void setActivoFijoId(int activoFijoId) {
        this.activoFijoId = activoFijoId;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }

    public Agente getAgente() {
        return agente;
    }

    public void setAgente(Agente agente) {
        this.agente = agente;
    }

    public Urgencia getUrgencia() {
        return urgencia;
    }

    public void setUrgencia(Urgencia urgencia) {
        this.urgencia = urgencia;
    }

    public Proveedor getProveedor() {
        return proveedor;
    }

    public void setProveedor(Proveedor proveedor) {
        this.proveedor = proveedor;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    
    public String mostrarDatos() {
        return getTicketId() + " - " + getEstado() + " - " +
            getFechaEnvio() + " - " + getUrgencia().getUrgenciaId() + " - " +
            getCategoria().getCategoriaId();
    }
}