package pe.edu.pucp.tablesoft.model;



public class Tarea {
    private int tareaId;
    private String descripcion;
    private EstadoTarea estado;
    private Agente agente;

    public Tarea() {
        estado = new EstadoTarea();
        agente = new Agente();
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

    public EstadoTarea getEstado() {
        return estado;
    }

    public void setEstado(EstadoTarea estado) {
        this.estado = estado;
    }
    
}
