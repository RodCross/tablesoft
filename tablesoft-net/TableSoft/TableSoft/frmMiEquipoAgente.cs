using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.AgenteWS;

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
            TicketWS.ticket tck = (TicketWS.ticket)dgvTicketsEspera.CurrentRow.DataBoundItem;
            TicketWS.estadoTicket estAsignado = new TicketWS.estadoTicket();
            estAsignado.estadoId = 6;

            tck.estado = estAsignado;
            
            // Registrar el cambio de estado
            var historialEstados = new BindingList<TicketWS.cambioEstadoTicket>();
            
            var cambioEstado = new TicketWS.cambioEstadoTicket();
            cambioEstado.comentario = "El ticket fue asignado";
            var ag = new TicketWS.agente();
            ag.agenteId = agente.agenteId;
            cambioEstado.agenteResponsable = ag;
            cambioEstado.estadoTo = estAsignado;

            historialEstados.Add(cambioEstado);

            // Asignar la lista de cambios de estado
            tck.historialEstado = historialEstados.ToArray();

            if (MessageBox.Show("¿Desea atender este ticket?", "Seleccionar ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ticketDAO.actualizarTicket(tck) > -1)
                {
                    MessageBox.Show(
                    "Se te ha asignado el ticket correctamente",
                    "Asignación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "Ha ocurrido un error con la asignación",
                    "Asginación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }

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
                if (tickts != null)
                {
                    //ticketsEnEspera.Concat(tickts.ToList());    <- no se si funcionaria
                    foreach (TicketWS.ticket t in tickts)
                    {
                        ticketsEnEspera.Add(t);
                    }
                }

                dgvTicketsEspera.AutoGenerateColumns = false;
                dgvTicketsEspera.DataSource = ticketsEnEspera;
            }

        }

        private void dgvTicketsEspera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvTicketsEspera.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;

            dgvTicketsEspera.Rows[e.RowIndex].Cells["AbreviaturaBiblioteca"].Value = data.biblioteca.abreviatura;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreEmpleado"].Value = data.empleado.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreCategoria"].Value = data.categoria.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreUrgencia"].Value = data.urgencia.nombre;

        }
    }
}
