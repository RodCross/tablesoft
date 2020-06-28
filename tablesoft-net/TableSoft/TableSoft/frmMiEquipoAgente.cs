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
    public partial class frmMiEquipoAgente : Form
    {
        public AgenteWS.agente agente;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> ticketsEnEspera;
        public frmMiEquipoAgente()
        {
            InitializeComponent();
            agente = frmInicioSesion.agenteLogueado;

            TicketWS.equipo equip = new TicketWS.equipo();
            equip.equipoId = agente.equipo.equipoId;

            TicketWS.estadoTicket estActivo = new TicketWS.estadoTicket();
            estActivo.estadoId = 1;
            TicketWS.estadoTicket estRecategorizado = new TicketWS.estadoTicket();
            estRecategorizado.estadoId = 5;

            var tickts = ticketDAO.listarTicketsPorEstadoPorEquipo(estActivo, equip);
            if (tickts == null)
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>();
            }
            else
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>(tickts.ToList());
            }

            tickts = ticketDAO.listarTicketsPorEstadoPorEquipo(estRecategorizado, equip);
            if(tickts != null)
            {
                //ticketsEnEspera.Concat(tickts.ToList());    <- no se si funcionaria
                foreach(TicketWS.ticket t in tickts)
                {
                    ticketsEnEspera.Add(t);
                }
            }

            dgvTicketsEspera.AutoGenerateColumns = false;
            dgvTicketsEspera.DataSource = ticketsEnEspera;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se te ha asignado el ticket seleccionado.",
                "Asignación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void dgvTicketsEspera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvTicketsEspera.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;

            dgvTicketsEspera.Rows[e.RowIndex].Cells["AbreviaturaBiblioteca"].Value = data.biblioteca.abreviatura;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreEmpleado"].Value = data.empleado.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreCategoria"].Value = data.categoria.nombre;
        }
    }
}
