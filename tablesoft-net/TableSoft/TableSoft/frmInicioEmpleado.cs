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
    public partial class frmInicioEmpleado : Form
    {
        public frmInicioEmpleado()
        {
            InitializeComponent();
        }

        private void lklFAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();
        }

        private void lklLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmCrearNuevoTicket frm = new frmCrearNuevoTicket();
            frm.ShowDialog();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            frmListaTicketsEmpleado frm = new frmListaTicketsEmpleado();
            frm.ShowDialog();
        }
    }
}
