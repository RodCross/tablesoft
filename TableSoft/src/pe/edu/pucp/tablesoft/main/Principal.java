/* Este es un archivo de prueba para verificar
 * que todas las clases y sus métodos funciones
 * correctamente y se conecten exitosamente a la
 * base de datos MySQL.
 */

package pe.edu.pucp.tablesoft.main;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.model.Administrador;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.Proveedor;
import pe.edu.pucp.tablesoft.model.Supervisor;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.mysql.AgenteMySQL;
import pe.edu.pucp.tablesoft.mysql.CategoriaMySQL;
import pe.edu.pucp.tablesoft.mysql.EmpleadoMySQL;
import pe.edu.pucp.tablesoft.mysql.EquipoMySQL;
import pe.edu.pucp.tablesoft.mysql.ProveedorMySQL;
import pe.edu.pucp.tablesoft.mysql.TicketMySQL;
import pe.edu.pucp.tablesoft.mysql.UrgenciaMySQL;

public class Principal {
    public static void main(String[] args) {
        
        // DAO
        UrgenciaDAO urgenciaDao = new UrgenciaMySQL();
        CategoriaDAO categoriaDao = new CategoriaMySQL();
        ProveedorDAO proveedorDao = new ProveedorMySQL();
        EquipoDAO equipoDao = new EquipoMySQL();
        AgenteDAO agenteDao = new AgenteMySQL();
        EmpleadoDAO empleadoDao =  new EmpleadoMySQL();
        TicketDAO ticketDao = new TicketMySQL();
        
        
        // EQUIPOS
        // Crear equipos
        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();
        
        // Insertar equipos
        equipoDao.insertar(equipo1);
        equipoDao.insertar(equipo2);
        
        
        // URGENCIAS    
        // Crear urgencias
        Urgencia urgencia1 = new Urgencia("EMERGENCIA", 2);
        Urgencia urgencia2 = new Urgencia("INCIDENTE", 24);
        Urgencia urgencia3 = new Urgencia("SOLICITUD", 72);
        Urgencia urgencia4 = new Urgencia("CONSULTA", 72);
        
        // Insertar urgencias
        urgenciaDao.insertar(urgencia1);
        urgenciaDao.insertar(urgencia2);
        urgenciaDao.insertar(urgencia3);
        urgenciaDao.insertar(urgencia4);
        
        // Listar urgencias
        ArrayList<Urgencia> urgencias = urgenciaDao.listar();
        System.out.println("Urgencias:\n");
        for (Urgencia u : urgencias) {
            System.out.println(u.mostrarDatos());
        }
        
        
        // CATEGORIAS     
        // Crear categorias
        Categoria categoria1 = new Categoria("BASES DE DATOS EN LINEA");
        Categoria categoria2 = new Categoria("EQUIPOS DE AUTOPRESTAMO");
        Categoria categoria3 = new Categoria("EQUIPOS DE INVENTARIO");
        Categoria categoria4 = new Categoria("PAGINA WEB DEL SB");
        Categoria categoria5 = new Categoria("RED INFORMATICA");
        Categoria categoria6 = new Categoria("REPOSITORIO DE TESIS PUCP");
        Categoria categoria7 = new Categoria("SOFTWARE DE OFICINA");
        Categoria categoria8 = new Categoria("TELEFONO IP");
        
        // Insertar categorias
        categoriaDao.insertar(categoria1);
        categoriaDao.insertar(categoria2);
        categoriaDao.insertar(categoria3);
        categoriaDao.insertar(categoria4);
        categoriaDao.insertar(categoria5);
        categoriaDao.insertar(categoria6);
        categoriaDao.insertar(categoria7);
        categoriaDao.insertar(categoria8);
        
        // Enlazar cada categoria con un equipo en especifico
        categoria1.setEquipo(equipo1);
        categoria2.setEquipo(equipo1);
        categoria3.setEquipo(equipo2);
        categoria4.setEquipo(equipo1);
        categoria5.setEquipo(equipo2);
        categoria6.setEquipo(equipo2);
        categoria7.setEquipo(equipo2);
        categoria8.setEquipo(equipo1);
        
        // Actualizar categorias
        categoriaDao.actualizar(categoria1);
        categoriaDao.actualizar(categoria2);
        categoriaDao.actualizar(categoria3);
        categoriaDao.actualizar(categoria4);
        categoriaDao.actualizar(categoria5);
        categoriaDao.actualizar(categoria6);
        categoriaDao.actualizar(categoria7);
        categoriaDao.actualizar(categoria8);
        
        // Listar categorias
        ArrayList<Categoria> categorias = categoriaDao.listar();
        System.out.println("\nCategorias:\n");
        for (Categoria c : categorias) {
            System.out.println(c.mostrarDatos());
        }
        
        
        // PROVEEDOR
        // Crear proveedores
        Proveedor proveedor1 = new Proveedor("MIKCORP S.A.");
        Proveedor proveedor2 = new Proveedor("FERCORP S.A.");
        Proveedor proveedor3 = new Proveedor("RODCORP S.A.");
        Proveedor proveedor4 = new Proveedor("CESCORP S.A.");
        Proveedor proveedor5 = new Proveedor("TEFCORP S.A.");
        
        // Insertar proveedores
        proveedorDao.insertar(proveedor1);
        proveedorDao.insertar(proveedor2);
        proveedorDao.insertar(proveedor3);
        proveedorDao.insertar(proveedor4);
        proveedorDao.insertar(proveedor5);
        
        // Listar proveedores
        ArrayList<Proveedor> proveedores = proveedorDao.listar();
        System.out.println("\nProveedores:\n");
        for (Proveedor p : proveedores) {
            System.out.println(p.mostrarDatos());
        }
        
        
        // AGENTE
        // Crear agentes (pueden tambien ser supervisores o administradores)
        Agente agente1 = new Agente("20167474", "70221842", "ROLDAN HUAYLLASCO, STEFANO", "a20167474@pucp.edu.pe", "srh@pucp.edu.pe");
        Agente agente2 = new Agente("20170824", "77456687", "VERASTEGUI SANCHEZ, FERNANDO GUILLERMO", "f.verastegui@pucp.edu.pe", "fgvs@pucp.edu.pe");
        Agente agente3 = new Agente("20170910", "74488960", "ROSALES KAM, JUAN FRANCISCO", "juan.rosales@pucp.edu.pe", "jfrk@pucp.edu.pe");
        Agente agente4 = new Agente("20170569", "76947569", "CARBAJAL SERRANO, CESAR ADRIAN", "a20170569@pucp.edu.pe", "cacs@pucp.edu.pe");
        Agente supervisor1 = new Supervisor("20171051", "71927484", "SILVA LUNA, MIGUEL ANTERO", "a20171051@pucp.edu.pe", "masl@pucp.edu.pe");
        Agente supervisor2 = new Supervisor("20170516", "74484890", "CRUZ LEAN, RODRIGO ALONSO", "racruz@pucp.edu.pe", "racl@pucp.edu.pe");
        Agente administrador = new Administrador("20112728", "45687889", "PAZ ESPINOZA, FREDDY ALBERTO", "fpaz@pucp.edu.pe", "fape@pucp.edu.pe");
        
        // Insertar agentes
        agenteDao.insertar(agente1);
        agenteDao.insertar(agente2);
        agenteDao.insertar(agente3);
        agenteDao.insertar(agente4);
        agenteDao.insertar(supervisor1);
        agenteDao.insertar(supervisor2);
        agenteDao.insertar(administrador);
        
        // Asignar equipos a los agentes
        agente1.setEquipo(equipo1);
        agente2.setEquipo(equipo1);
        supervisor1.setEquipo(equipo1);
        agente3.setEquipo(equipo2);
        agente4.setEquipo(equipo2);
        supervisor2.setEquipo(equipo2);
        administrador.setEquipo(equipo1);
        
        // Actualizar agentes con nuevos valores
        agenteDao.actualizar(agente1);
        agenteDao.actualizar(agente2);
        agenteDao.actualizar(agente3);
        agenteDao.actualizar(agente4);
        agenteDao.actualizar(supervisor1);
        agenteDao.actualizar(supervisor2);
        agenteDao.actualizar(administrador);
        
        // Listar agentes
        ArrayList<Agente> agentes = agenteDao.listar();
        System.out.println("\nAgentes:\n");
        for (Agente a : agentes) {
            System.out.println(a.mostrarDatos());
        }
        
        
        // EMPLEADO
        // Crear empleados
        Empleado empleado1 = new Empleado("20175657", "79805979", "GELDRES QUIROZ, JUAN AYMAR", "aymar.geldres@pucp.edu.pe");
        Empleado empleado2 = new Empleado("20176969", "70487898", "CERVANTES DIAZ, LEONARDO FABRIZIO", "a20176969@pucp.edu.pe");
        Empleado empleado3 = new Empleado("20174200", "78979999", "CANASA MAYTA, PAUL RODRIGO", "paul.canasa@pucp.edu.pe");
        
        // Insertar empleados
        empleadoDao.insertar(empleado1);
        empleadoDao.insertar(empleado2);
        empleadoDao.insertar(empleado3);
        
        // Listar empleados
        ArrayList<Empleado> empleados = empleadoDao.listar();
        System.out.println("\nEmpleados:\n");
        for (Empleado e : empleados) {
            System.out.println(e.mostrarDatos());
        }
        
        
        // TICKET
        // Crear tickets
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");
        LocalDateTime fecha1 = LocalDateTime.parse("14-05-2020 18:15:30", formatter);
        LocalDateTime fecha2 = LocalDateTime.parse("15-05-2020 08:39:02", formatter);
        LocalDateTime fecha3 = LocalDateTime.parse("13-05-2020 16:09:47", formatter);
        LocalDateTime fechaPrim = LocalDateTime.parse("15-05-2020 10:01:58", formatter);
        LocalDateTime fechaCierre = LocalDateTime.parse("15-05-2020 11:05:00", formatter);
        
        Ticket ticket1 = new Ticket("ACTIVO", fecha1, urgencia2, categoria3);
        Ticket ticket2 = new Ticket("ACTIVO", fecha2, urgencia1, categoria4);
        Ticket ticket3 = new Ticket("ACTIVO", fecha3, urgencia3, categoria7);
        
        // Insertar tickets
        ticketDao.insertar(ticket1);
        ticketDao.insertar(ticket2);
        ticketDao.insertar(ticket3);
        
        // Asignar agentes
        ticket1.setAgente(agente1);
        ticket2.setAgente(agente2);
        ticket3.setAgente(agente4);
        
        // Asignar proveedores
        ticket1.setProveedor(proveedor1);
        ticket2.setProveedor(proveedor3);
        ticket3.setProveedor(proveedor4);
        
        // Asignar empleados
        ticket1.setEmpleado(empleado1);
        ticket2.setEmpleado(empleado2);
        ticket3.setEmpleado(empleado3);
       
        // Asignar algunos campos faltantes (no todos son necesarios)
        ticket1.setInfoAdicional("El inventario se encuentra en mal estado.");
        ticket2.setInfoAdicional("URGENTE! No funciona la pagina web del SB...");
        ticket3.setInfoAdicional("Problemas con el software");
        ticket2.setAlumnoEmail("alumno@gmail.com");
        ticket2.setFechaPrimeraRespuesta(fechaPrim);
        ticket2.setFechaCierre(fechaCierre);
        ticket1.setActivoFijoId(201500018);
        
        
        // Actualizar con nuevos valores
        ticketDao.actualizar(ticket1);
        ticketDao.actualizar(ticket2);
        ticketDao.actualizar(ticket3);
        
        // Listar tickets
        ArrayList<Ticket> tickets = ticketDao.listar();
        System.out.println("\nTickets\n");
        for (Ticket t : tickets) {
            System.out.println(t.mostrarDatos());
        }
        
        /* Los metodos para eliminar se pueden probar luego de ver el comportamiento
         * de los metodos para insertar, actualizar y listar dentro de la base de datos.
         */
    }
}