package pe.edu.pucp.pixies.model;

import java.time.LocalDateTime;

public class Ticket {
    private int id_ticket;
    private int id_categoria;
    private int id_urgencia;
    private int id_proveedor;
    private int estado;
    private String info_adicional;
    private int id_activo_fijo;
    private LocalDateTime fecha_envio;
    private LocalDateTime fecha_primera_respuesta;
    private LocalDateTime fecha_cierre;
}