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
import pe.edu.pucp.tablesoft.dao.PaisDAO;
import pe.edu.pucp.tablesoft.model.Pais;

/**
 *
 * @author Fer
 */
@WebService(serviceName = "PaisWS")
public class PaisWS {
    
    private PaisDAO daoPais;
    
    public PaisWS(){
        daoPais = DBController.controller.getPaisDAO();
    }

    @WebMethod(operationName = "listarPaises")
    public ArrayList<Pais> listarRoles(@WebParam(name = "objRol") Pais pais){
        return daoPais.listar();
    }
}
