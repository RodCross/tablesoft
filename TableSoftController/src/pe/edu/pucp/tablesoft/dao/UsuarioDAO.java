/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Usuario;

/**
 *
 * @author STEFANO
 */
public interface UsuarioDAO {
    int insertar(Usuario usuario);
    int actualizar(Usuario usuario);
    int eliminar(String idUsuario);
    ArrayList<Usuario> listar();
}
