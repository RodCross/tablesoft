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
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.TransferenciaInternaDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
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
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_transferencia_externa(?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
            cs.setTimestamp("_FECHA_TRANSFERENCIA", Timestamp.valueOf(LocalDateTime.now()));
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
                    "{CALL listar_transferencia_externa(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            
            ResultSet rs = cs.executeQuery();
            
            CategoriaDAO daoCategoria = new CategoriaMySQL();
            while(rs.next()){
                Categoria categoriaTo;
                Agente agenteResponsable;
                TransferenciaInterna transfer = new TransferenciaInterna();
                
                agenteResponsable = new Agente(rs.getInt("agente_id"));
                categoriaTo = daoCategoria.buscar(rs.getInt("categoria_id_to"));
                
                transfer.setAgenteResponsable(agenteResponsable);
                transfer.setCategoriaTo(categoriaTo);
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
