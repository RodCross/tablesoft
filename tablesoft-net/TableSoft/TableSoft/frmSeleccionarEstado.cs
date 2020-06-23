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
    public partial class frmSeleccionarEstado : Form
    {
        private EstadoTicketWS.EstadoTicketWSClient estadoDAO = new EstadoTicketWS.EstadoTicketWSClient();
        private BindingList<EstadoTicketWS.estadoTicket> estados;

        public frmSeleccionarEstado()
        {
            InitializeComponent();
            estados = new BindingList<EstadoTicketWS.estadoTicket>(estadoDAO.listarEstadosTicket().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = estados;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarEstado frm = new frmGestionarEstado();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EstadoTicketWS.estadoTicket et = (EstadoTicketWS.estadoTicket)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarEstado frm = new frmGestionarEstado(et);
            frm.ShowDialog();
        }
    }
}
