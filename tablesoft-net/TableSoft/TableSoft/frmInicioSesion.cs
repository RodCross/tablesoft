using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.CategoriaWS;

namespace TableSoft
{
    public partial class frmInicioSesion : Form
    {
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private EmpleadoWS.EmpleadoWSClient empleadoDAO = new EmpleadoWS.EmpleadoWSClient();
        public static AgenteWS.agente agenteLogueado;
        public static EmpleadoWS.empleado empleadoLogueado;

        public frmInicioSesion()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        // Inicios de sesion
        private void AbrirInicioEmpleado()
        {
            frmInicioEmpleado frm = new frmInicioEmpleado();
            
            // Mostrar pagina inicial al cerrar sesion
            frm.FormClosing += delegate
            {
                this.Show();
                LimpiarCampos();
            };

            frm.Show();
            this.Hide();
        }

        private void AbrirInicioAgente()
        {
            frmInicioAgente frm = new frmInicioAgente();

            // Mostrar pagina inicial al cerrar sesion
            frm.FormClosing += delegate
            {
                this.Show();
                LimpiarCampos();
            };
            frm.Show();
            this.Hide();
        }

        private void AbrirInicioSupervisor()
        {
            frmInicioSupervisor frm = new frmInicioSupervisor();

            // Mostrar pagina inicial al cerrar sesion
            frm.FormClosing += delegate
            {
                this.Show();
                LimpiarCampos();
            };

            frm.Show();
            this.Hide();
        }

        private void AbrirInicioAdmin()
        {
            frmInicioAdmin frm = new frmInicioAdmin();

            // Mostrar pagina inicial al cerrar sesion
            frm.FormClosing += delegate
            {
                this.Show();
                LimpiarCampos();
            };

            frm.Show();
            this.Hide();
        }

        // Para dejar los campos en blanco
        private void LimpiarCampos()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            lblErrEmail.Text = "";
            lblErrPassword.Text = "";
            txtEmail.Select();
        }

        // Eventos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validacion email
            if (txtEmail.Text == "")
            {
                lblErrEmail.Text = "El campo del email no puede estar vacío.";
            }
            else
            {
                lblErrEmail.Text = "";
            }

            // Validar password
            if (txtPassword.Text == "")
            {
                lblErrPassword.Text = "El campo de la contraseña no puede estar vacío.";
            }
            else
            {
                lblErrPassword.Text = "";
            }

            // Iniciar sesion
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                int rpta = personaDAO.verificarCorreo(txtEmail.Text);
                if (rpta == -1)
                {
                    lblErrEmail.Text = "Has ingresado un email incorrecto.";
                }
                else
                {

                    PersonaWS.persona user = personaDAO.verificarPersona(txtEmail.Text, txtPassword.Text);

                    if (user != null)
                    {
                        // Llevar a inicio en funcion del rol
                        if (user.tipo == 'E')
                        {
                            empleadoLogueado = empleadoDAO.buscarEmpleadoPorCodigo(user.codigo);
                            AbrirInicioEmpleado();
                        }
                        else if (user.tipo == 'A')
                        {
                            agenteLogueado = agenteDAO.buscarAgentePorCodigo(user.codigo);
                            if (agenteLogueado.rol.nombre.Contains("AGENTE"))
                            {
                                AbrirInicioAgente();
                            }
                            else if (agenteLogueado.rol.nombre.Contains("SUPERVISOR"))
                            {
                                AbrirInicioSupervisor();
                            }
                            else if (agenteLogueado.rol.nombre.Contains("ADMIN"))
                            {
                                AbrirInicioAdmin();
                            }
                        }
                    }
                    else
                    {
                        lblErrPassword.Text = "La contraseña es incorrecta";
                        txtPassword.SelectAll();
                        txtPassword.Focus();
                    }
                }
            }
        }

        private void picExit_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.ExitMouseDown;
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.ExitMouseEnter;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.Exit;
        }

        private void picExit_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.ExitMouseEnter;
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void lklFAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAyuda frm = new frmAyuda
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

        private void lklForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarPassword frm = new frmRecuperarPassword
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

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseDown;
            txtPassword.PasswordChar = '\0';
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
            txtPassword.PasswordChar = '•';
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }
    }
}
