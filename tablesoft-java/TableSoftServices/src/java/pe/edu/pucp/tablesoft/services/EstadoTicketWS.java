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
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.model.EstadoTicket;
/**
 *
 * @author migue
 */
@WebService(serviceName = "EstadoTicketWS")
public class EstadoTicketWS {

    private EstadoTicketDAO daoEstadoTicket;
    
    public EstadoTicketWS(){
        daoEstadoTicket = DBController.controller.getEstadoTicketDAO();
    }
   
    @WebMethod(operationName = "insertarEstadoTicket")
    public int insertarEstadoTicket(@WebParam(name = "objEstadoTicket") EstadoTicket estadoTicket) {
        int i = 0;
        try{
            i = daoEstadoTicket.insertar(estadoTicket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarEstadoTicket")
    public int actualizarEstadoTicket(@WebParam(name = "objEstadoTicket") EstadoTicket estadoTicket) {
        int i = 0;
        try{
            i = daoEstadoTicket.actualizar(estadoTicket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarEstadoTicket")
    public int eliminarEstadoTicket(@WebParam(name = "objEstadoTicket") EstadoTicket estadoTicket) {
        int i = 0;
        try{
            i = daoEstadoTicket.eliminar(estadoTicket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarEstadosTicket")
    public ArrayList<EstadoTicket> listarEstadosTicket(){
        return daoEstadoTicket.listar();
    }
}
