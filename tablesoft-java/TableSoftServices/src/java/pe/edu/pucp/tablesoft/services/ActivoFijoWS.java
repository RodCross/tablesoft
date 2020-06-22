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
import pe.edu.pucp.tablesoft.dao.ActivoFijoDAO;
import pe.edu.pucp.tablesoft.model.ActivoFijo;

@WebService(serviceName = "ActivoFijoWS")
public class ActivoFijoWS {

    private ActivoFijoDAO daoActivoFijo;
    
    public ActivoFijoWS(){
        daoActivoFijo = DBController.controller.getActivoFijoDAO();
    }
   
    @WebMethod(operationName = "insertarActivoFijo")
    public int insertarActivoFijo(@WebParam(name = "objActivoFijo") ActivoFijo activoFijo) {
        int i = 0;
        try{
            i = daoActivoFijo.insertar(activoFijo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarActivoFijo")
    public int actualizarActivoFijo(@WebParam(name = "objActivoFijo") ActivoFijo activoFijo) {
        int i = 0;
        try{
            i = daoActivoFijo.actualizar(activoFijo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarActivoFijo")
    public int eliminarActivoFijo(@WebParam(name = "objActivoFijo")  ActivoFijo activoFijo) {
        int i = 0;
        try{
            i = daoActivoFijo.eliminar(activoFijo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarActivosFijos")
    public ArrayList<ActivoFijo> listarActivosFijos(){
        return daoActivoFijo.listar();
    }
    
}
