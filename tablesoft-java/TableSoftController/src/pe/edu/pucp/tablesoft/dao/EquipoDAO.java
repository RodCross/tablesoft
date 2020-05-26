/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Equipo;


public interface EquipoDAO {
    int insertar(Equipo equipo);    // Insert y update solo consideran sus atributos propios
    int actualizar(Equipo equipo);  
    int eliminar(Equipo equipo);     
    ArrayList<Equipo> listar();     // Solo lista los equipos con su lista de Categorias
                                    // Usa CategoriaDAO.listarxEquipo(Equipo) para llenar la lista de Categorias
                                    // No llena su lista de agentes
    Equipo buscar(int equipoId);
}
