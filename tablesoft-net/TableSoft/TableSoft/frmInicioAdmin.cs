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
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmMiEquipoAgente frm = new frmMiEquipoAgente();
            frm.ShowDialog();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            frmListaTicketsAgente frm = new frmListaTicketsAgente();
            frm.ShowDialog();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmGeneradorReportesAdministrador frm = new frmGeneradorReportesAdministrador();
            frm.ShowDialog();
        }

        private void btnGestionarSistema_Click(object sender, EventArgs e)
        {
            frmGestionarSistemaAdministrador frm = new frmGestionarSistemaAdministrador();
            frm.ShowDialog();
        }
    }
}
