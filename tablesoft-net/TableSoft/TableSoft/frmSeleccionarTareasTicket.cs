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

        // TEMPORAL: hasta traer el objeto ticket desde el formulario padre hasta aqui
        // se toma un objeto ticket de la lista que existe
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> tickets;
        private TareaWS.ticket ticket = new TareaWS.ticket();

        public frmSeleccionarTareasTicket()
        {
            InitializeComponent();

            // TEMPORAL
            tickets = new BindingList<TicketWS.ticket>(ticketDAO.listarTickets());
            ticket.ticketId = tickets[2].ticketId; // obviamente hardcodeado

            tareas = new BindingList<TareaWS.tarea>(tareaDAO.listarTareasPorTicket(ticket).ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = tareas;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
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
