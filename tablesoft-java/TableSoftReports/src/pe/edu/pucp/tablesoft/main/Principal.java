/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.main;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
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
            
        con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
        
        
        //Obtener la ruta al archivo
        String rutaReporteJasper
        = Principal.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Reporte_Lista_Cambios_Estado.jasper").getPath();
        
        //Obtener la ruta del subreporte
        String rutaSubReporteJasper
        = Principal.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Lista_Comentarios_Ticket.jasper").getPath();
        
        //Obtener la ruta del subreporte2
        String rutaSubReporte2Jasper
        = Principal.class.getResource(
       "/pe/edu/pucp/tablesoft/reports/Lista_Tareas_Ticket.jasper").getPath();
        
        //Objecto JasperReport
        JasperReport objJR = 
                (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporteJasper);
        
        HashMap hm = new HashMap();
        /*
        llenar hash map pi
        */
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
