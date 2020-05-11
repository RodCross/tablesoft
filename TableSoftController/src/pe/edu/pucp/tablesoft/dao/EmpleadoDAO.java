/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Empleado;


public interface EmpleadoDAO {
    int insertar(Empleado empleado);
    int actualizar(Empleado empleado);
    int eliminar(int idEmpleado);
    ArrayList<Empleado> listar();
}
