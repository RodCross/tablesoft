package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDateTime;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.TransferenciaInternaDAO;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.TransferenciaInterna;

/*
 * @author migue
 */
public class TransferenciaInternaMySQL implements TransferenciaInternaDAO {

    Connection con;
    @Override
    public int insertar(TransferenciaInterna transferenciaInterna, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            transferenciaInterna.setFecha(LocalDateTime.now());
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_transferencia_interna(?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
            cs.setInt("_AGENTE_ID", transferenciaInterna.getAgenteResponsable().getAgenteId());
            cs.setString("_COMENTARIO", transferenciaInterna.getComentario());
            cs.setInt("_CATEGORIA_ID", transferenciaInterna.getCategoriaTo().getCategoriaId());
            
            cs.execute();
            rpta = cs.getInt("_ID");
            transferenciaInterna.setTransferenciaId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta; 
    }

    @Override
    public ArrayList<TransferenciaInterna> listarxTicket(Ticket ticket) {
        ArrayList<TransferenciaInterna> historial = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_transferencia_interna(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            
            ResultSet rs = cs.executeQuery();
            
            while(rs.next()){
                TransferenciaInterna transfer = new TransferenciaInterna();
                
                transfer.setTransferenciaId(rs.getInt("transferencia_id"));
                transfer.setComentario(rs.getString("comentario"));
                transfer.setFecha(rs.getTimestamp("fecha_transferencia").toLocalDateTime());
                
                transfer.getAgenteResponsable().setAgenteId(rs.getInt("agente_id"));
                transfer.getAgenteResponsable().setNombre(rs.getString("agente_nombre"));
                transfer.getAgenteResponsable().setApellidoPaterno(rs.getString("agente_apellido_paterno"));
                transfer.getAgenteResponsable().setApellidoMaterno(rs.getString("agente_apellido_materno"));
                transfer.getAgenteResponsable().setCodigo(rs.getString("agente_codigo"));
                
                transfer.getCategoriaTo().setCategoriaId(rs.getInt("categoria_id_to"));
                transfer.getCategoriaTo().setNombre(rs.getString("categoria_nombre"));
                transfer.getCategoriaTo().setDescripcion(rs.getString("categoria_descripcion"));
                transfer.getCategoriaTo().setActivo(rs.getBoolean("categoria_activo"));
                
                historial.add(transfer);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return historial;
    }

}
