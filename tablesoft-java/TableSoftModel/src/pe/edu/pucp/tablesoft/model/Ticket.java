package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class Ticket {
    private int ticketId;
    private EstadoTicket estado;
    
    private LocalDateTime fechaEnvio;
    private LocalDateTime fechaPrimeraRespuesta;
    private LocalDateTime fechaCierre;
    
    private Empleado empleado;
    private Agente agente;
    
    private ActivoFijo activoFijo;
    private Proveedor proveedor;    // Solo se llena cuando el ticket ha tenido un escalado externo
    private Urgencia urgencia;
    private Categoria categoria;
    private Biblioteca biblioteca;
    
    private String infoAdicional;
    private String alumnoEmail;

    private ArrayList<Tarea> listaTareas;
    private ArrayList<CambioEstadoTicket> historialEstado;
    private ArrayList<TransferenciaTicket> historialTransferencia;
    private ArrayList<Comentario> comentarios;
    
    public Ticket() {
        listaTareas = new ArrayList<>();
        historialEstado = new ArrayList<>();
        historialTransferencia = new ArrayList();
        comentarios = new ArrayList();
        
        estado = new EstadoTicket();
        urgencia = new Urgencia();
        categoria = new Categoria();
        biblioteca = new Biblioteca();
        proveedor = new Proveedor();
        activoFijo = new ActivoFijo();
        
        empleado = new Empleado();
        agente = new Agente();
    }

    public ArrayList<Comentario> getComentarios() {
        return comentarios;
    }

    public void setComentarios(ArrayList<Comentario> comentarios) {
        this.comentarios = comentarios;
    }

    public ArrayList<TransferenciaTicket> getHistorialTransferencia() {
        return historialTransferencia;
    }

    public void setHistorialTransferencia(ArrayList<TransferenciaTicket> historialTransferencia) {
        this.historialTransferencia = historialTransferencia;
    }

    public EstadoTicket getEstado() {
        return estado;
    }

    public void setEstado(EstadoTicket estado) {
        this.estado = estado;
    }

    public ActivoFijo getActivoFijo() {
        return activoFijo;
    }

    public void setActivoFijo(ActivoFijo activoFijo) {
        this.activoFijo = activoFijo;
    }

    public Biblioteca getBiblioteca() {
        return biblioteca;
    }

    public void setBiblioteca(Biblioteca biblioteca) {
        this.biblioteca = biblioteca;
    }

    public ArrayList<Tarea> getListaTareas() {
        return listaTareas;
    }

    public void setListaTareas(ArrayList<Tarea> listaTareas) {
        this.listaTareas = listaTareas;
    }

    public ArrayList<CambioEstadoTicket> getHistorialEstado() {
        return historialEstado;
    }

    public void setHistorialEstado(ArrayList<CambioEstadoTicket> historialEstado) {
        this.historialEstado = historialEstado;
    }

    public int getTicketId() {
        return ticketId;
    }

    public void setTicketId(int ticketId) {
        this.ticketId = ticketId;
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

    private void setProveedor(Proveedor proveedor) {
        this.proveedor = proveedor;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    
    // Metodos del negocio
    
    // AQUI IMPLEMENTAR LOS INDICADORES DE CALIDAD DE CADA TICKET
    
    public void actualizarEstado(EstadoTicket estado, String comentario){
        this.setEstado(estado);
        CambioEstadoTicket cambio = new CambioEstadoTicket(estado, getAgente() );
        cambio.setComentario(comentario);
        cambio.setFechaCambioEstado(LocalDateTime.now());
        historialEstado.add(cambio);
    }
    
    public void escalar(Proveedor proveedor, String comentario){
        this.setProveedor(proveedor);
        TransferenciaExterna escalado = new TransferenciaExterna(proveedor, getAgente());
        escalado.setComentario(comentario);
        escalado.setFecha(LocalDateTime.now());
        this.historialTransferencia.add(escalado);
    }
    
    public void agregarTarea(Tarea tarea){
        this.listaTareas.add(tarea);
    }
    
    public void cambiarCategoria(Categoria categoria, String comentario){
        this.setCategoria(categoria);
        TransferenciaInterna cambioCategoria = new TransferenciaInterna(categoria, getAgente());
        cambioCategoria.setFecha(LocalDateTime.now());
        cambioCategoria.setComentario(comentario);
        this.setAgente(new Agente());
        this.historialTransferencia.add(cambioCategoria);
    }
    
    public void mandarComentario(String comentario, Persona autor){
        Comentario com = new Comentario();
        com.setTexto(comentario);
        com.setFecha(LocalDateTime.now());
        com.setAutor(autor);
        this.comentarios.add(com);
    }
    
    public String mostrarDatos() {
        return "";
    }
}