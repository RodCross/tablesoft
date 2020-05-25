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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmInicioEmpleado frm = new frmInicioEmpleado
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
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
