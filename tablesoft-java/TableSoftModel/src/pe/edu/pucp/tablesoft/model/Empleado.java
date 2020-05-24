package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Empleado extends Persona {
    
    private int empleadoId;
    private ArrayList<Ticket> listaTickets;
    private Biblioteca biblioteca;

    // Constructores
    
    public Empleado() {
        biblioteca = new Biblioteca();
        this.listaTickets = new ArrayList<>();
    }
    
    public Empleado(String codigo, String dni, String nombre, String usuarioEmail) {
        super(codigo, dni, nombre, usuarioEmail);
        this.listaTickets = new ArrayList<>();
    }
    
    // Getters y setters
    public Biblioteca getBiblioteca() {
        return biblioteca;
    }
    
    public void setBiblioteca(Biblioteca biblioteca) {
        this.biblioteca = biblioteca;
    }

    public int getEmpleadoId() {
        return empleadoId;
    }

    public void setEmpleadoId(int empleadoId) {
        this.empleadoId = empleadoId;
    }

    public ArrayList<Ticket> getListaTickets() {
        return listaTickets;
    }

    public void setListaTickets(ArrayList<Ticket> listaTickets) {
        this.listaTickets = listaTickets;
    }

    // Metodos del negocio
    public void enviarTicket(Ticket ticket) {
        listaTickets.add(ticket);
    }
    
    public String mostrarDatos() {
        return getEmpleadoId() + " - " + getCodigo() + " - " +
            getDni() + " - " + getNombre() + " - " + getPersonaEmail();
    }
    
}