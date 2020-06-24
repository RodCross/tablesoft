/* Este es un archivo de prueba para verificar
 * que todas las clases y sus métodos funciones
 * correctamente y se conecten exitosamente a la
 * base de datos MySQL.
 */

package pe.edu.pucp.tablesoft.main;

import java.util.ArrayList;
import pe.edu.pucp.tablesoft.config.DBController;
import pe.edu.pucp.tablesoft.dao.ActivoFijoDAO;
import pe.edu.pucp.tablesoft.dao.AgenteDAO;
import pe.edu.pucp.tablesoft.dao.BibliotecaDAO;
import pe.edu.pucp.tablesoft.dao.CategoriaDAO;
import pe.edu.pucp.tablesoft.dao.ComentarioDAO;
import pe.edu.pucp.tablesoft.dao.EmpleadoDAO;
import pe.edu.pucp.tablesoft.dao.EquipoDAO;
import pe.edu.pucp.tablesoft.dao.EstadoTicketDAO;
import pe.edu.pucp.tablesoft.dao.PersonaDAO;
import pe.edu.pucp.tablesoft.dao.ProveedorDAO;
import pe.edu.pucp.tablesoft.dao.RolDAO;
import pe.edu.pucp.tablesoft.dao.TareaPredeterminadaDAO;
import pe.edu.pucp.tablesoft.dao.TicketDAO;
import pe.edu.pucp.tablesoft.dao.UrgenciaDAO;
import pe.edu.pucp.tablesoft.model.ActivoFijo;
import pe.edu.pucp.tablesoft.model.Agente;
import pe.edu.pucp.tablesoft.model.Biblioteca;
import pe.edu.pucp.tablesoft.model.Categoria;
import pe.edu.pucp.tablesoft.model.Ciudad;
import pe.edu.pucp.tablesoft.model.Comentario;
import pe.edu.pucp.tablesoft.model.Empleado;
import pe.edu.pucp.tablesoft.model.Equipo;
import pe.edu.pucp.tablesoft.model.EstadoTicket;
import pe.edu.pucp.tablesoft.model.Proveedor;
import pe.edu.pucp.tablesoft.model.Rol;
import pe.edu.pucp.tablesoft.model.TareaPredeterminada;
import pe.edu.pucp.tablesoft.model.Ticket;
import pe.edu.pucp.tablesoft.model.Urgencia;
import pe.edu.pucp.tablesoft.mysql.ActivoFijoMySQL;
import pe.edu.pucp.tablesoft.mysql.AgenteMySQL;
import pe.edu.pucp.tablesoft.mysql.BibliotecaMySQL;
import pe.edu.pucp.tablesoft.mysql.CategoriaMySQL;
import pe.edu.pucp.tablesoft.mysql.ComentarioMySQL;
import pe.edu.pucp.tablesoft.mysql.EmpleadoMySQL;
import pe.edu.pucp.tablesoft.mysql.EquipoMySQL;
import pe.edu.pucp.tablesoft.mysql.EstadoTicketMySQL;
import pe.edu.pucp.tablesoft.mysql.PersonaMySQL;
import pe.edu.pucp.tablesoft.mysql.ProveedorMySQL;
import pe.edu.pucp.tablesoft.mysql.RolMySQL;
import pe.edu.pucp.tablesoft.mysql.TareaPredeterminadaMySQL;
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
        RolDAO rolDao = new RolMySQL();
        BibliotecaDAO bibliotecaDao = new BibliotecaMySQL();
        EstadoTicketDAO estadoTicketDao = new EstadoTicketMySQL();
        ComentarioDAO comentarioDao = new ComentarioMySQL();
        ActivoFijoDAO activoFijoDao = new ActivoFijoMySQL();
        TareaPredeterminadaDAO tareaPredeterminadaDao = new TareaPredeterminadaMySQL();
        PersonaDAO personaDao=new PersonaMySQL();
        
//        // EQUIPOS
//        // Crear equipos
        Equipo equipo1 = new Equipo("Equipo BD","Equipo especializado en BD");
        Equipo equipo2 = new Equipo("Equipo Equipos","Equipo especializado en equipos electronicos");
//        
//        // Insertar equipos
//        equipoDao.insertar(equipo1);
//        equipoDao.insertar(equipo2);
//        
//        // Listar equipos
//        ArrayList<Equipo> equipos = equipoDao.listar();
//        System.out.println("Equipos:\n");
//        for(Equipo e : equipos){
//            System.out.println(e.mostrarDatos());
//        }
//        
//        
//        // URGENCIAS    
//        // Crear urgencias
//        Urgencia urgencia1 = new Urgencia("EMERGENCIA", 2);
//        Urgencia urgencia2 = new Urgencia("INCIDENTE", 24);
//        Urgencia urgencia3 = new Urgencia("CONSULTA", 72);
//        
//        // Insertar urgencias
//        urgenciaDao.insertar(urgencia1);
//        urgenciaDao.insertar(urgencia2);
//        urgenciaDao.insertar(urgencia3);
//        
//        // Listar urgencias
//        ArrayList<Urgencia> urgencias = urgenciaDao.listar();
//        System.out.println("\nUrgencias:\n");
//        for (Urgencia u : urgencias) {
//            System.out.println(u.mostrarDatos());
//        }
//
//        
//        // CATEGORIAS     
//        // Crear categorias
//        Categoria categoria1 = new Categoria("BASES DE DATOS EN LINEA", "Sobre bases de datos en Internet");
//        Categoria categoria2 = new Categoria("EQUIPOS DE AUTOPRESTAMO", "Sobre el funcionamiento de los equipos de autoprestamo de las bibliotecas");
//        Categoria categoria3 = new Categoria("EQUIPOS DE INVENTARIO", "Sobre los equipos de inventario");
//        
//        // Tareas predeterminadas para categoria1
//        TareaPredeterminada tareaPred1 = new TareaPredeterminada("Revisar la conexion a internet");
//        TareaPredeterminada tareaPred2 = new TareaPredeterminada("Verificar los permisos del usuario");
//        
//        // Insertar categorias
//        categoriaDao.insertar(categoria1);
//        categoriaDao.insertar(categoria2);
//        categoriaDao.insertar(categoria3);
//        
//        // Insertar tareas predeterminadas
//        tareaPredeterminadaDao.insertar(tareaPred1, categoria1);
//        tareaPredeterminadaDao.insertar(tareaPred2, categoria1);
//        
//        // Enlazar cada equipo con categorias
//        equipoDao.agregarCategoria(equipo1, categoria1);
//        equipoDao.agregarCategoria(equipo1, categoria2);
//        equipoDao.agregarCategoria(equipo2, categoria3);
//        
//        // Listar categorias
//        ArrayList<Categoria> categorias = categoriaDao.listar();
//        System.out.println("\nCategorias:\n");
//        for(Categoria c: categorias){
//            System.out.println(c.mostrarDatos());
//            for(TareaPredeterminada t: c.getTareasPredeterminadas()){
//                System.out.println("\t- " + t.getDescripcion() + " - " + t.getFechaCreacion().toString());
//            }
//        }
//        
//        // PROVEEDOR
//        // Crear proveedores
//        
//        Proveedor proveedor1 = new Proveedor("34567890120","MIKCORP SA", "Calle Los Alamos 213","1239", "mikcorp@mail.com",new Ciudad(1));
//        Proveedor proveedor2 = new Proveedor("12345678912","FERCORP S.A.","Av Javier Prado 2193","6798","fercord@mail.com", new Ciudad(2));
//        
//        // Insertar proveedores
//        proveedorDao.insertar(proveedor1);
//        proveedorDao.insertar(proveedor2);
//        
//        // Listar proveedores
//        ArrayList<Proveedor> proveedores = proveedorDao.listar();
//        System.out.println("\nProveedores:\n");
//        for (Proveedor p : proveedores) {
//            System.out.println(p.mostrarDatos());
//        }
//
//        
        // ROL
        Rol rol1 = new Rol("AGENTE", "AGENTE NORMAL");
        Rol rol2 = new Rol("SUPERVISOR", "LIDER DE UN EQUIPO");
        rol1.setRolId(1);
        equipo2.setEquipoId(1);
//
//        // Insertar roles
//        rolDao.insertar(rol1);
//        rolDao.insertar(rol2);
//        
//        // Listar roles
//        ArrayList <Rol> roles = rolDao.listar();
//        System.out.println("\nRoles:\n");
//        for (Rol r : roles) {
//            System.out.println(r.mostrarDatos());
//        }
//        
//        // AGENTE
//        Agente agente1 = new Agente("srh@pucp.edu.pe", equipo1, rol1, "20167474", "70221842", "Stefano", "Roldan", "Huayllasco",
//                "Calle Los Cedros 1231", "1231", "abcd1234", "a20167474@pucp.edu.pe");
//        Agente agente2 = new Agente("fgvs@pucp.edu.pe", equipo1, rol1, "20160074", "77456687", "Fernando", "Verastegui", "Sanchez",
//                "Calle Los Prietos 1231", "1532", "abcd1234", "f.verastegui@pucp.edu.pe");
//        Agente agente3 = new Agente("jfrk@pucp.edu.pe", equipo2, rol2, "20170910", "74488960", "Juan Francisco", "Rosales", "Kam",
//                "Calle Los Nogales 1131", "1233", "abcd1234", "juan.rosales@pucp.edu.pe");
        Agente agente4 = new Agente("cacs@pucp.edu.pe", equipo2, rol1, "20145469", "76947569", "Carlos", "Carbajal", "Serrano",
                "Calle Los Arboles 1431", "9913", "abcd1234", "a20170569@pucp.edu.pe");
//        
//   
//        // Insertar agentes
//        agenteDao.insertar(agente1);
//        agenteDao.insertar(agente2);
//        agenteDao.insertar(agente3);
        agenteDao.insertar(agente4);
//        
//        // Asignar equipos a los agentes
//        agente1.setEquipo(equipo1);
//        agente2.setEquipo(equipo1);
//        agente3.setEquipo(equipo2);
//        agente4.setEquipo(equipo2);
//        
//        // Actualizar agentes con nuevos valores
//        agenteDao.actualizar(agente1);
//        agenteDao.actualizar(agente2);
//        agenteDao.actualizar(agente3);
//        agenteDao.actualizar(agente4);
//        
//        
//        // Listar agentes
//        ArrayList<Agente> agentes = agenteDao.listar();
//        System.out.println("\nAgentes:\n");
//        for (Agente a : agentes) {
//            System.out.println(a.mostrarDatos()+ " - " + a.getRol().getNombre() + " - " + a.getEquipo().getNombre()) ;
//        }
//        
//        // BIBLIOTECAS
//        Biblioteca bib1 = new Biblioteca("COMPLEJO DE INNOVACIÓN ACADÉMICA", "CIA");
//        Biblioteca bib2 = new Biblioteca("BIBLIOTECA DE CIENCIAS SOCIALES", "BCS");
//        
//        // Insertar bibliotecas
//        bibliotecaDao.insertar(bib1);
//        bibliotecaDao.insertar(bib2);
//        
//        // Listar bibliotecas
//        ArrayList<Biblioteca> bibliotecas = bibliotecaDao.listar();
//        System.out.println("\nBibliotecas:\n");
//        for (Biblioteca b : bibliotecas) {
//            System.out.println(b.mostrarDatos());
//        }
//        
//        // ACTIVOS FIJOS
//        // Crear activo fijo
//        ActivoFijo activoFijo1 = new ActivoFijo("Equipo de Autoprestamo 1", "12345", "Autoprestamo", "Epson");
//        
//        // Insertar activo fijo
//        activoFijoDao.insertar(activoFijo1);
//        
//        // Listar activos fijos
//        ArrayList<ActivoFijo> acts = activoFijoDao.listar();
//        System.out.println("\nActivos Fijos:\n");
//        for (ActivoFijo a : acts) {
//            System.out.println(a.mostrarDatos());
//        }
//        
//        // EMPLEADO
//        // Crear empleados
//        Empleado empleado1 = new Empleado(bib1, "20175657", "79805979", "Juan","Geldres", "Quiroz",
//                "Jiron Aragon 283", "8412", "abcd1234", "aymar.geldres@pucp.edu.pe");
//        Empleado empleado2 = new Empleado(bib1, "20176969", "70487898", "Leonardo","Cervantes", "Diaz",
//                "Jiron Patricio 183", "7893", "abcd1234", "a20176969@pucp.edu.pe");
//        Empleado empleado3 = new Empleado(bib2, "20174200", "78979999", "Paul","Canasa", "Mayta",
//                "Jiron Yroge 123", "7423", "abcd1234", "paul.canasa@pucp.edu.pe");
//        
//        
//        // Insertar empleados
//        empleadoDao.insertar(empleado1);
//        empleadoDao.insertar(empleado2);
//        empleadoDao.insertar(empleado3);
//        
//        // Listar empleados
//        ArrayList<Empleado> empleados = empleadoDao.listar();
//        System.out.println("\nEmpleado:\n");
//        for (Empleado e : empleados) {
//            System.out.println(e.mostrarDatos() + " - " + e.getBiblioteca().getAbreviatura());
//        }
//        
//        
//        // ESTADOS DE TICKET
//        // Crear estados de ticket
//        EstadoTicket estado1 = new EstadoTicket("ACTIVO", "El ticket acaba de ser enviado");
//        EstadoTicket estado2 = new EstadoTicket("CERRADO", "El ticket ya ha sido solucionado");
//        EstadoTicket estado3 = new EstadoTicket("ESCALADO", "El ticket ha sido transferido a un proveedor");
//        
//        // Insertar
//        estadoTicketDao.insertar(estado1);
//        estadoTicketDao.insertar(estado2);
//        estadoTicketDao.insertar(estado3);
//        
//        // Listar estados
//        ArrayList<EstadoTicket> estadosTicket = estadoTicketDao.listar();
//        System.out.println("\nEstados de ticket:\n");
//        for (EstadoTicket e : estadosTicket) {
//            System.out.println(e.mostrarDatos());
//        }
//        
//        // TICKET
//        // Crear y enviar tickets
//        Ticket ticket1 = new Ticket("Problema con la base de datos 1","No parece seleccionar todos los datos que corresponden al select, AYUDA!",
//                new EstadoTicket(1), new Empleado(1), new Urgencia(1), new Categoria(1), new Biblioteca(1));
//        Ticket ticket2 = new Ticket("Problema con el equipo de autoprestamo de la entrada",
//                "No esta escaneando bien los libros que entran y a veces se escucha sonidos de error, parece que es la conexion con el enchufe",
//                new EstadoTicket(1), new Empleado(2), new Urgencia(2), new Categoria(2), new Biblioteca(1));
//        ticket2.setActivoFijo(new ActivoFijo(1));
//        
//        ticketDao.insertar(ticket1);
//        ticketDao.insertar(ticket2);
//        
//        // Asignar agentes
//        ticket1.setAgente(agente1);
//        ticket2.setAgente(agente2);
//        
//        // Actualizamos
//        ticketDao.actualizar(ticket1);
//        ticketDao.actualizar(ticket2);
//        
//        // Listamos los tickets
//        ArrayList<Ticket>tickets = ticketDao.listar();
//        System.out.println("\nTickets\n");
//        for (Ticket t : tickets) {
//            System.out.println(t.mostrarDatos());
//        }
//        
//        // Solucionar ticket 1
//        ticket1.actualizarEstado(new EstadoTicket(2), "Se arreglo el problema");
//        ticketDao.actualizar(ticket1);
//        
//        // Mandar mensajes
//        Comentario mensaje1 = new Comentario(empleado1, "El problema es que hay chispas electricas en el equipo");
//        comentarioDao.insertar(mensaje1, ticket2);
//        Comentario mensaje2 = new Comentario(agente1, "Eso suena muy serio, lo revisare, pero probablemente deba revisarlo el proveedor");
//        comentarioDao.insertar(mensaje2, ticket2);
//        
//        // Listar mensajes
//        ArrayList<Comentario>comments = comentarioDao.listarxTicket(ticket2);
//        System.out.println("\nMensajes\n");
//        for (Comentario c : comments) {
//            System.out.println("Ticket 2 - " + c.mostrarDatos());
//        }
//        
//        // Escalar ticket 2
//        ticket2.escalar(proveedor2, "El proveedor deberia revisar el cableado");
//        ticket2.actualizarEstado(estado3, "El problema era muy grave, fue escalado");
//        ticketDao.actualizar(ticket2);
//        
//        // Listamos los tickets
//        System.out.println("\nTickets\n");
//        ArrayList<Ticket> tickets2 = ticketDao.listar();
//        for (Ticket t : tickets2) {
//            System.out.println(t.mostrarDatos());
//        }


        // Pruebas individuales
        
        TareaPredeterminada tareaPred1 = new TareaPredeterminada();
        tareaPred1.setTareaPredeterminadaId(7);
        tareaPred1.setDescripcion("Segunda prueba de actualizacion desde el Java");
        
        int i = tareaPredeterminadaDao.actualizar(tareaPred1);
        
        System.out.println(i);
        
//        // Listamos los tickets
//        ArrayList<Ticket>tickets = ticketDao.listar();
//        System.out.println("\nTickets\n");
//        for (Ticket t : tickets) {
//            System.out.println(t.mostrarDatos());
//        }


        /* Los metodos para eliminar en las clases con campo activo los ponen en 0
         * Es requisto que se deje un registro permanente en base de datos
         */
        
        //listar por nombre
        
//        ArrayList<Empleado>empleados =empleadoDao.listarxNombre("a");
//        System.out.println("\nEmpleados\n");
//        for (Empleado e : empleados) {
//            System.out.println(e.mostrarDatos());
//        }
//        
//        ArrayList<Agente>agentes =agenteDao.listarxNombre("a");
//        System.out.println("\nAgentes\n");
//        for (Agente a : agentes) {
//            System.out.println(a.mostrarDatos());
//        }
    }
}