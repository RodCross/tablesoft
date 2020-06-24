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
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmGestionarEquipo : Form
    {
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private EquipoWS.equipo equipo;
        public frmGestionarEquipo()
        {
            equipo = new EquipoWS.equipo();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarEquipo(EquipoWS.equipo equi)
        {
            equipo = equi;
            InitializeComponent();
            txtIDEquipo.Text = equipo.equipoId.ToString();
            txtNombre.Text = equipo.nombre;
            txtDescripcion.Text = equipo.descripcion;
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del equipo.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre del equipo de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del equipo.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del equipo de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            equipo.nombre = txtNombre.Text;
            equipo.descripcion = txtDescripcion.Text;
            if (equipoDAO.insertarEquipo(equipo) > 0)
            {
                MessageBox.Show(
                    "Se ha guardado el registro.",
                    "Guardado exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            txtIDEquipo.Text = equipo.equipoId.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (equipoDAO.eliminarEquipo(equipo) > -1)
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
                    "Falta indicar el nombre del equipo.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la equipo de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del equipo.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del equipo de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            equipo.nombre = txtNombre.Text;
            equipo.descripcion = txtDescripcion.Text;
            if (equipoDAO.actualizarEquipo(equipo) > -1)
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
