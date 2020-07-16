package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.TransferenciaExternaDAO;
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
            
            transferenciaExterna.setFecha(LocalDateTime.now());
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_transferencia_externa(?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
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
            
            while(rs.next()){
                TransferenciaExterna transfer = new TransferenciaExterna();
                
                transfer.setTransferenciaId(rs.getInt("transferencia_id"));
                transfer.setComentario(rs.getString("comentario"));
                transfer.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());
                
                transfer.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                transfer.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                transfer.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                transfer.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                transfer.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));
                
                transfer.getProveedorTo().setProveedorId(rs.getInt("proveedor_id_to"));
                transfer.getProveedorTo().setRuc(rs.getString("ruc"));
                transfer.getProveedorTo().setRazonSocial(rs.getString("razon_social"));
                transfer.getProveedorTo().setTelefono(rs.getString("telefono"));
                transfer.getProveedorTo().setDireccion(rs.getString("direccion"));
                transfer.getProveedorTo().setEmail(rs.getString("proveedor_email"));
                transfer.getProveedorTo().setActivo(rs.getBoolean("proveedor_activo"));
                
                transfer.getProveedorTo().getCiudad().setCiudadId(rs.getInt("ciudad_id"));
                transfer.getProveedorTo().getCiudad().setNombre(rs.getString("ciudad_nombre"));
                transfer.getProveedorTo().getCiudad().getPais().setPaisId(rs.getInt("pais_id"));
                transfer.getProveedorTo().getCiudad().getPais().setNombre(rs.getString("pais_nombre"));
                
                historial.add(transfer);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return historial;
    }
    
}
