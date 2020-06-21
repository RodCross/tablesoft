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
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


@WebService(serviceName = "CategoriaWS")
public class CategoriaWS {

    private CategoriaDAO daoCategoria;
    
    public CategoriaWS(){
        daoCategoria = DBController.controller.getCategoriaDAO();
    }
   
    @WebMethod(operationName = "insertarCategoria")
    public int insertarCategoria(@WebParam(name = "objCategoria") Categoria categoria) {
        int i = 0;
        try{
            i = daoCategoria.insertar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarCategoria")
    public int actualizarCategoria(@WebParam(name = "objCategoria") Categoria categoria) {
        int i = 0;
        try{
            i = daoCategoria.actualizar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarCategoria")
    public int eliminarCategoria(@WebParam(name = "objCategoria") Categoria categoria) {
        int i = 0;
        try{
            i = daoCategoria.eliminar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarCategorias")
    public ArrayList<Categoria> listarCategorias(){
        return daoCategoria.listar();
    }
    
    @WebMethod(operationName = "listarCategoriasDisponibles")
    public ArrayList<Categoria> listarCategoriasDisponibles(){
        return daoCategoria.listarDisponibles();
    }
    
    @WebMethod(operationName = "listarCategoriasPorEquipo")
    public ArrayList<Categoria> listarCategoriasPorEquipo(@WebParam(name = "objCategoria") Equipo equipo){
        return daoCategoria.listarxEquipo(equipo);
    }
}
