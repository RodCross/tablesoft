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
//import pe.edu.pucp.tablesoft.dao.TicketDAO;
//import pe.edu.pucp.tablesoft.model.Agente;
//import pe.edu.pucp.tablesoft.model.Categoria;
//import pe.edu.pucp.tablesoft.model.Empleado;
//import pe.edu.pucp.tablesoft.model.Equipo;
//import pe.edu.pucp.tablesoft.model.EstadoTicket;
//import pe.edu.pucp.tablesoft.model.Ticket;
//
///**
// *
// * @author migue
// */
//@WebService(serviceName = "TicketWS")
//public class TicketWS {
//
//    private TicketDAO daoTicket;
//    
//    public TicketWS(){
//        daoTicket = DBController.controller.getTicketDAO();
//    }
//   
////    @WebMethod(operationName = "insertarTicket")
////    public int insertarTicket(@WebParam(name = "objTicket") Ticket ticket) {
////        int i = 0;
////        try{
////            i = daoTicket.insertar(ticket);
////        }catch(Exception ex){
////            System.out.println(ex.getMessage());
////        }
////        return i;
////    }
////    
////    @WebMethod(operationName = "actualizarTicket")
////    public int actualizarTicket(@WebParam(name = "objTicket") Ticket ticket) {
////        int i = 0;
////        try{
////            i = daoTicket.actualizar(ticket);
////        }catch(Exception ex){
////            System.out.println(ex.getMessage());
////        }
////        return i;
////    }
//    
//    @WebMethod(operationName = "listarTickets")
//    public ArrayList<Ticket> listarTickets(){
//        return daoTicket.listar();
//    }
//    
//    @WebMethod(operationName = "listarTicketsPorAgente")
//    public ArrayList<Ticket> listarTicketsPorAgente(@WebParam(name = "objAgente") Agente agente){
//        return daoTicket.listarxAgente(agente);
//    }
//    
//    @WebMethod(operationName = "listarTicketsPorEmpleado")
//    public ArrayList<Ticket> listarTicketsPorEmpleado(@WebParam(name = "objEmpleado") Empleado empleado){
//        return daoTicket.listarxEmpleado(empleado);
//    }
//    
//    @WebMethod(operationName = "listarTicketsPorCategoria")
//    public ArrayList<Ticket> listarTicketsPorCategoria(@WebParam(name = "objCategoria") Categoria categoria){
//        return daoTicket.listarxCategoria(categoria);
//    }
//    
//    @WebMethod(operationName = "listarTicketsPorEstadoPorEquipo")
//    public ArrayList<Ticket> listarTicketsPorEstadoPorEquipo(@WebParam(name = "objEstadoTicket") EstadoTicket estado,@WebParam(name = "objEquipo") Equipo equipo ){
//        return daoTicket.listarxEstadoxEquipo(estado, equipo);
//    }
//}
