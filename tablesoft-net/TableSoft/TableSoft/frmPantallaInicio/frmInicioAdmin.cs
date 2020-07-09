using System;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInicioAdmin : Form
    {
        public frmInicioAdmin()
        {
            InitializeComponent();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void lklLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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

        private void btnTickets_Click(object sender, EventArgs e)
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

        private void btnAtender_Click(object sender, EventArgs e)
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmGeneradorReportesAdministrador frm = new frmGeneradorReportesAdministrador
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

        private void btnGestionarSistema_Click(object sender, EventArgs e)
        {
            frmGestionarSistemaAdministrador frm = new frmGestionarSistemaAdministrador();

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
