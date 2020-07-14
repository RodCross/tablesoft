using System;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInicioAdmin : Form
    {
        public frmInicioAdmin()
        {
            InitializeComponent();
            SetUsername(lblUsuario);
            SetTeamName(lblNombreEquipo);
        }

        private void SetUsername(Label lblUser)
        {
            AgenteWS.agente age = frmLogin.agenteLogueado;
            lblUser.Text = age.apellidoPaterno + " " + age.apellidoMaterno + ", " + age.nombre;
        }

        private void SetTeamName(Label lblNom)
        {
            lblNom.Text = frmLogin.agenteLogueado.equipo.nombre;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void lklLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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

        private void btnTodosLosTickets_Click(object sender, EventArgs e)
        {
            frmListaTickets frm = new frmListaTickets
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
