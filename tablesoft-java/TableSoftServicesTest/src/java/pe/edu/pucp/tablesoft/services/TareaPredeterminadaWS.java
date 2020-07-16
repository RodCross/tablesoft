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
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.TareaPredeterminada;

/**
 *
 * @author migue
 */
@WebService(serviceName = "TareaPredeterminadaWS")
public class TareaPredeterminadaWS {

    private TareaPredeterminadaDAO daoTareaPredeterminada;
    
    public TareaPredeterminadaWS(){
        daoTareaPredeterminada = DBController.controller.getTareaPredeterminadaDAO();
    }
   
    @WebMethod(operationName = "insertarTareaPredeterminada")
    public int insertarTareaPredeterminada(@WebParam(name = "objTareaPredeterminada") TareaPredeterminada tareaPredeterminada,
            @WebParam(name = "objCategoria") Categoria categoria) {
        int i = 0;
        try{
            i = daoTareaPredeterminada.insertar(tareaPredeterminada, categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarTareaPredeterminada")
    public int actualizarTareaPredeterminada(@WebParam(name = "objTareaPredeterminada") TareaPredeterminada tareaPredeterminada) {
        int i = 0;
        try{
            i = daoTareaPredeterminada.actualizar(tareaPredeterminada);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarTareaPredeterminada")
    public int eliminarTareaPredeterminada(@WebParam(name = "objTareaPredeterminada") TareaPredeterminada tareaPredeterminada) {
        int i = 0;
        try{
            i = daoTareaPredeterminada.eliminar(tareaPredeterminada);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarTareasPredeterminadasPorCategoria")
    public ArrayList<TareaPredeterminada> listarTareasPredeterminadasPorCategoria(@WebParam(name = "objCategoria") Categoria categoria){
        return daoTareaPredeterminada.listarxCategoria(categoria);
    }
}
