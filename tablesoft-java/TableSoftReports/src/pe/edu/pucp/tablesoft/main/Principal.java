package pe.edu.pucp.tablesoft.main;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.swing.ImageIcon;

import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import net.sf.jasperreports.view.JasperViewer;

import pe.edu.pucp.tablesoft.config.DBManager;


public class Principal {
    public static void main(String[] args) {
        byte[] arreglo = null;
        Connection con;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String rutaImagen
                = Principal.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Seal_of_Pontifical_Catholic_University_of_Peru.jpg").getPath();
        ImageIcon icon = new ImageIcon(rutaImagen);
        java.awt.Image imagenReporte = icon.getImage();

            String rutaReporteJasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/ReporteTicket.jasper").getPath();

            //Obtener la ruta del subreporte
            String rutaSubReporteJasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath();

            //Obtener la ruta del subreporte2
            String rutaSubReporte2Jasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Ticket.jasper").getPath();

            String rutaSubReporte3Jasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath();

            //Obtener la ruta al archivo
            String rutaSubReporte4Jasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath();

            String rutaSubReporte5Jasper
            = Principal.class.getResource(
           "/pe/edu/pucp/tablesoft/reports/Lista_Transferencia_Externa.jasper").getPath();

            //Objecto JasperReport
            JasperReport objJR = 
                    (JasperReport)
                    JRLoader.loadObjectFromFile(rutaReporteJasper);

            HashMap hm = new HashMap();
            /*
            llenar hash map pi
            */
            hm.put("Ticket_id", 1);
            hm.put("RUTA_LISTA_COMENTARIOS", rutaSubReporteJasper);
            hm.put("RUTA_LISTA_TRANS_TICKET", rutaSubReporte2Jasper);
            hm.put("RUTA_LISTA_TAREAS", rutaSubReporte3Jasper);
            hm.put("RUTA_LISTA_CAMBIOS", rutaSubReporte4Jasper);
            hm.put("RUTA_LISTA_TRANS_EXTERNA", rutaSubReporte5Jasper);
            hm.put("IMAGEN_REPORTE", imagenReporte);
            //Object JasperPrint
            JasperPrint objJPrint =
            JasperFillManager.fillReport(objJR,hm,con);

            //Cerramos la conexion
            con.close();

            JasperViewer jw = new JasperViewer(objJPrint);
            jw.setVisible(true);
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
