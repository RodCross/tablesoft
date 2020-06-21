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
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.model.Proveedor;

/**
 *
 * @author CARBAJAL
 */
@WebService(serviceName = "ProveedorWS")
public class ProveedorWS {

    private ProveedorDAO daoProveedor;
    
    public ProveedorWS(){
        daoProveedor = DBController.controller.getProveedorDAO();
    }
   
    @WebMethod(operationName = "insertarProveedor")
    public int insertarProveedor(@WebParam(name = "objProveedor") Proveedor proveedor) {
        int i = 0;
        try{
            i = daoProveedor.insertar(proveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarProveedor")
    public int actualizarProveedor(@WebParam(name = "objActivoFijo") Proveedor proveedor) {
        int i = 0;
        try{
            i = daoProveedor.actualizar(proveedor);
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
