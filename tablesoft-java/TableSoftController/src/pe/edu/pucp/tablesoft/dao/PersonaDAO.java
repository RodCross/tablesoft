/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import pe.edu.pucp.tablesoft.model.Persona;


public interface PersonaDAO {
    Persona verificarPersona(String email,String password);
    int verificarCorreo(String email);
    int actualizarPass(String email, String password);
    Persona buscarxEmail(String email);
}
