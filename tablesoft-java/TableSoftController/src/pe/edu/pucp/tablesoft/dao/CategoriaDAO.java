/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


public interface CategoriaDAO {
    int insertar(Categoria categoria);                  // Insert y update
    int actualizar(Categoria categoria);                // Solo consideran sus atributos propios (sin lista de tareasPred)
    int eliminar(Categoria categoria);              
    ArrayList<Categoria> listar();                          // Listar
    ArrayList<Categoria> listarxEquipo(Equipo equipo);      // Sí considera la lista de tareasPred y las trae al Java
}
