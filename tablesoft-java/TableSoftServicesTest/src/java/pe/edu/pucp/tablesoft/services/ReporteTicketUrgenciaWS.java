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
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketCategoria;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketUrgencia;

/**
 *
 * @author STEFANO
 */
@WebService(serviceName = "ReporteTicketUrgenciaWS")
public class ReporteTicketUrgenciaWS {

    /**
     * This is a sample web service operation
     */
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
}
