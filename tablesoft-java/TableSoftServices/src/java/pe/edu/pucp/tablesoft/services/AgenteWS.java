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
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Equipo;

@WebService(serviceName = "AgenteWS")
public class AgenteWS {

    private AgenteDAO daoAgente;
    
    public AgenteWS(){
        daoAgente = DBController.controller.getAgenteDAO();
    }
   
    @WebMethod(operationName = "insertarAgente")
    public int insertarAgente(@WebParam(name = "objAgente") Agente agente) {
        int i = 0;
        try{
            i = daoAgente.insertar(agente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarAgente")
    public int actualizarAgente(@WebParam(name = "objAgente") Agente agente) {
        int i = 0;
        try{
            i = daoAgente.actualizar(agente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarAgente")
    public int eliminarAgente(@WebParam(name = "objAgente") Agente agente) {
        int i = 0;
        try{
            i = daoAgente.eliminar(agente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarAgentes")
    public ArrayList<Agente> listarAgentes(){
        return daoAgente.listar();
    }
    
    @WebMethod(operationName = "listarAgentesPorEquipo")
    public ArrayList<Agente> listarAgentesPorEquipo(@WebParam(name = "objAgente") Equipo equipo){
        return daoAgente.listarxEquipo(equipo);
    }
}
