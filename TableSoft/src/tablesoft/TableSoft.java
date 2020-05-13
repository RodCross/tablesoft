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
        
        Urgencia urgencia = new Urgencia("CONSULTA", 72);
        int result;
        result = daoUrgencia.insertar(urgencia);
        if(result==0)
            System.out.println("Ha ocurrido un error\n");
        else{
            System.out.println("Se ha registrado de manera exitosa\n");
            System.out.println("El id generado para el empleado es " + result);
            
        }
            
    }
    
}
