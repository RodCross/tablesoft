/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Supervisor;


public interface SupervisorDAO {
    int insertar(Supervisor supervisor);
    int actualizar(Supervisor supervisor);
    int eliminar(int idSupervisor);
    ArrayList<Supervisor> listar();
}
