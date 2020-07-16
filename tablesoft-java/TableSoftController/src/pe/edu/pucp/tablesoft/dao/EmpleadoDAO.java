/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Biblioteca;
import pe.edu.pucp.tablesoft.model.Empleado;


public interface EmpleadoDAO {
    int insertar(Empleado empleado);                // Insert/update
    int actualizar(Empleado empleado);              // Solo no consideran la lista de tickets
                                                    // Biblioteca: solo interesa su id
    int eliminar(Empleado empleado);                // Cambia a inactivo               
    ArrayList<Empleado> listar();                                   // Listar
    ArrayList<Empleado> listarxBiblioteca(Biblioteca biblioteca);   // Solo no considera la lista de tickets
    ArrayList<Empleado> listarxNombre(String nombre);
    Empleado buscar(int empleadoId);
    Empleado buscarxCodigo(String codigo);
}
