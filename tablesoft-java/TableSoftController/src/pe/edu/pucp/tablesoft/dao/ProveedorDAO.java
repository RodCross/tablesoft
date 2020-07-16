/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.model.Proveedor;


public interface ProveedorDAO {
    // Metodos normales
    int insertar(Proveedor proveedor);
    int actualizar(Proveedor proveedor);
    int eliminar(Proveedor proveedor);
    ArrayList<Proveedor> listar();
    ArrayList<Proveedor> listarxNombre(String nombre);
    Proveedor buscar(int proveedorId);
}
