/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Timestamp;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import net.sf.jasperreports.view.JasperViewer;
import pe.edu.pucp.tablesoft.config.DBManager;

/**
 *
 * @author STEFANO
 */
public class ReporteTicketCategoria extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
            
            hm.put("Categoria_id", 1);
            hm.put("Categoria_nombre", "Bases");
            hm.put("Categoria_descripcion", "hol");
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");
            LocalDateTime fechaIni = LocalDateTime.parse("30-06-2020 12:30:55", formatter);
            LocalDateTime fechaFin = LocalDateTime.parse("06-07-2020 12:30:55", formatter);
            hm.put("FechaInicio", Timestamp.valueOf(fechaIni));
            hm.put("FechaFin", Timestamp.valueOf(fechaFin));
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

            JasperExportManager.exportReportToPdfStream(objJPrint, response.getOutputStream());
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
