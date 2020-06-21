package pe.edu.pucp.tablesoft.config;

import pe.edu.pucp.tablesoft.dao.ActivoFijoDAO;
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.dao.CambioEstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.CiudadDAO;
import pe.edu.pucp.tablesoft.dao.ComentarioDAO;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.PaisDAO;
import pe.edu.pucp.tablesoft.dao.PersonaDAO;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.dao.TareaDAO;
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaExternaDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaInternaDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.mysql.ActivoFijoMySQL;
import pe.edu.pucp.tablesoft.mysql.AgenteMySQL;
import pe.edu.pucp.tablesoft.mysql.BibliotecaMySQL;
import pe.edu.pucp.tablesoft.mysql.CambioEstadoTicketMySQL;
import pe.edu.pucp.tablesoft.mysql.CategoriaMySQL;
import pe.edu.pucp.tablesoft.mysql.CiudadMySQL;
import pe.edu.pucp.tablesoft.mysql.ComentarioMySQL;
import pe.edu.pucp.tablesoft.mysql.EmpleadoMySQL;
import pe.edu.pucp.tablesoft.mysql.EquipoMySQL;
import pe.edu.pucp.tablesoft.mysql.EstadoTicketMySQL;
import pe.edu.pucp.tablesoft.mysql.PaisMySQL;
import pe.edu.pucp.tablesoft.mysql.PersonaMySQL;
import pe.edu.pucp.tablesoft.mysql.ProveedorMySQL;
import pe.edu.pucp.tablesoft.mysql.RolMySQL;
import pe.edu.pucp.tablesoft.mysql.TareaMySQL;
import pe.edu.pucp.tablesoft.mysql.TareaPredeterminadaMySQL;
import pe.edu.pucp.tablesoft.mysql.TicketMySQL;
import pe.edu.pucp.tablesoft.mysql.TransferenciaExternaMySQL;
import pe.edu.pucp.tablesoft.mysql.TransferenciaInternaMySQL;
import pe.edu.pucp.tablesoft.mysql.UrgenciaMySQL;

/*
 * @author migue
 */
public class MySQLDAOFactory extends DAOFactory{
        
    public MySQLDAOFactory(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
        }catch(ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
    }

    @Override
    public ActivoFijoDAO getActivoFijoDAO() {
        return new ActivoFijoMySQL();
    }

    @Override
    public AgenteDAO getAgenteDAO() {
        return new AgenteMySQL();
    }

    @Override
    public BibliotecaDAO getBibliotecaDAO() {
        return new BibliotecaMySQL();
    }

    @Override
    public CambioEstadoTicketDAO getCambioEstadoTicketDAO() {
        return new CambioEstadoTicketMySQL();
    }

    @Override
    public CategoriaDAO getCategoriaDAO() {
        return new CategoriaMySQL();
    }

    @Override
    public ComentarioDAO getComentarioDAO() {
        return new ComentarioMySQL();
    }

    @Override
    public EmpleadoDAO getEmpleadoDAO() {
        return new EmpleadoMySQL();
    }

    @Override
    public EquipoDAO getEquipoDAO() {
        return new EquipoMySQL();
    }

    @Override
    public EstadoTicketDAO getEstadoTicketDAO() {
        return new EstadoTicketMySQL();
    }

    @Override
    public ProveedorDAO getProveedorDAO() {
        return new ProveedorMySQL();
    }

    @Override
    public RolDAO getRolDAO() {
        return new RolMySQL();
    }

    @Override
    public TareaDAO getTareaDAO() {
        return new TareaMySQL();
    }

    @Override
    public TareaPredeterminadaDAO getTareaPredeterminadaDAO() {
        return new TareaPredeterminadaMySQL();
    }

    @Override
    public TicketDAO getTicketDAO() {
        return new TicketMySQL();
    }

    @Override
    public TransferenciaInternaDAO getTransferenciaInternaDAO() {
        return new TransferenciaInternaMySQL();
    }

    @Override
    public TransferenciaExternaDAO getTransferenciaExternaDAO() {
        return new TransferenciaExternaMySQL();
    }

    @Override
    public UrgenciaDAO getUrgenciaDAO() {
        return new UrgenciaMySQL();
    }

    @Override
    public PaisDAO getPaisDAO() {
        return new PaisMySQL();
    }

    @Override
    public PersonaDAO getPersonaDAO() {
        return new PersonaMySQL();
    }

    @Override
    public CiudadDAO getCiudadDAO() {
        return new CiudadMySQL();
    }
    
    
}
