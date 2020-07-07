/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Urgencia;


public interface UrgenciaDAO {
    // Metodos normales
    int insertar(Urgencia urgencia);
    int actualizar(Urgencia urgencia);
    int eliminar(Urgencia urgencia);
    ArrayList<Urgencia> listar();
    Urgencia buscar(int urgenciaId);
    ArrayList<Urgencia> listarxNombre(String nombre);
}
