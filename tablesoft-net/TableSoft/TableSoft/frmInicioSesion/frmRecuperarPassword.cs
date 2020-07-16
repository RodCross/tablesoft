using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmRecuperarPassword : Form
    {
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();
        private EmailWS.EmailWSSoapClient servicioEmail = new EmailWS.EmailWSSoapClient();

        public frmRecuperarPassword()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtEmail.Text = "";
            lblErrEmail.Text = "";
            txtEmail.Select();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            // Validar email no vacio
            if (txtEmail.Text == "")
            {
                lblErrEmail.Text = "Ingresa tu email.";
            }
            else
            {
                if (lblErrEmail.Text != "")
                {
                    lblErrEmail.Text = "";
                }
                if (!Regex.IsMatch(txtEmail.Text, @"^([\w-.]+)@(pucp.(edu.)?pe)$"))
                {
                    MessageBox.Show(
                        "Debe ingresar un correo válido del dominio PUCP.",
                        "Error de email",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }

                int rpta = personaDAO.verificarCorreo(txtEmail.Text);

                if (rpta == -1)
                {
                    lblErrEmail.Text = "Has ingresado un email incorrecto.";
                }

                else
                {
                    // Conectar con Gmail API

                    string codigo = RandomGenerator.GenerateRandomCode();
                    PersonaWS.persona per = personaDAO.buscarPersonaxEmail(txtEmail.Text);

                    StreamReader streamReader = new StreamReader("../../emails/EmailRecuperarPass.html", System.Text.Encoding.UTF8);
                    string body = streamReader.ReadToEnd();
                    body = body.Replace("*NOMBREPH*", per.nombre);
                    body = body.Replace("*APELLIDOPH*", per.apellidoPaterno);
                    body = body.Replace("*CODIGOPH*", codigo);

                    EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
                    correo.FromAddress = "noreply.yanapay@gmail.com";
                    correo.ToRecipients = txtEmail.Text;
                    correo.Subject = "Yanapay - Recuperación de contraseña";
                    correo.Body = body;
                    correo.IsHtml = true;

                    if (servicioEmail.EnviarCorreo(correo) == false)
                    {
                        MessageBox.Show(
                        "Ha ocurrido un error al enviar el correo de confirmación",
                        "Correo no enviado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        frmRecuperarEnvioExitoso frm = new frmRecuperarEnvioExitoso(codigo, txtEmail.Text)
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = this.Location
                        };

                        this.Hide();
                        if (frm.ShowDialog() == DialogResult.Retry)
                        {
                            LimpiarCampos();
                            this.Show();
                        }
                        else
                        {
                            LimpiarCampos();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
