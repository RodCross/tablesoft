using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmGestionarSistemaAdministrador : Form
    {
        public frmGestionarSistemaAdministrador()
        {
            InitializeComponent();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestionarEmpleado_Click(object sender, EventArgs e)
        {
            frmSeleccionarEmpleado frm = new frmSeleccionarEmpleado();
            frm.ShowDialog();
        }

        private void btnGestionarAgentes_Click(object sender, EventArgs e)
        {
            frmSeleccionarAgente frm = new frmSeleccionarAgente();
            frm.ShowDialog();
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            frmSeleccionarCategoria frm = new frmSeleccionarCategoria();
            frm.ShowDialog();
        }

        private void btnGestionarUrgencias_Click(object sender, EventArgs e)
        {
            frmSeleccionarUrgencia frm = new frmSeleccionarUrgencia();
            frm.ShowDialog();
        }

        private void btnGestionarEquiposTrabajo_Click(object sender, EventArgs e)
        {
            frmSeleccionarEquipo frm = new frmSeleccionarEquipo();
            frm.ShowDialog();
        }

        private void btnGestionarEstadosTicket_Click(object sender, EventArgs e)
        {
            frmSeleccionarEstado frm = new frmSeleccionarEstado();
            frm.ShowDialog();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            frmSeleccionarProveedor frm = new frmSeleccionarProveedor();
            frm.ShowDialog();
        }

        private void btnGestionarActivosFijos_Click(object sender, EventArgs e)
        {
            frmSeleccionarActivoFijo frm = new frmSeleccionarActivoFijo();
            frm.ShowDialog();
        }

        private void btnGestionarBibliotecas_Click(object sender, EventArgs e)
        {
            frmSeleccionarBiblioteca frm = new frmSeleccionarBiblioteca();
            frm.ShowDialog();
        }
    }
}
