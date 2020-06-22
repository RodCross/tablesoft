///*
// * To change this license header, choose License Headers in Project Properties.
// * To change this template file, choose Tools | Templates
// * and open the template in the editor.
// */
//package pe.edu.pucp.tablesoft.services;
//
//import java.util.ArrayList;
//import javax.jws.WebService;
//import javax.jws.WebMethod;
//import javax.jws.WebParam;
//import pe.edu.pucp.tablesoft.config.DBController;
//import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
//import pe.edu.pucp.tablesoft.model.Urgencia ;
//
//@WebService(serviceName = "UrgenciaWS")
//public class UrgenciaWS {
//
//    private UrgenciaDAO daoUrgencia;
//    
//    public UrgenciaWS(){
//        daoUrgencia = DBController.controller.getUrgenciaDAO();
//    }
//    
////    @WebMethod(operationName = "insertarUrgencia")
////    public int insertarUrgencia(@WebParam(name = "objUrgencia") Urgencia urgencia) {
////        int i = 0;
////        try{
////            i = daoUrgencia.insertar(urgencia);
////        }catch(Exception ex){
////            System.out.println(ex.getMessage());
////        }
////        return i;
////    }
////    
////    @WebMethod(operationName = "actualizarUrgencia")
////    public int actualizarUrgencia(@WebParam(name = "objUrgencia") Urgencia urgencia) {
////        int i = 0;
////        try{
////            i = daoUrgencia.actualizar(urgencia);
////        }catch(Exception ex){
////            System.out.println(ex.getMessage());
////        }
////        return i;
////    }
////    
////    @WebMethod(operationName = "eliminarUrgencia")
////    public int eliminarUrgencia(@WebParam(name = "objUrgencia") Urgencia urgencia) {
////        int i = 0;
////        try{
////            i = daoUrgencia.eliminar(urgencia);
////        }catch(Exception ex){
////            System.out.println(ex.getMessage());
////        }
////        return i;
////    }
//    
//    @WebMethod(operationName = "listarUrgencias")
//    public ArrayList<Urgencia> listarUrgencias(){
//        return daoUrgencia.listar();
//    }
//    
//    
//}
