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
    public partial class frmListaTicketsEmpleado : Form
    {
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> tickets;

        public frmListaTicketsEmpleado()
        {
            InitializeComponent();
            TicketWS.empleado empAux = new TicketWS.empleado();
            empAux.empleadoId = frmInicioSesion.empleadoLogueado.empleadoId;
            var tic = ticketDAO.listarTicketsPorEmpleado(empAux);
            if(tic == null)
            {
                tickets = new BindingList<TicketWS.ticket>();
            }
            else
            {
                tickets = new BindingList<TicketWS.ticket>(tic);
            }
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.DataSource = tickets;
        }

        private void dgvHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvHistorial.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;
            dgvHistorial.Rows[e.RowIndex].Cells["FechaEnvio"].Value = data.fechaEnvio.Replace("T", " ");
            //dgvHistorial.Rows[e.RowIndex].Cells["FechaCierre"].Value = data.fechaCierre;
            dgvHistorial.Rows[e.RowIndex].Cells["Estado"].Value = data.estado.nombre;
            dgvHistorial.Rows[e.RowIndex].Cells["Agente"].Value = data.agente.nombre + " " + data.agente.apellidoPaterno + " " + data.agente.apellidoMaterno;
            dgvHistorial.Rows[e.RowIndex].Cells["Urgencia"].Value = data.urgencia.nombre;
            dgvHistorial.Rows[e.RowIndex].Cells["Categoria"].Value = data.categoria.nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            TicketWS.ticket tic = (TicketWS.ticket)dgvHistorial.CurrentRow.DataBoundItem;
            frmInfoTicketEmpleado frm = new frmInfoTicketEmpleado(tic);

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = this.Location;
            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
