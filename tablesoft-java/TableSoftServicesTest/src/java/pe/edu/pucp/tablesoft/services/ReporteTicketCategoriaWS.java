/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
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
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.servlets.ReporteTicketCategoria;
import java.util.Date;
/**
 *
 * @author STEFANO
 */
@WebService(serviceName = "ReporteTicketCategoriaWS")
public class ReporteTicketCategoriaWS {

    /**
     * This is a sample web service operation
     */
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
