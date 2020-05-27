package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Agente extends Persona {
    private int agenteId;
    private String agenteEmail;
    private ArrayList<Ticket> listaTickets;
    private Equipo equipo;
    private Rol rol;
    
    // Constructores
    public Agente() {
        equipo = new Equipo();
        rol = new Rol();
        listaTickets = new ArrayList();
    }

    public Agente(String codigo, String dni, String nombre, String usuarioEmail, String agenteEmail) {
        super(codigo, dni, nombre, usuarioEmail);
        this.agenteEmail = agenteEmail;
        listaTickets = new ArrayList<>();
    }
    
    public Agente(int agenteId){
        this.agenteId = agenteId;
    }
    
    // Getter y setter
    public Rol getRol() {
        return rol;
    }

    public void setRol(Rol rol) {
        this.rol = rol;
    }

    public Equipo getEquipo() {
        return equipo;
    }

    public void setEquipo(Equipo equipo) {
        this.equipo = equipo;
    }
    
    public int getAgenteId() {
        return agenteId;
    }

    public void setAgenteId(int agenteId) {
        this.agenteId = agenteId;
    }

    public String getAgenteEmail() {
        return agenteEmail;
    }

    public void setAgenteEmail(String agenteEmail) {
        this.agenteEmail = agenteEmail;
    }

    public ArrayList<Ticket> getListaTickets() {
        return listaTickets;
    }

    public void setListaTickets(ArrayList<Ticket> listaTickets) {
        this.listaTickets = listaTickets;
    }
    
    
    // Metodos del negocio

    public void asignarTicket(Ticket ticket) {
        listaTickets.add(ticket);
    }
    
    public ArrayList<Ticket> filtrarTicketsxEstado(EstadoTicket estado){
        ArrayList<Ticket>listaFiltrada = new ArrayList<>();
        for (Ticket t : listaTickets){
            if(t.getEstado().getEstadoId() == estado.getEstadoId())
                listaFiltrada.add(t);
        }
        return listaFiltrada;
    }
    
    public String mostrarDatos() {
        return getAgenteId() + " - " + getCodigo() + " - " +
            getDni() + " - " + getNombre() + " - " + getPersonaEmail();
    }
}