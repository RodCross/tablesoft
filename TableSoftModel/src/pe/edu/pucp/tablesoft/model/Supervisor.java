package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

public class Supervisor extends Agente {
    
    // Constructores
    public Supervisor() {
        
    }
    
    public Supervisor(String codigo, String dni, String nombre, String usuarioEmail, String agenteEmail) {
        super(codigo, dni, nombre, usuarioEmail, agenteEmail);
    }
    
    // Metodos del negocio
    public String reporteTickets(LocalDateTime fechaInicio, LocalDateTime fechaFin) {
        /* Reporte de tickets del mismo equipo */
        String reporte = "";
        Equipo miEquipo = this.getEquipo();
        
        // FALTA
        
        return reporte;
    }
    
    public void agregarCategoria(Categoria categoria) {
        /* Agrega una categoria al equipo */
        this.getEquipo().agregarCategoria(categoria);
    }
    
    public void quitarCategoria(int categoriaId) {
        /* Quita una categoria del equipo */
        this.getEquipo().quitarCategoria(categoriaId);
    }
}