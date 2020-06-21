/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.tablesoft.config.DBController;
import pe.edu.pucp.tablesoft.dao.PersonaDAO;
import pe.edu.pucp.tablesoft.model.Persona;


@WebService(serviceName = "PersonaWS")
public class PersonaWS {
    
    private PersonaDAO daoPersona;
    
    public PersonaWS(){
        daoPersona = DBController.controller.getPersonaDAO();
    }
    
    @WebMethod(operationName = "verificarPersona")
    public Persona verificarPersona(@WebParam(name = "email") String email,@WebParam(name = "password") String password) {
        Persona persona=null;
        try{
            persona = daoPersona.verificarPersona(email, password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return persona;
    }
}
