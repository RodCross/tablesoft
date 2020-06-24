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
    public partial class frmGestionarBiblioteca : Form
    {
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private BibliotecaWS.biblioteca biblioteca;
        public frmGestionarBiblioteca()
        {
            biblioteca = new BibliotecaWS.biblioteca();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarBiblioteca(BibliotecaWS.biblioteca bibl)
        {
            biblioteca = bibl;
            InitializeComponent();
            txtIDBib.Text = biblioteca.bibliotecaId.ToString();
            txtNombre.Text = biblioteca.nombre;
            txtAbrev.Text = biblioteca.abreviatura;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre de la biblioteca.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtAbrev.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la abreviatura de la biblioteca.",
                    "Error de abreviatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            biblioteca.nombre = txtNombre.Text;
            biblioteca.abreviatura = txtAbrev.Text;
            if(bibliotecaDAO.insertarBiblioteca(biblioteca) > 0)
            {
                MessageBox.Show (
                    "Se ha guardado el registro.",
                    "Guardado exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            txtIDBib.Text = biblioteca.bibliotecaId.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(bibliotecaDAO.eliminarBiblioteca(biblioteca) > -1)
            {
                MessageBox.Show(
                    "Se ha eliminado el registro.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre de la biblioteca.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtAbrev.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la abreviatura de la biblioteca.",
                    "Error de abreviatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            biblioteca.nombre = txtNombre.Text;
            biblioteca.abreviatura = txtAbrev.Text;
            if (bibliotecaDAO.actualizarBiblioteca(biblioteca) > -1)
            {
                MessageBox.Show(
                    "Se ha actualizado el registro.",
                    "Actualización exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
