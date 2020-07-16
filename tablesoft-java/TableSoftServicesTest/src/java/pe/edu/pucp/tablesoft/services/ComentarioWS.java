/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.tablesoft.config.DBController;
import pe.edu.pucp.tablesoft.dao.ComentarioDAO;
import pe.edu.pucp.tablesoft.model.Comentario;
import pe.edu.pucp.tablesoft.model.Ticket;

/**
 *
 * @author CARBAJAL
 */
@WebService(serviceName = "ComentarioWS")
public class ComentarioWS {

    /**
     * This is a sample web service operation
     */
    private ComentarioDAO daoComentario;
    
    public ComentarioWS(){
        daoComentario = DBController.controller.getComentarioDAO();
    }
   
    @WebMethod(operationName = "insertarComentario")
    public int insertarComentario(@WebParam(name = "objComentario") Comentario comentario, @WebParam(name = "objTicket") Ticket ticket) {
        int i = 0;
        try{
            i = daoComentario.insertar(comentario, ticket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarComentariosDeTicket")
    public ArrayList<Comentario> listarComentariosDeTicket(@WebParam(name = "objTicket") Ticket ticket) {
        return daoComentario.listarxTicket(ticket);
    }
}
