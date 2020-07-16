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
import pe.edu.pucp.tablesoft.config.DBManager;

/**
 *
 * @author STEFANO
 */
public class ReporteTickets extends HttpServlet {

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
            
            hm.put("Ticket_id", 1);
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
            
            
            JasperExportManager.exportReportToPdfStream(objJPrint, response.getOutputStream());
        }
        catch(Exception ex){
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
