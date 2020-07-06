using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmCrearNuevaPassword : Form
    {
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();
        private string emailUsuario;
        public frmCrearNuevaPassword(string emailUsuario)
        {
            InitializeComponent();
            this.emailUsuario = emailUsuario;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Realmente deseas volver a Inicio? Tu nueva contraseña NO será creada y tendrás que repetir todos los pasos anteriores para regresar aquí.",
                "Volver a Inicio",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCrearPass_Click(object sender, EventArgs e)
        {
            if (txtNuevaPass.Text == "")
            {
                lblErrNuevaPass.Text = "Ingresa una nueva contraseña.";
            }
            else
            {
                lblErrNuevaPass.Text = "";
            }

            if (txtConfirm.Text == "")
            {
                lblErrConfirm.Text = "Vuelve a escribir la misma contraseña.";
            }
            else
            {
                lblErrConfirm.Text = "";
            }

            if (txtNuevaPass.Text != "" && txtConfirm.Text != "")
            {
                if (txtNuevaPass.Text == txtConfirm.Text)
                {
                    if (MessageBox.Show(
                        "Tu contraseña será cambiada a la que ingresaste. ¿Deseas continuar?",
                        "Confirmación de cambio de contraseña",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // REGISTRAR EN BD

                        int rpta = personaDAO.actualizarPass(emailUsuario, txtNuevaPass.Text);

                        if (rpta > -1)
                        {
                            MessageBox.Show(
                            "Contraseña actualizada correctamente.",
                            "Actualización exitosa.",
                            MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(
                            "Ocurrió un error al actualizar la contraseña",
                            "Error de actualización.",
                            MessageBoxButtons.OK);
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    lblErrConfirm.Text = "Las contraseñas no coinciden.";
                }
            }
        }

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseDown;
            txtNuevaPass.PasswordChar = '\0';
        }

        private void picEye_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseEnter;
        }

        private void picEye_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.Eye;
        }

        private void picEye_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseEnter;
            txtNuevaPass.PasswordChar = '•';
        }
    }
}
