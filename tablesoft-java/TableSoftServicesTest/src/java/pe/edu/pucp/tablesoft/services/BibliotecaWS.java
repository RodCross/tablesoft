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
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.model.Biblioteca;

@WebService(serviceName = "BibliotecaWS")
public class BibliotecaWS {
    
    private BibliotecaDAO daoBiblioteca;
    
    public BibliotecaWS(){
        daoBiblioteca = DBController.controller.getBibliotecaDAO();
    }
   
    @WebMethod(operationName = "insertarBiblioteca")
    public int insertarBiblioteca(@WebParam(name = "objBiblioteca") Biblioteca biblioteca) {
        int i = 0;
        try{
            i = daoBiblioteca.insertar(biblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarBiblioteca")
    public int actualizarBiblioteca(@WebParam(name = "objBiblioteca") Biblioteca biblioteca) {
        int i = 0;
        try{
            i = daoBiblioteca.actualizar(biblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarBiblioteca")
    public int eliminarBiblioteca(@WebParam(name = "objBiblioteca") Biblioteca biblioteca) {
        int i = 0;
        try{
            i = daoBiblioteca.eliminar(biblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarBibliotecas")
    public ArrayList<Biblioteca> listarBibliotecas(){
        return daoBiblioteca.listar();
    }
    
}