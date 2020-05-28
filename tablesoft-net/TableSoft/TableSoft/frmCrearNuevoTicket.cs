using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.temp; // para clases temporales

namespace TableSoft
{
    public partial class frmCrearNuevoTicket : Form
    {
        BindingList<Biblioteca> bibliotecas = new BindingList<Biblioteca>();
        BindingList<Categoria> categorias = new BindingList<Categoria>();
        BindingList<Urgencia> urgencias = new BindingList<Urgencia>();
        Biblioteca b1 = new Biblioteca("COMPLEJO DE INNOVACION ACADEMICA", "CIA");
        Biblioteca b2 = new Biblioteca("BIBLIOTECA DE CIENCIAS SOCIALES", "CS");
        Biblioteca b3 = new Biblioteca("BIBLIOTECA CENTRAL", "BC");
        Categoria c1 = new Categoria("BASE DE DATOS EN LINEA", "SOBRE BD EN LINEA");
        Categoria c2 = new Categoria("EQUIPOS DE AUTOPRESTAMO", "SOBRE EL ASPECTO ELECTRONICO");
        Categoria c3 = new Categoria("EQUIPOS DE INVENTARIO", "SOBRE EQUIPOS DE INVENTARIO");
        Urgencia u1 = new Urgencia("EMERGENCIA", 2);
        Urgencia u2 = new Urgencia("INCIDENTE", 24);
        Urgencia u3 = new Urgencia("CONSULTA", 72);

        public frmCrearNuevoTicket()
        {
            InitializeComponent();
            bibliotecas.Add(b1);
            bibliotecas.Add(b2);
            bibliotecas.Add(b3);
            categorias.Add(c1);
            categorias.Add(c2);
            categorias.Add(c3);
            urgencias.Add(u1);
            urgencias.Add(u2);
            urgencias.Add(u3);
            cboBiblioteca.DataSource = bibliotecas;
            cboBiblioteca.DisplayMember = "Nombre";
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Nombre";
            cboUrgencia.DataSource = urgencias;
            cboUrgencia.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ticket correctamente creado y enviado.",
                "Envío exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
