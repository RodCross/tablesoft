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
    public partial class frmGestionarUrgencia : Form
    {
        private UrgenciaWS.UrgenciaWSClient urgenciaDAO = new UrgenciaWS.UrgenciaWSClient();
        private UrgenciaWS.urgencia urgencia;
        public frmGestionarUrgencia()
        {
            urgencia = new UrgenciaWS.urgencia();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }

        public frmGestionarUrgencia(UrgenciaWS.urgencia urg)
        {
            urgencia = urg;
            InitializeComponent();
            txtIDUrgencia.Text = urg.urgenciaId.ToString();
            txtNombre.Text = urg.nombre;
            txtPlazoMaximo.Text = urg.plazoMaximo.ToString();
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "No ha ingresado el nombre de la urgencia",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la urgencia debe contener al menos una letra",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (String.IsNullOrEmpty(txtPlazoMaximo.Text) || String.IsNullOrWhiteSpace(txtPlazoMaximo.Text))
            {
                MessageBox.Show("No ha ingresado el plazo máximo de la urgencia", "Error de plazo máximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtPlazoMaximo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("El plazo máximo es un campo numérico", "Error de plazo máximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            urgencia.nombre = txtNombre.Text;
            urgencia.plazoMaximo = int.Parse(txtPlazoMaximo.Text);

            if (urgenciaDAO.insertarUrgencia(urgencia) > 0)
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
            txtIDUrgencia.Text = urgencia.urgenciaId.ToString();
            this.DialogResult = DialogResult.OK;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "No ha ingresado el nombre de la urgencia",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la urgencia debe contener al menos una letra",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (String.IsNullOrEmpty(txtPlazoMaximo.Text) || String.IsNullOrWhiteSpace(txtPlazoMaximo.Text))
            {
                MessageBox.Show("No ha ingresado el plazo máximo", "Error de plazo máximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtPlazoMaximo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("El plazo máximo es un campo numérico", "Error de plazo máximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            urgencia.nombre = txtNombre.Text;
            urgencia.plazoMaximo = int.Parse(txtPlazoMaximo.Text);

            if (urgenciaDAO.actualizarUrgencia(urgencia) > -1)
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
            this.DialogResult = DialogResult.OK;

        }

        private void txtPlazoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
