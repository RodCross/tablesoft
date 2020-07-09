/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Timestamp;
import java.util.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import net.sf.jasperreports.view.JasperViewer;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketAgente;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketCategoria;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketEquipo;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketUrgencia;
import pe.edu.pucp.tablesoft.servlets.ReporteTickets;

/**
 *
 * @author STEFANO
 */
@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "generarReporteTicket")
    public byte[] generarReporteTicket(@WebParam(name = "idTicket") int idTicket) {
        byte[] arreglo = null;
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = ReporteTickets.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath().replace("%20", " ");
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket2.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte1Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath().replace("%20", " ");
            
            
            //Obtener la ruta del subreporte
            String rutaSubReporte2Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta del subreporte2
            String rutaSubReporte3Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath().replace("%20", " ");

            String rutaSubReporte4Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta al archivo
            String rutaSubReporte5Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath().replace("%20", " ");

            String rutaSubReporte6Jasper
            = ReporteTickets.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath().replace("%20", " ");

            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            
            hm.put("Ticket_id", idTicket);
            hm.put("RUTA_REPORTE", rutaSubReporte1Jasper);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte5Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte6Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);

            //Cerramos la conexion
            con.close();

            arreglo = JasperExportManager.exportReportToPdf(objJPrint);
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    
    @WebMethod(operationName = "generarReporteTicketUrgencia")
    public byte[] generarReporteTicketUrgencia(@WebParam(name = "objUrgencia") Urgencia urg,@WebParam(name = "fechaIni") Date fechaIni,@WebParam(name = "fechaFin")Date fechaFin) {
        byte[] arreglo = null;
        
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = ReporteTicketUrgencia.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath().replace("%20", " ");
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte1Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath().replace("%20", " ");
            
            //Obtener la ruta del subreporte
            String rutaSubReporte2Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta del subreporte2
            String rutaSubReporte3Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath().replace("%20", " ");

            String rutaSubReporte4Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta al archivo
            String rutaSubReporte5Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath().replace("%20", " ");

            String rutaSubReporte6Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte7Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Escalados_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte8Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Demorados_Urgencia.jasper").getPath().replace("%20", " ");

            String rutaSubReporte9Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Recategorizados_Urgencia.jasper").getPath().replace("%20", " ");

            String rutaSubReporte10Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Escalados_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte11Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Recategorizados_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte12Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Demorados_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte13Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Dia_Urgencia.jasper").getPath().replace("%20", " ");

            String rutaSubReporte14Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Biblioteca_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte15Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_ActivoFijo_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte16Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_ActivoFijo_Urgencia.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte17Jasper
            = ReporteTicketUrgencia.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Categoria_Urgencia.jasper").getPath().replace("%20", " ");
            
            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            
            hm.put("Urgencia_id", urg.getUrgenciaId());
            hm.put("Urgencia_nombre", urg.getNombre());
            hm.put("Urgencia_plazo", urg.getPlazoMaximo());
            Timestamp tsi=new Timestamp(fechaIni.getTime());
            Timestamp tsf=new Timestamp(fechaFin.getTime());
            hm.put("FechaInicio", tsi);
            hm.put("FechaFin", tsf);
            hm.put("RUTA_REPORTE", rutaSubReporte1Jasper);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte5Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte6Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            

            hm.put("RUTA_GRAFICO_ESCALADOS", rutaSubReporte7Jasper);
            hm.put("RUTA_GRAFICO_DEMORADOS", rutaSubReporte8Jasper);
            hm.put("RUTA_GRAFICO_RECATEGORIZADOS", rutaSubReporte9Jasper);
            hm.put("RUTA_RESUMEN_ESCALADOS", rutaSubReporte10Jasper);
            hm.put("RUTA_RESUMEN_RECATEGORIZADOS", rutaSubReporte11Jasper);
            hm.put("RUTA_RESUMEN_DEMORADOS", rutaSubReporte12Jasper);
            hm.put("RUTA_TICKET_DIA", rutaSubReporte13Jasper);
            hm.put("RUTA_TICKET_BIBLIOTECA", rutaSubReporte14Jasper);
            
            
            hm.put("RUTA_GRAFICO_ACTIVOFIJO", rutaSubReporte15Jasper);
            hm.put("RUTA_RESUMEN_ACTIVOFIJO", rutaSubReporte16Jasper);
            hm.put("RUTA_TICKET_URGENCIA", rutaSubReporte17Jasper);
            
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);
            
            //Cerramos la conexion
            con.close();

            arreglo = JasperExportManager.exportReportToPdf(objJPrint);
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteTicketCategoria")
    public byte[] generarReporteTicketCategoria(@WebParam(name = "objCategoria") Categoria catego,@WebParam(name = "fechaIni") Date fechaIni,@WebParam(name = "fechaFin")Date fechaFin) {
        byte[] arreglo = null;
        
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = ReporteTicketCategoria.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath().replace("%20", " ");
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte1Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath().replace("%20", " ");
            
            //Obtener la ruta del subreporte
            String rutaSubReporte2Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta del subreporte2
            String rutaSubReporte3Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath().replace("%20", " ");

            String rutaSubReporte4Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta al archivo
            String rutaSubReporte5Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath().replace("%20", " ");

            String rutaSubReporte6Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte7Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Escalados_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte8Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Demorados_Categoria.jasper").getPath().replace("%20", " ");

            String rutaSubReporte9Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Recategorizados_Categoria.jasper").getPath().replace("%20", " ");

            String rutaSubReporte10Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Escalados_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte11Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Recategorizados_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte12Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Demorados_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte13Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Dia_Categoria.jasper").getPath().replace("%20", " ");

            String rutaSubReporte14Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Biblioteca_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte15Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_ActivoFijo_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte16Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_ActivoFijo_Categoria.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte17Jasper
            = ReporteTicketCategoria.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Urgencia_Categoria.jasper").getPath().replace("%20", " ");
            
            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            
            hm.put("Categoria_id", catego.getCategoriaId());
            hm.put("Categoria_nombre", catego.getNombre());
            hm.put("Categoria_descripcion", catego.getDescripcion());
            Timestamp tsi=new Timestamp(fechaIni.getTime());
            Timestamp tsf=new Timestamp(fechaFin.getTime());
            hm.put("FechaInicio", tsi);
            hm.put("FechaFin", tsf);
            hm.put("RUTA_REPORTE", rutaSubReporte1Jasper);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte5Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte6Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            
            hm.put("RUTA_GRAFICO_ESCALADOS", rutaSubReporte7Jasper);
            hm.put("RUTA_GRAFICO_DEMORADOS", rutaSubReporte8Jasper);
            hm.put("RUTA_GRAFICO_RECATEGORIZADOS", rutaSubReporte9Jasper);
            hm.put("RUTA_RESUMEN_ESCALADOS", rutaSubReporte10Jasper);
            hm.put("RUTA_RESUMEN_RECATEGORIZADOS", rutaSubReporte11Jasper);
            hm.put("RUTA_RESUMEN_DEMORADOS", rutaSubReporte12Jasper);
            hm.put("RUTA_TICKET_DIA", rutaSubReporte13Jasper);
            hm.put("RUTA_TICKET_BIBLIOTECA", rutaSubReporte14Jasper);
            
            
            hm.put("RUTA_GRAFICO_ACTIVOFIJO", rutaSubReporte15Jasper);
            hm.put("RUTA_RESUMEN_ACTIVOFIJO", rutaSubReporte16Jasper);
            hm.put("RUTA_TICKET_URGENCIA", rutaSubReporte17Jasper);
            
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);
            
            //Cerramos la conexion
            con.close();

            arreglo = JasperExportManager.exportReportToPdf(objJPrint);
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteTicketAgente")
    public byte[] generarReporteTicketAgente(@WebParam(name = "objAgente") Agente agente,@WebParam(name = "fechaIni") Date fechaIni,@WebParam(name = "fechaFin")Date fechaFin) {
        byte[] arreglo = null;
        
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = ReporteTicketAgente.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath().replace("%20", " ");
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte1Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath().replace("%20", " ");
            
            //Obtener la ruta del subreporte
            String rutaSubReporte2Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta del subreporte2
            String rutaSubReporte3Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath().replace("%20", " ");

            String rutaSubReporte4Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta al archivo
            String rutaSubReporte5Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath().replace("%20", " ");

            String rutaSubReporte6Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte7Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Escalados_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte8Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Demorados_Agente.jasper").getPath().replace("%20", " ");

            String rutaSubReporte9Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Recategorizados_Agente.jasper").getPath().replace("%20", " ");

            String rutaSubReporte10Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Escalados_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte11Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Recategorizados_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte12Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Demorados_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte13Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Dia_Agente.jasper").getPath().replace("%20", " ");

            String rutaSubReporte14Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Categoria_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte15Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_ActivoFijo_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte16Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_ActivoFijo_Agente.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte17Jasper
            = ReporteTicketAgente.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Urgencia_Agente.jasper").getPath().replace("%20", " ");
            
            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            
            hm.put("Agente_id", agente.getAgenteId());
            hm.put("Agente_nombre", agente.getNombre());
            hm.put("Agente_codigo", agente.getCodigo());
            Timestamp tsi=new Timestamp(fechaIni.getTime());
            Timestamp tsf=new Timestamp(fechaFin.getTime());
            hm.put("FechaInicio", tsi);
            hm.put("FechaFin", tsf);
            hm.put("RUTA_REPORTE", rutaSubReporte1Jasper);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte5Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte6Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            
            hm.put("RUTA_GRAFICO_ESCALADOS", rutaSubReporte7Jasper);
            hm.put("RUTA_GRAFICO_DEMORADOS", rutaSubReporte8Jasper);
            hm.put("RUTA_GRAFICO_RECATEGORIZADOS", rutaSubReporte9Jasper);
            hm.put("RUTA_RESUMEN_ESCALADOS", rutaSubReporte10Jasper);
            hm.put("RUTA_RESUMEN_RECATEGORIZADOS", rutaSubReporte11Jasper);
            hm.put("RUTA_RESUMEN_DEMORADOS", rutaSubReporte12Jasper);
            hm.put("RUTA_TICKET_DIA", rutaSubReporte13Jasper);
            hm.put("RUTA_TICKET_BIBLIOTECA", rutaSubReporte14Jasper);
            
            
            hm.put("RUTA_GRAFICO_ACTIVOFIJO", rutaSubReporte15Jasper);
            hm.put("RUTA_RESUMEN_ACTIVOFIJO", rutaSubReporte16Jasper);
            hm.put("RUTA_TICKET_URGENCIA", rutaSubReporte17Jasper);
            
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);
            
            //Cerramos la conexion
            con.close();

            arreglo = JasperExportManager.exportReportToPdf(objJPrint);
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }   
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteTicketEquipo")
    public byte[] generarReporteTicketEquipo(@WebParam(name = "objEquipo") Equipo equipo,@WebParam(name = "fechaIni") Date fechaIni,@WebParam(name = "fechaFin")Date fechaFin) {
        byte[] arreglo = null;
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = ReporteTicketEquipo.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath().replace("%20", " ");
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte1Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath().replace("%20", " ");
            
            //Obtener la ruta del subreporte
            String rutaSubReporte2Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta del subreporte2
            String rutaSubReporte3Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath().replace("%20", " ");

            String rutaSubReporte4Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath().replace("%20", " ");

            //Obtener la ruta al archivo
            String rutaSubReporte5Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath().replace("%20", " ");

            String rutaSubReporte6Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte7Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Escalados_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte8Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Demorados_Equipo.jasper").getPath().replace("%20", " ");

            String rutaSubReporte9Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Recategorizados_Equipo.jasper").getPath().replace("%20", " ");

            String rutaSubReporte10Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Escalados_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte11Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Recategorizados_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte12Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_Demorados_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte13Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Dia_Equipo.jasper").getPath().replace("%20", " ");

            String rutaSubReporte14Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Categoria_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte15Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_ActivoFijo_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte16Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Resumen_ActivoFijo_Equipo.jasper").getPath().replace("%20", " ");
            
            String rutaSubReporte17Jasper
            = ReporteTicketEquipo.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Grafico_Tickets_Urgencia_Equipo.jasper").getPath().replace("%20", " ");
            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            
            hm.put("Equipo_id", equipo.getEquipoId());
            hm.put("Equipo_nombre", equipo.getNombre());
            hm.put("Equipo_descripcion", equipo.getDescripcion());
            Timestamp tsi=new Timestamp(fechaIni.getTime());
            Timestamp tsf=new Timestamp(fechaFin.getTime());
            hm.put("FechaInicio", tsi);
            hm.put("FechaFin", tsf);
            hm.put("RUTA_REPORTE", rutaSubReporte1Jasper);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte5Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte6Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            

            hm.put("RUTA_GRAFICO_ESCALADOS", rutaSubReporte7Jasper);
            hm.put("RUTA_GRAFICO_DEMORADOS", rutaSubReporte8Jasper);
            hm.put("RUTA_GRAFICO_RECATEGORIZADOS", rutaSubReporte9Jasper);
            hm.put("RUTA_RESUMEN_ESCALADOS", rutaSubReporte10Jasper);
            hm.put("RUTA_RESUMEN_RECATEGORIZADOS", rutaSubReporte11Jasper);
            hm.put("RUTA_RESUMEN_DEMORADOS", rutaSubReporte12Jasper);
            hm.put("RUTA_TICKET_DIA", rutaSubReporte13Jasper);
            hm.put("RUTA_TICKET_CATEGORIA", rutaSubReporte14Jasper);
            
            
            hm.put("RUTA_GRAFICO_ACTIVOFIJO", rutaSubReporte15Jasper);
            hm.put("RUTA_RESUMEN_ACTIVOFIJO", rutaSubReporte16Jasper);
            hm.put("RUTA_TICKET_URGENCIA", rutaSubReporte17Jasper);
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);
            
            //Cerramos la conexion
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(objJPrint);
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
        
}
