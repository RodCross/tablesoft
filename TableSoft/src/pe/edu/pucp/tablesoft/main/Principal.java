package pe.edu.pucp.tablesoft.main;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.mysql.UrgenciaMySQL;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
/**
 *
 * @author migue
 */
public class Principal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
        ArrayList<Urgencia> urgencias = new ArrayList<>();
        //Urgencia urgencia = new Urgencia(5, "ELIMINABLE", 89);
        int codigo = 5;
        int result;
        
        
        
        
           
        //result = daoUrgencia.insertar(urgencia);
        //result = daoUrgencia.actualizar(urgencia);
        //result = daoUrgencia.eliminar(codigo);   
        urgencias = daoUrgencia.listar();
        
        
        /*if(result==0)
            System.out.println("Ha ocurrido un error\n");
        else{
            System.out.println("Se ha registrado de manera exitosa\n");
            System.out.println("El id generado para el empleado es " + result);
            
        }*/
        
        /*if(result==0)
            System.out.println("Ha ocurrido un error\n");
        else{
            System.out.println("Se ha actualizado de manera exitosa\n");            
        }*/
         
        /*if(result==0)
            System.out.println("Ha ocurrido un error\n");
        else{   
            System.out.println("Se ha eliminado de manera exitosa\n");            
        }*/
        
        urgencias = daoUrgencia.listar();
        for (Urgencia u : urgencias)
            System.out.println(u.mostrarDatosUrgencia());
        
        
        
    }
    
}
