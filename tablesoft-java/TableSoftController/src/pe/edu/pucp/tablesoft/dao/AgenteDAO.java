/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Equipo;


public interface AgenteDAO {
    int insertar(Agente agente);                        // Insert/update
    int actualizar(Agente agente);                      // Solo consideran los atributos propiso del Agente/Persona
                                                        // Rol: Solo interesa su id
    int eliminar(Agente agente);                        // Cambia a inactivo                         
    ArrayList<Agente> listar();                         // Lista todos los agentes solo sin su lista de tickets
    ArrayList<Agente> listarxEquipo(Equipo equipo);     // Lista solo los agentes de ese equipo
    Agente buscar(int agenteId);                        // Devuelve un agente como en listar
    Agente buscarxCodigo(String codigo);
}
