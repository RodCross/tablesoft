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
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Biblioteca;



@WebService(serviceName = "EmpleadoWS")
public class EmpleadoWS {

    private EmpleadoDAO daoEmpleado;
    
    public EmpleadoWS(){
        daoEmpleado = DBController.controller.getEmpleadoDAO();
    }
   
    @WebMethod(operationName = "insertarEmpleado")
    public int insertarEmpleado(@WebParam(name = "objEmpleado") Empleado empleado) {
        int i = 0;
        try{
            i = daoEmpleado.insertar(empleado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "actualizarEmpleado")
    public int actualizarEmpleado(@WebParam(name = "objEmpleado") Empleado empleado) {
        int i = 0;
        try{
            i = daoEmpleado.actualizar(empleado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "eliminarEmpleado")
    public int eliminarEmpleado(@WebParam(name = "objEmpleado") Empleado empleado) {
        int i = 0;
        try{
            i = daoEmpleado.eliminar(empleado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return i;
    }
    
    @WebMethod(operationName = "listarEmpleados")
    public ArrayList<Empleado> listarEmpleados(){
        return daoEmpleado.listar();
    }
    
    @WebMethod(operationName = "listarEmpleadosDeBiblioteca")
    public ArrayList<Empleado> listarEmpleadosDeBiblioteca(@WebParam(name = "objBiblioteca") Biblioteca biblioteca){
        return daoEmpleado.listarxBiblioteca(biblioteca);
    }
    
   
}
