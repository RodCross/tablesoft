/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Agente;


public interface AgenteDAO {
    int insertar(Agente agente);
    int actualizar(Agente agente);
    int eliminar(int idAgente);
    ArrayList<Agente> listar();
}
