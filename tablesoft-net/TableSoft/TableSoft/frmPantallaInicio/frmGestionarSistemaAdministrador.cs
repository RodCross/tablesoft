using System;
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

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarAgentes_Click(object sender, EventArgs e)
        {
            frmSeleccionarAgente frm = new frmSeleccionarAgente();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            frmSeleccionarCategoria frm = new frmSeleccionarCategoria();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarUrgencias_Click(object sender, EventArgs e)
        {
            frmSeleccionarUrgencia frm = new frmSeleccionarUrgencia();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarEquiposTrabajo_Click(object sender, EventArgs e)
        {
            frmSeleccionarEquipo frm = new frmSeleccionarEquipo();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarEstadosTicket_Click(object sender, EventArgs e)
        {
            frmSeleccionarEstado frm = new frmSeleccionarEstado();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            frmSeleccionarProveedor frm = new frmSeleccionarProveedor();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarActivosFijos_Click(object sender, EventArgs e)
        {
            frmSeleccionarActivoFijo frm = new frmSeleccionarActivoFijo();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarBibliotecas_Click(object sender, EventArgs e)
        {
            frmSeleccionarBiblioteca frm = new frmSeleccionarBiblioteca();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
