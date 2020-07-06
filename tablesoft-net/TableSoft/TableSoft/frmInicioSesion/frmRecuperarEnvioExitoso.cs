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
    public partial class frmRecuperarEnvioExitoso : Form
    {
        private bool reenviado = false;
        private string codigo;
        private string emailUsuario;

        public frmRecuperarEnvioExitoso(string code, string emailUsuario)
        {
            InitializeComponent();
            LimpiarCampos();
            this.codigo = code;
            this.emailUsuario = emailUsuario;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            lblErrCodigo.Text = "";
            lklReenviar.Text = "";
            txtCodigo.Select();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void lklReenviar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Se ha reenviado el mensaje con éxito. Esta opción solo está disponible una vez.",
                "Reenvío exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            LimpiarCampos();
            reenviado = true;
        }
        
        private void lklRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                lblErrCodigo.Text = "Ingresa el código.";
                if (lklReenviar.Text != "")
                {
                    lklReenviar.Text = "";
                }
            }
            else if (txtCodigo.Text == codigo)
            {
                // success

                frmCrearNuevaPassword frm = new frmCrearNuevaPassword(emailUsuario)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };

                this.Hide();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LimpiarCampos();
                    this.Close();
                }
            }
            else
            {
                lblErrCodigo.Text = "Código incorrecto.";
                if (!reenviado)
                {
                    lklReenviar.Text = "Reenviar código.";
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Realmente deseas volver a Inicio? Tendrás que repetir todos los pasos anteriores para regresar aquí.",
                "Volver a Inicio",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
