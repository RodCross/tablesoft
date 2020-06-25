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
    public partial class frmSeleccionarTareasTicket : Form
    {
        private TareaWS.TareaWSClient tareaDAO = new TareaWS.TareaWSClient();
        private BindingList<TareaWS.tarea> tareas;
        private TareaWS.ticket ticket = new TareaWS.ticket();

        public frmSeleccionarTareasTicket(TicketWS.ticket tick)
        {
            InitializeComponent();
            ticket.ticketId = tick.ticketId;
            TareaWS.tarea[] arrTareas = tareaDAO.listarTareasPorTicket(ticket);
            dgvLista.AutoGenerateColumns = false;
            if (arrTareas != null)
            {
                tareas = new BindingList<TareaWS.tarea>(arrTareas);
                dgvLista.DataSource = tareas;
            }
            else
            {
                dgvLista.DataSource = null;
            }

            if (dgvLista.DataSource == null)
            {
                btnEditar.Enabled = false;
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void dgvLista_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnEditar.Enabled = false;
            }
            else if (!btnEditar.Enabled)
            {
                btnEditar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarTareasTicket frm = new frmGestionarTareasTicket();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            TareaWS.tarea tarea = (TareaWS.tarea)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarTareasTicket frm = new frmGestionarTareasTicket(tarea);
            frm.ShowDialog();
        }

    }
}
