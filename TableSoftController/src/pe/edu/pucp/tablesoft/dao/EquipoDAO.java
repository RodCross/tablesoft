/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Equipo;


public interface EquipoDAO {
    int insertar(Equipo equipo);
    int actualizar(Equipo equipo);
    int eliminar(int idEquipo);
    ArrayList<Equipo> listar();
}
