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
    public partial class frmListaTicketsAgente : Form
    {
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> tickets;

        public frmListaTicketsAgente()
        {
            InitializeComponent();
            TicketWS.agente agenAux = new TicketWS.agente();
            agenAux.agenteId =  frmInicioSesion.agenteLogueado.agenteId;
            TicketWS.ticket[] arrTickets = ticketDAO.listarTicketsPorAgente(agenAux);
            dgvHistorial.AutoGenerateColumns = false;
            if (arrTickets != null)
            {
                tickets = new BindingList<TicketWS.ticket>(arrTickets);
                dgvHistorial.DataSource = tickets;
            }
            else
            {
                dgvHistorial.DataSource = null;
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void dgvHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvHistorial.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;
            dgvHistorial.Rows[e.RowIndex].Cells["FechaEnvio"].Value = data.fechaEnvio.Replace("T", " ");
            dgvHistorial.Rows[e.RowIndex].Cells["Empleado"].Value = data.empleado.nombre + " " + data.empleado.apellidoPaterno + " " + data.empleado.apellidoMaterno;
            dgvHistorial.Rows[e.RowIndex].Cells["Estado"].Value = data.estado.nombre;
            dgvHistorial.Rows[e.RowIndex].Cells["Urgencia"].Value = data.urgencia.nombre;
            dgvHistorial.Rows[e.RowIndex].Cells["Categoria"].Value = data.categoria.nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            TicketWS.ticket tick = (TicketWS.ticket)dgvHistorial.CurrentRow.DataBoundItem;
            frmInfoTicketAgente frm = new frmInfoTicketAgente(tick);

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = this.Location;

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
