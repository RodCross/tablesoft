package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

public class Supervisor extends Agente {
    
    // Constructores
    public Supervisor(String codigo_pucp, String dni, String nombre, String correo_agente) {
        super(codigo_pucp, dni, nombre, correo_agente);
    }
    public Supervisor(){
        
    }
    
    // Metodos del negocio
    public String reporteTickets(LocalDateTime fecha_inicio, LocalDateTime fecha_fin){
        /* Reporte de tickets del mismo equipo */
        String reporte = "";
        Equipo miEquipo = this.getEquipo();
        
        // FALTA
        
        return reporte;
    }
    
    public void agregarCategoria(Categoria categoria){
        /* Agrega una categoria al equipo */
        this.getEquipo().agregarCategoria(categoria);
    }
    
    public void quitarCategoria(int id_categoria){
        /* Quita una categoria del equipo */
        this.getEquipo().quitarCategoria(id_categoria);
    }
}