using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        }

        public frmGestionarBiblioteca(BibliotecaWS.biblioteca bibl)
        {
            biblioteca = bibl;
            InitializeComponent();
            txtIDBib.Text = biblioteca.bibliotecaId.ToString();
            txtNombre.Text = biblioteca.nombre;
            txtAbrev.Text = biblioteca.abreviatura;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la biblioteca de contener al menos una letra.",
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
            if (Regex.Matches(txtAbrev.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La abreviatura de la biblioteca de contener al menos una letra.",
                    "Error de abreviatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            biblioteca.nombre = txtNombre.Text;
            biblioteca.abreviatura = txtAbrev.Text;
            if (MessageBox.Show("¿Desea crear el registro?", "Crear Biblioteca", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bibliotecaDAO.insertarBiblioteca(biblioteca) > 0)
                {
                    MessageBox.Show(
                    "Se ha creado el registro exitosamente",
                    "Registro exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha creado el registro",
                    "Registro no realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "No se ha creado el registro",
                "Registro no realizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            txtIDBib.Text = biblioteca.bibliotecaId.ToString();
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
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la biblioteca de contener al menos una letra.",
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
            if (Regex.Matches(txtAbrev.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La abreviatura de la biblioteca de contener al menos una letra.",
                    "Error de abreviatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            biblioteca.nombre = txtNombre.Text;
            biblioteca.abreviatura = txtAbrev.Text;
            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Biblioteca", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bibliotecaDAO.actualizarBiblioteca(biblioteca) > -1)
                {
                    MessageBox.Show(
                    "Se ha actualizado el registro exitosamente",
                    "Actualización exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha realizado la actualización",
                    "Actualización no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "No se ha realizado la actualización",
                "Actualización no realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
