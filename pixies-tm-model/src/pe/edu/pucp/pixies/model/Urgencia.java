package pe.edu.pucp.pixies.model;

import java.time.LocalDate;

public class Urgencia {
    private int id_urgencia;
    private String nombre;
    private LocalDate plazo_maximo;

    public Urgencia(int id_urgencia, String nombre, LocalDate plazo_maximo) {
        this.id_urgencia = id_urgencia;
        this.nombre = nombre;
        this.plazo_maximo = plazo_maximo;
    }

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

    public LocalDate getPlazoMaximo() {
        return this.plazo_maximo;
    }

    public void setPlazoMaximo(LocalDate plazo_maximo) {
        this.plazo_maximo = plazo_maximo;
    }
}