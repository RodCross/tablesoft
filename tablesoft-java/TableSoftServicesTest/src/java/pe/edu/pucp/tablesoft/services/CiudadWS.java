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
import pe.edu.pucp.tablesoft.dao.CiudadDAO;
import pe.edu.pucp.tablesoft.model.Ciudad;
import pe.edu.pucp.tablesoft.model.Pais;
/**
 *
 * @author migue
 */
@WebService(serviceName = "CiudadWS")
public class CiudadWS {

    /**
     * This is a sample web service operation
     */
    private CiudadDAO daoCiudad;
    
    public CiudadWS(){
        daoCiudad = DBController.controller.getCiudadDAO();
    }

    @WebMethod(operationName = "listarCiudadesDePais")
    public ArrayList<Ciudad> listarCiudadesDePais(@WebParam(name = "objPais") Pais pais){
        return daoCiudad.listarxPais(pais);
    }
}
