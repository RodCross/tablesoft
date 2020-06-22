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
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.model.Rol;


@WebService(serviceName = "RolWS")
public class RolWS {

    private RolDAO daoRol;
    
    public RolWS(){
        daoRol = DBController.controller.getRolDAO();
    }
    
//    @WebMethod(operationName = "insertarRol")
//    public int insertarRol(@WebParam(name = "objRol") Rol rol){
//        int resultado = 0;
//        try{
//            resultado = daoRol.insertar(rol);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
//    
//    @WebMethod(operationName = "actualizarRol")
//    public int actualizarRol(@WebParam(name = "objRol") Rol rol){
//        int resultado = 0;
//        try{
//            resultado = daoRol.actualizar(rol);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
//    
//    @WebMethod(operationName = "eliminarRol")
//    public int eliminarRol(@WebParam(name = "objRol") Rol rol){
//        int resultado = 0;
//        try{
//            resultado = daoRol.eliminar(rol);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
    
    @WebMethod(operationName = "listarRoles")
    public ArrayList<Rol> listarRoles(@WebParam(name = "objRol") Rol rol){
        return daoRol.listar();
    }
}
