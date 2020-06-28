/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Equipo;


public interface EquipoDAO {
    int insertar(Equipo equipo);    // Insert y update solo consideran sus atributos propios
    int actualizar(Equipo equipo);  
    int eliminar(Equipo equipo);     
    ArrayList<Equipo> listar();     // Solo lista los equipos con sus atributos
                                    // No llena su lista de agentes ni lista de categorias
    ArrayList<Equipo> listarxNombre(String nombre);
    Equipo buscar(int equipoId);
    int agregarCategoria(Equipo equipo, Categoria categoria);
    int quitarCategoria(Equipo equipo, Categoria categoria);
}
