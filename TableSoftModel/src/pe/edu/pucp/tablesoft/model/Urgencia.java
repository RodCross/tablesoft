package pe.edu.pucp.tablesoft.model;

import java.util.ArrayList;

public class Urgencia {
    private int id_urgencia;
    private String nombre;
    private int plazo_maximo;
    private ArrayList<Ticket> lista_tickets;

    public Urgencia(int id_urgencia, String nombre, int plazo_maximo) {
        this.id_urgencia = id_urgencia;
        this.nombre = nombre;
        this.plazo_maximo = plazo_maximo;
        this.lista_tickets = new ArrayList<>();
    }
    public Urgencia(){}

    public int getIdUrgencia() {
        return this.id_urgencia;
    }

    public void setIdUrgencia(int id_urgencia) {
        this.id_urgencia = id_urgencia;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getPlazoMaximo() {
        return this.plazo_maximo;
    }

    public void setPlazoMaximo(int plazo_maximo) {
        this.plazo_maximo = plazo_maximo;
    }
}