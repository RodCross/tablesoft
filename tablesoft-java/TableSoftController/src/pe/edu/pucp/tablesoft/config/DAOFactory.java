package pe.edu.pucp.tablesoft.config;

import pe.edu.pucp.tablesoft.dao.ActivoFijoDAO;
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.dao.CambioEstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.ComentarioDAO;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.PaisDAO;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.dao.TareaDAO;
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaExternaDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaInternaDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;

/*
 * @author migue
 */
public abstract class DAOFactory {

    public static DAOFactory getDAOFactory(){
        if(DBManager.type.contains("mysql")){
            return new MySQLDAOFactory();
        }
        else{
            return new MSSQLDAOFactory();
        }
    }
    
    public abstract ActivoFijoDAO getActivoFijoDAO();
    public abstract AgenteDAO getAgenteDAO();
    public abstract BibliotecaDAO getBibliotecaDAO();
    public abstract CambioEstadoTicketDAO getCambioEstadoTicketDAO();
    public abstract CategoriaDAO getCategoriaDAO();
    public abstract ComentarioDAO getComentarioDAO();
    public abstract EmpleadoDAO getEmpleadoDAO();
    public abstract EquipoDAO getEquipoDAO();
    public abstract EstadoTicketDAO getEstadoTicketDAO();
    public abstract PaisDAO getPaisDAO();
    public abstract ProveedorDAO getProveedorDAO();
    public abstract RolDAO getRolDAO();
    public abstract TareaDAO getTareaDAO();
    public abstract TareaPredeterminadaDAO getTareaPredeterminadaDAO();
    public abstract TicketDAO getTicketDAO();
    public abstract TransferenciaInternaDAO getTransferenciaInternaDAO();
    public abstract TransferenciaExternaDAO getTransferenciaExternaDAO();
    public abstract UrgenciaDAO getUrgenciaDAO();
}
