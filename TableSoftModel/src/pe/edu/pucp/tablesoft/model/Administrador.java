package pe.edu.pucp.tablesoft.model;

import java.time.LocalDateTime;

/* A tener en cuenta:
   Como administrador, puede acceder y manejar todos los equipos del sistema
   Pero, para hacerlo necesito hacerlo a traves de la base de datos
   this.getEquipo() devolveria el equipo al que pertenece, un equipo de adminsitracion
*/

public class Administrador extends Supervisor {
    public Administrador() {
        
    }
    
    public Administrador(String codigo, String dni, String nombre, String usuarioEmail, String agenteEmail) {
        super(codigo, dni, nombre, usuarioEmail, agenteEmail);
    }
    
    // Metodos del negocio
    public int agregarEquipo(Equipo equipo) {
        // FALTA
        // Usa EquipoDAO.insertar()
        // Agrega un equipo a la base de datos
        return 0;
    }
    
    public int agregarAgente(Agente agente) {
        // FALTA
        // Usa AgenteDAO.insertar()
        // Agregar a la base de datos
        return 0;
    }

    public int agregarNuevaCategoria(Categoria categoria) {
        // FALTA
        // Usa CategoriaDAO.insertar()
        // Agregar a la base de datos
        return 0;
    }
    
    public int agregarProveedor(Categoria categoria) {
        // FALTA
        // Usa ProveedorDAO.insertar()
        // Agregar a la base de datos
        return 0;
    }
    
    public int asignarAgenteAEquipo(Agente agente, Equipo equipo) {
        // FALTA
        // Usa EquipoDAO.listar() y AgenteDAO.listar()
        // Cambia los identificadores correspondientes
        return 0;
    }
    
    public String reporteTicketsAdmin(LocalDateTime fechaInicio, LocalDateTime fechaFin, int modo) {
        String reporte = "";
        // FALTA
        // Usa TicketsDAO.listar() para obtener todos los tickets
        // O Agente.listar() para obtener todos los supervisores y usar su metodo de reporte
        // Modo define si es por equipos, o por categorias
        
        return reporte;
    }
    
    public int quitarAgente(int agenteId) {
        // FALTA
        // Quita de la base de datos?
        // O de su equipo actual de administracion
        return 0;
    }
}