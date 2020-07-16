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
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Categoria;


@WebService(serviceName = "EquipoWS")
public class EquipoWS {
    private EquipoDAO daoEquipo;
    
    public EquipoWS(){
        daoEquipo = DBController.controller.getEquipoDAO();
    }
   
    @WebMethod(operationName = "insertarEquipo")
    public int insertarEquipo(@WebParam(name = "objEquipo") Equipo equipo) {
        int i = 0;
        try{
            i = daoEquipo.insertar(equipo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarEquipo")
    public int actualizarEquipo(@WebParam(name = "objEquipo") Equipo equipo) {
        int i = 0;
        try{
            i = daoEquipo.actualizar(equipo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarEquipo")
    public int eliminarEquipo(@WebParam(name = "objEquipo")  Equipo equipo) {
        int i = 0;
        try{
            i = daoEquipo.eliminar(equipo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarEquipos")
    public ArrayList<Equipo> listarEquipos(){
        return daoEquipo.listar();
    }
    
    @WebMethod(operationName = "agregarCategoria")
    public int agregarCategoria(@WebParam(name = "objEquipo")  Equipo equipo, @WebParam(name = "objCategoria")  Categoria categoria){
        int i = 0;
        try{
            i = daoEquipo.agregarCategoria(equipo, categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "quitarCategoria")
    public int quitarCategoria(@WebParam(name = "objEquipo")  Equipo equipo, @WebParam(name = "objCategoria")  Categoria categoria){
        int i = 0;
        try{
            i = daoEquipo.quitarCategoria(equipo, categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarEquiposPorNombre")
    public ArrayList<Equipo> listarEquiposPorNombre(@WebParam(name = "nombre") String nombre){
        return daoEquipo.listarxNombre(nombre);
    }
}