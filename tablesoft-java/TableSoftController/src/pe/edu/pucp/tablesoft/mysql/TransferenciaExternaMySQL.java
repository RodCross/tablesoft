package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaExternaDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Proveedor;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.TransferenciaExterna;

/*
 * @author migue
 */
public class TransferenciaExternaMySQL implements TransferenciaExternaDAO{
    Connection con;
    @Override
    public int insertar(TransferenciaExterna transferenciaExterna, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_transferencia_externa(?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
            cs.setTimestamp("_FECHA_TRANSFERENCIA", Timestamp.valueOf(LocalDateTime.now()));
            cs.setInt("_AGENTE_ID", transferenciaExterna.getAgenteResponsable().getAgenteId());
            cs.setString("_COMENTARIO", transferenciaExterna.getComentario());
            cs.setInt("_PROVEEDOR_ID", transferenciaExterna.getProveedorTo().getProveedorId());
            
            cs.execute();
            rpta = cs.getInt("_ID");
            transferenciaExterna.setTransferenciaId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta; 
    }

    @Override
    public ArrayList<TransferenciaExterna> listarxTicket(Ticket ticket) {
        ArrayList<TransferenciaExterna> historial = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_transferencia_externa(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            
            ResultSet rs = cs.executeQuery();
            
            ProveedorDAO daoProveedor = new ProveedorMySQL();
            while(rs.next()){
                Proveedor proveedorTo;
                Agente agenteResponsable;
                TransferenciaExterna transfer = new TransferenciaExterna();
                
                agenteResponsable = new Agente(rs.getInt("agente_id"));
                // Cambiar
                proveedorTo = daoProveedor.buscar(rs.getInt("proveedor_id_to"));
                
                transfer.setAgenteResponsable(agenteResponsable);
                transfer.setProveedorTo(proveedorTo);
                transfer.setTransferenciaId(rs.getInt("transferencia_id"));
                transfer.setComentario(rs.getString("comentario"));
                transfer.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());
                historial.add(transfer);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return historial;
    }
    
}
