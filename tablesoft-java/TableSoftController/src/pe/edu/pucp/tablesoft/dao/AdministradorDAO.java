/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Administrador;


public interface AdministradorDAO {
    int insertar(Administrador administrador);
    int actualizar(Administrador administrador);
    int eliminar(int idAdministrador);
    ArrayList<Administrador> listar();
}
