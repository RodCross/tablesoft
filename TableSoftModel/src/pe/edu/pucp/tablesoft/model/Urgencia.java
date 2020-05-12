package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Urgencia {
    private int urgenciaId;
    private String nombre;
    private int plazoMaximo;
    private ArrayList<Ticket> listaTickets;
    
    public Urgencia(int urgenciaId, String nombre, int plazoMaximo) {
        this.urgenciaId = urgenciaId;
        this.nombre = nombre;
        this.plazoMaximo = plazoMaximo;
        this.listaTickets = new ArrayList<>();
    }

    public Urgencia(String nombre, int plazoMaximo) {
        this.nombre = nombre;
        this.plazoMaximo = plazoMaximo;
        this.listaTickets = new ArrayList<>();
    }
    public Urgencia(){}

    public int getUrgenciaId() {
        return this.urgenciaId;
    }

    public void setUrgenciaId(int id_urgencia) {
        this.urgenciaId = id_urgencia;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getPlazoMaximo() {
        return this.plazoMaximo;
    }

    public void setPlazoMaximo(int plazoMaximo) {
        this.plazoMaximo = plazoMaximo;
    }
}