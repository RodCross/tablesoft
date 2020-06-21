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
import pe.edu.pucp.tablesoft.dao.ComentarioDAO;
import pe.edu.pucp.tablesoft.model.Comentario;
import pe.edu.pucp.tablesoft.model.Persona;
import pe.edu.pucp.tablesoft.model.Ticket;

/*
 * @author migue
 */
public class ComentarioMySQL implements ComentarioDAO {

    Connection con;
    
    @Override
    public int insertar(Comentario comentario, Ticket ticket) {
        int rpta = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL insertar_comentario(?,?,?,?,?)}");
            
            cs.registerOutParameter("_ID", java.sql.Types.INTEGER);
            cs.setInt("_TICKET_ID", ticket.getTicketId());
            cs.setTimestamp("_FECHA", Timestamp.valueOf(LocalDateTime.now()));
            cs.setString("_TEXTO", comentario.getTexto());
            cs.setString("_PERSONA_ID", comentario.getAutor().getCodigo());
                       
            cs.execute();
            rpta = cs.getInt("_ID");
            comentario.setComentarioId(rpta);
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public ArrayList<Comentario> listarxTicket(Ticket ticket) {
        ArrayList<Comentario> comentarios = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{CALL listar_comentario(?)}");
            
            cs.setInt("_ID", ticket.getTicketId());
            ResultSet rs = cs.executeQuery();

            while(rs.next()){
                Comentario comentario = new Comentario();
                
                comentario.setComentarioId(rs.getInt("comentario_id"));
                comentario.getAutor().setCodigo(rs.getString("autor_codigo"));
                comentario.getAutor().setNombre(rs.getString("autor_nombre"));
                comentario.getAutor().setApellidoPaterno(rs.getString("autor_apellido_paterno"));
                comentario.getAutor().setApellidoMaterno(rs.getString("autor_apellido_materno"));
                comentario.getAutor().setTipo(rs.getString("autor_tipo").charAt(0));
                comentario.setFecha(rs.getTimestamp("fecha").toLocalDateTime());
                comentario.setTexto(rs.getString("texto"));
                
                comentarios.add(comentario);
            }
            con.close();
            
        } catch(SQLException | ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
        
        return comentarios;
    }

}
