package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class Ticket {
    private int ticketId;
    
    private String asunto;
    private String descripcion;
    private EstadoTicket estado;
    private Boolean retrasado;
    
    private LocalDateTime fechaEnvio;
    private LocalDateTime fechaCierreMaximo;
    private LocalDateTime fechaCierre;
    
    private Empleado empleado;
    private Agente agente;
    
    private Urgencia urgencia;
    private Categoria categoria;
    private Biblioteca biblioteca;
    
    private ActivoFijo activoFijo;  // Opcional
    private Proveedor proveedor;    // Solo se llena cuando el ticket ha tenido un escalado externo
    
    private String alumnoEmail;     // Opcional

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

    public Ticket(String asunto, String descripcion,EstadoTicket estado, Empleado empleado, Urgencia urgencia, Categoria categoria, Biblioteca biblioteca) {
        this.estado = estado;
        this.empleado = empleado;
        this.urgencia = urgencia;
        this.categoria = categoria;
        this.biblioteca = biblioteca;
        this.asunto = asunto;
        this.descripcion = descripcion;
        
        listaTareas = new ArrayList<>();
        historialEstado = new ArrayList<>();
        historialTransferencia = new ArrayList();
        comentarios = new ArrayList();
        
        this.proveedor = new Proveedor();
        this.activoFijo = new ActivoFijo();
    }

    public Boolean getRetrasado() {
        return retrasado;
    }

    public void setRetrasado(Boolean retrasado) {
        this.retrasado = retrasado;
    }
    
    
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
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

    public String getAsunto() {
        return asunto;
    }

    public void setAsunto(String asunto) {
        this.asunto = asunto;
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

    public LocalDateTime getFechaCierreMaximo() {
        return fechaCierreMaximo;
    }

    public void setFechaCierreMaximo(LocalDateTime fechaCierreMaximo) {
        this.fechaCierreMaximo = fechaCierreMaximo;
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

    public void setProveedor(Proveedor proveedor) {
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
        historialEstado.add(cambio);
    }
    
    public void escalar(Proveedor proveedor, String comentario){
        this.setProveedor(proveedor);
        TransferenciaExterna escalado = new TransferenciaExterna(proveedor, getAgente());
        escalado.setComentario(comentario);
        this.historialTransferencia.add(escalado);
    }
    
    public void agregarTarea(Tarea tarea){
        this.listaTareas.add(tarea);
    }
    
    public void cambiarCategoria(Categoria categoria, String comentario){
        this.setCategoria(categoria);
        TransferenciaInterna cambioCategoria = new TransferenciaInterna(categoria, getAgente());
        cambioCategoria.setComentario(comentario);
        this.historialTransferencia.add(cambioCategoria);
    }
    
    public void mandarComentario(String comentario, Persona autor){
        Comentario com = new Comentario();
        com.setTexto(comentario);
        com.setAutor(autor);
        this.comentarios.add(com);
    }
    
    public String mostrarDatos() {
        return this.getTicketId() + " - " + this.getEstado().getNombre() + 
                " - Empleado: " + this.getEmpleado().getEmpleadoId() + " "+ this.getEmpleado().getNombre() + " - Agente: " + this.getAgente().getAgenteId() +
                " - " + this.getBiblioteca().getAbreviatura() + " - " +
                this.getUrgencia().getNombre() + " - " + this.getCategoria().getNombre() + 
                " - Fecha envio: " + this.getFechaEnvio();
    }
}