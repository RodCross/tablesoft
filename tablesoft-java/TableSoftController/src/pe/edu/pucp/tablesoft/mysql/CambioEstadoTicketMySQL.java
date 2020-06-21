package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.CambioEstadoTicketDAO;
import pe.edu.pucp.tablesoft.model.CambioEstadoTicket;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public class CambioEstadoTicketMySQL implements CambioEstadoTicketDAO{
    
    Connection con;
    
    @Override
    public int insertar(CambioEstadoTicket cambioEstado, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_cambio_estado_ticket(?,?,?,?,?)}");
            
            cambioEstado.setFechaCambioEstado(LocalDateTime.now());
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
            cs.setString("_COMENTARIO", cambioEstado.getComentario());
            cs.setInt("_AGENTE_ID", cambioEstado.getAgenteResponsable().getAgenteId());
            cs.setInt("_ESTADO_ID_TO", cambioEstado.getEstadoTo().getEstadoId());
            
            cs.execute();
            rpta = cs.getInt("_ID");
            cambioEstado.setCambioEstadoTicketId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<CambioEstadoTicket> listarxTicket(Ticket ticket) {
        ArrayList<CambioEstadoTicket> historial = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_cambio_estado_ticket(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            
            ResultSet rs = cs.executeQuery();

            while(rs.next()){
                CambioEstadoTicket cambio = new CambioEstadoTicket();
                
                cambio.getEstadoTo().setEstadoId(rs.getInt("estado_id_to"));
                cambio.getEstadoTo().setNombre(rs.getString("estado_nombre"));
                cambio.getEstadoTo().setDescripcion(rs.getString("estado_descripcion"));
                cambio.getEstadoTo().setActivo(rs.getBoolean("estado_activo"));
                
                cambio.setCambioEstadoTicketId(rs.getInt("cambio_estado_id"));
                cambio.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                
                cambio.setComentario(rs.getString("comentario"));
                cambio.setFechaCambioEstado(rs.getTimestamp("fecha_cambio_estado").toLocalDateTime());
                historial.add(cambio);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return historial;
    }

}
