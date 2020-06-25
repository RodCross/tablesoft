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
            frmInicioEmpleado frm = new frmInicioEmpleado
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

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
            frmInicioAgente frm = new frmInicioAgente
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

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
            frmInicioSupervisor frm = new frmInicioSupervisor
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

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
            frmInicioAdmin frm = new frmInicioAdmin
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

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
                    lblErrEmail.Text = "El email o la contraseña son incorrectos.";
                    lblErrPassword.Text = "";
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
    }
}
