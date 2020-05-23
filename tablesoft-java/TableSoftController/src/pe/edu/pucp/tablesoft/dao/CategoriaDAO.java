/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Categoria;


public interface CategoriaDAO {
    int insertar(Categoria categoria);
    int actualizar(Categoria categoria);
    int eliminar(int categoriaId);
    ArrayList<Categoria> listar();
}
