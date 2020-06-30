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
import pe.edu.pucp.tablesoft.dao.TareaDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Tarea;
import pe.edu.pucp.tablesoft.model.Ticket;

/**
 *
 * @author Fer
 */
@WebService(serviceName = "TareaWS")
public class TareaWS {

    private TareaDAO daoTarea;
    
    public TareaWS(){
        daoTarea = DBController.controller.getTareaDAO();
    }
   
    @WebMethod(operationName = "insertarTarea")
    public int insertarTarea(@WebParam(name = "objTarea") Tarea tarea, @WebParam(name = "objTicket")  Ticket ticket) {
        int i = 0;
        try{
            i = daoTarea.insertar(tarea, ticket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarTarea")
    public int actualizarTarea(@WebParam(name = "objTarea") Tarea tarea, @WebParam(name = "objAgente")  Agente agente) {
        int i = 0;
        try{
            i = daoTarea.actualizar(tarea, agente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    @WebMethod(operationName = "actualizarInsertarTareas")
    public int actualizarInsertarTareas(@WebParam(name = "objArrTarea") ArrayList<Tarea>tareas, @WebParam(name = "objTicket")  Ticket ticket) {
        int i = 0;
        try{
            i = daoTarea.actualizarInsertarArreglo(tareas, ticket);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarTarea")
    public int eliminarTarea(@WebParam(name = "objTarea") Tarea tarea) {
        int i = 0;
        try{
            i = daoTarea.eliminar(tarea);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarTareas")
    public int eliminarTareas(@WebParam(name = "objTarea") ArrayList<Tarea> tareas) {
        int i = 0;
        try{
            i = daoTarea.eliminarArreglo(tareas);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarTareasPorTicket")
    public ArrayList<Tarea> listarTareas(@WebParam(name = "objTicket")  Ticket ticket){
        return daoTarea.listarxTicket(ticket);
    }
}
