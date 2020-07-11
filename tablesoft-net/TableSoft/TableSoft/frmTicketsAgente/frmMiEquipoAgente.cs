using System;
using System.ComponentModel;
using System.Linq;
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
            agente = frmLogin.agenteLogueado;

            Refrescar();
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
            if (MessageBox.Show("¿Desea atender este ticket?", "Seleccionar ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TicketWS.ticket tck = (TicketWS.ticket)dgvTicketsEspera.CurrentRow.DataBoundItem;
                
                // Verificar que el ticket no ha sido asignado
                TicketWS.ticket tckBD = ticketDAO.buscarTicketPorId(tck.ticketId);
                if (tckBD.agente.agenteId != 0)
                {
                    MessageBox.Show(
                    "Este ticket ya ha sido asignado a otro agente",
                    "Asignación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    Refrescar();
                    return;
                }

                TicketWS.estadoTicket estAsignado = new TicketWS.estadoTicket();
                estAsignado.estadoId = (int)Estado.Asignado;
                estAsignado.nombre = "ASIGNADO";

                tck.estado = estAsignado;

                // Registrar el cambio de estado
                var historialEstados = new BindingList<TicketWS.cambioEstadoTicket>();

                var cambioEstado = new TicketWS.cambioEstadoTicket();
                cambioEstado.comentario = "El ticket fue asignado a un " + agente.rol.nombre.ToLower() + ".";
                var ag = new TicketWS.agente();
                ag.agenteId = agente.agenteId;
                cambioEstado.agenteResponsable = ag;
                cambioEstado.estadoTo = estAsignado;

                historialEstados.Add(cambioEstado);

                tck.agente.agenteId = agente.agenteId;
                // Asignar la lista de cambios de estado
                tck.historialEstado = historialEstados.ToArray();

                if (ticketDAO.actualizarTicket(tck) > -1)
                {
                    MessageBox.Show(
                    "Se te ha asignado el ticket correctamente",
                    "Asignación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    // Enviar correo al alumno
                    EnviarEmailNotificacion(tck, cambioEstado);
                }
                else
                {
                    MessageBox.Show(
                    "Ha ocurrido un error con la asignación",
                    "Asginación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }

                Refrescar();
            }

        }

        private void EnviarEmailNotificacion(TicketWS.ticket tick, TicketWS.cambioEstadoTicket cambio)
        {
            if (tick.alumnoEmail != null)
            {
                if (EnvioCorreoNotificacion.NuevoCambioEstado(tick, cambio) == false)
                {
                    MessageBox.Show(
                    "Ha ocurrido un error al enviar el correo de notificación al alumno",
                    "Correo no enviado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
        }

        private void dgvTicketsEspera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TicketWS.ticket data = dgvTicketsEspera.Rows[e.RowIndex].DataBoundItem as TicketWS.ticket;

            dgvTicketsEspera.Rows[e.RowIndex].Cells["AbreviaturaBiblioteca"].Value = data.biblioteca.abreviatura;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreEmpleado"].Value = data.empleado.nombre + " " + data.empleado.apellidoPaterno + " " + data.empleado.apellidoMaterno;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreCategoria"].Value = data.categoria.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreUrgencia"].Value = data.urgencia.nombre;

        }

        private void Refrescar()
        {
            TicketWS.equipo equip = new TicketWS.equipo();
            equip.equipoId = agente.equipo.equipoId;

            TicketWS.estadoTicket estActivo = new TicketWS.estadoTicket();
            estActivo.estadoId = (int)Estado.Activo;
            TicketWS.estadoTicket estRecategorizado = new TicketWS.estadoTicket();
            estRecategorizado.estadoId = (int)Estado.Recategorizado;

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
}
