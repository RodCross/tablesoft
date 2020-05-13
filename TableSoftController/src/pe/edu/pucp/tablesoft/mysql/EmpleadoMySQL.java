/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.tablesoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBManager;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.model.Empleado;


public class EmpleadoMySQL implements EmpleadoDAO{

    @Override
    public int insertar(Empleado empleado) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL insertar_empleado(?,?,?,?,?)}");
            
            cs.registerOutParameter(1, java.sql.Types.INTEGER);
            cs.setString(2, empleado.getCodigo());
            cs.setString(3, empleado.getDni());
            cs.setString(4, empleado.getNombre());
            cs.setString(5, empleado.getUsuarioEmail());
            cs.executeUpdate();
            
            res = cs.getInt(1);
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int actualizar(Empleado empleado) {
        // No se puede actualizar ningun campo de empleado
        throw new UnsupportedOperationException("No se puede actualizar.");
    }

    @Override
    public int eliminar(int idEmpleado) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall("{CALL eliminar_empleado(?)}");
            
            cs.setInt(1, idEmpleado);
            
            cs.executeUpdate();
            res = 1;
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public ArrayList<Empleado> listar() {
        ArrayList<Empleado> empleados = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                DBManager.user, DBManager.password);
            //Ejecutar una sentencia
            CallableStatement cs = con.prepareCall("{CALL listar_empleado()}");
            ResultSet rs=cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()) {
                Empleado empleado = new Empleado();
                empleado.setEmpleadoId(rs.getInt("empleado_id"));
                empleado.setCodigo(rs.getString("codigo"));
                empleado.setDni(rs.getString("dni"));
                empleado.setNombre(rs.getString("nombre"));
                empleado.setUsuarioEmail(rs.getString("usuario_email"));
                empleados.add(empleado);
            }
            //cerrar conexion
            con.close();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        //Devolviendo los empleados
        return empleados;
    }

}
