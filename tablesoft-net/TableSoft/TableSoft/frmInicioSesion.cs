using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.temp; // para clases temporales

// PARA ACCEDER RAPIDAMENTE:
// EMPLEADO      usuario y pass: e
// AGENTE        usuario y pass: a
// SUPERVISOR    usuario y pass: s
// ADMIN         usuario y pass: admin

namespace TableSoft
{
    public partial class frmInicioSesion : Form
    {
        BindingList<Usuario> usuarios = new BindingList<Usuario>();
        Usuario user1 = new Usuario("a20167474@pucp.edu.pe", "abcd1234", "Empleado");
        Usuario user2 = new Usuario("f.verastegui@pucp.edu.pe", "abcd1234", "Agente");
        Usuario user3 = new Usuario("cacs@pucp.edu.pe", "abcd1234", "Supervisor");
        Usuario user4 = new Usuario("ms404@pucp.edu.pe", "abcd1234", "Administrador");
        Usuario user5 = new Usuario("e", "e", "Empleado");
        Usuario user6 = new Usuario("a", "a", "Agente");
        Usuario user7 = new Usuario("s", "s", "Supervisor");
        Usuario user8 = new Usuario("admin", "admin", "Administrador");

        public frmInicioSesion()
        {
            InitializeComponent();
            LimpiarCampos();
            usuarios.Add(user1);
            usuarios.Add(user2);
            usuarios.Add(user3);
            usuarios.Add(user4);
            usuarios.Add(user5);
            usuarios.Add(user6);
            usuarios.Add(user7);
            usuarios.Add(user8);
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
                bool login = false;

                foreach (Usuario usuario in usuarios)
                {
                    if (txtEmail.Text == usuario.Email && txtPassword.Text == usuario.Password)
                    {
                        // Llevar a inicio en funcion del rol
                        if (usuario.Rol == "Empleado")
                        {
                            AbrirInicioEmpleado();
                        }
                        else if (usuario.Rol == "Agente")
                        {
                            AbrirInicioAgente();
                        }
                        else if (usuario.Rol == "Supervisor")
                        {
                            AbrirInicioSupervisor();
                        }
                        else if (usuario.Rol == "Administrador")
                        {
                            AbrirInicioAdmin();
                        }

                        login = true;
                        break;
                    }
                }
                if (!login)
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
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();
        }
    }
}
