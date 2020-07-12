using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmListaTicketsAgente : Form
    {
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> tickets;
        private TicketWS.agente agenAux = new TicketWS.agente();

        public frmListaTicketsAgente()
        {
            InitializeComponent();

            Refrescar();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void dgvHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvHistorial.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;

            dgvHistorial.Rows[e.RowIndex].Cells["FechaEnvio"].Value = data.fechaEnvio.Replace("T", " ");
            if (data.fechaCierre != null && data.fechaCierre.Contains("-"))
            {
                dgvHistorial.Rows[e.RowIndex].Cells["FechaCierre"].Value = data.fechaCierre.Replace("T", " ");
            }
            else
            {
                dgvHistorial.Rows[e.RowIndex].Cells["FechaCierre"].Value = "Ticket abierto";
            }
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
                Refrescar();
            };

            frm.Show();
            this.Hide();
        }

        private void Refrescar()
        {
            agenAux.agenteId = frmLogin.agenteLogueado.agenteId;

            TicketWS.ticket[] arrTickets = ticketDAO.listarTicketsPorAgente(agenAux);
            if (arrTickets == null)
            {
                tickets = new BindingList<TicketWS.ticket>();
            }
            else
            {
                tickets = new BindingList<TicketWS.ticket>(arrTickets);
            }
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.DataSource = tickets;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
