using System;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInicioAgente : Form
    {
        public AgenteWS.agente agenteLogueado;
        public frmInicioAgente()
        {
            InitializeComponent();
            

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

        private void lklLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            frmMiEquipoAgente frm = new frmMiEquipoAgente
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

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmListaTicketsAgente frm = new frmListaTicketsAgente
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
