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

namespace TableSoft
{
    public partial class frmInicioSesion : Form
    {
        BindingList<Usuario> usuarios = new BindingList<Usuario>();
        Usuario user1 = new Usuario("a20167474@pucp.edu.pe", "abcd1234", "Empleado");
        Usuario user2 = new Usuario("f.verastegui@pucp.edu.pe", "abcd1234", "Agente");

        public frmInicioSesion()
        {
            InitializeComponent();
            LimpiarCampos();
            usuarios.Add(user1);
            usuarios.Add(user2);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validacion email
            if (txtEmail.Text == "")
            {
                txtErrEmail.Text = "El campo del email no puede estar vacío.";
            }
            else
            {
                txtErrEmail.Text = "";
            }

            // Validar password
            if (txtPassword.Text == "")
            {
                txtErrPassword.Text = "El campo de la contraseña no puede estar vacío.";
            }
            else
            {
                txtErrPassword.Text = "";
            }

            // Iniciar sesion
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                bool login = false;

                foreach (Usuario usuario in usuarios)
                {
                    if (txtEmail.Text == usuario.Email && txtPassword.Text == usuario.Password)
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
                        login = true;
                        break;
                    }
                }
                if (!login)
                {
                    txtErrEmail.Text = "El email o la contraseña son incorrectos.";
                    txtErrPassword.Text = "";
                }
            }
        }

        private void LimpiarCampos()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtErrEmail.Text = "";
            txtErrPassword.Text = "";
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
