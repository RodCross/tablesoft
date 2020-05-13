package tablesoft;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.mysql.UrgenciaMySQL;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
/**
 *
 * @author migue
 */
public class TableSoft {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        UrgenciaDAO daoUrgencia = new UrgenciaMySQL();
        
        Urgencia urgencia = new Urgencia(5, "ELIMINABLE", 89);
        int codigo = 5;
        int result;
        
        result = daoUrgencia.eliminar(codigo);   
        //result = daoUrgencia.actualizar(urgencia);   
        //result = daoUrgencia.insertar(urgencia);
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
         
        if(result==0)
            System.out.println("Ha ocurrido un error\n");
        else{
            System.out.println("Se ha eliminado de manera exitosa\n");            
        }
    }
    
}
