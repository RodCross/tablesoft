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
            frmSeleccionarEmpleado frm = new frmSeleccionarEmpleado
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarAgentes_Click(object sender, EventArgs e)
        {
            frmSeleccionarAgente frm = new frmSeleccionarAgente
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            frmSeleccionarCategoria frm = new frmSeleccionarCategoria
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarUrgencias_Click(object sender, EventArgs e)
        {
            frmSeleccionarUrgencia frm = new frmSeleccionarUrgencia
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarEquiposTrabajo_Click(object sender, EventArgs e)
        {
            frmSeleccionarEquipo frm = new frmSeleccionarEquipo
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarEstadosTicket_Click(object sender, EventArgs e)
        {
            frmSeleccionarEstado frm = new frmSeleccionarEstado
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            frmSeleccionarProveedor frm = new frmSeleccionarProveedor
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarActivosFijos_Click(object sender, EventArgs e)
        {
            frmSeleccionarActivoFijo frm = new frmSeleccionarActivoFijo
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGestionarBibliotecas_Click(object sender, EventArgs e)
        {
            frmSeleccionarBiblioteca frm = new frmSeleccionarBiblioteca
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
