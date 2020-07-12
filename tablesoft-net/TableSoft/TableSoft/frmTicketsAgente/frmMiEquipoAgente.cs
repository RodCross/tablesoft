using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmMiEquipoAgente : Form
    {
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> ticketsEnEspera;
        public AgenteWS.agente agente = frmLogin.agenteLogueado;
        private TicketWS.equipo equipo;
        private TicketWS.estadoTicket estActivo;
        private TicketWS.estadoTicket estRecategorizado;


        public frmMiEquipoAgente()
        {
            InitializeComponent();
            
            equipo = new TicketWS.equipo
            {
                equipoId = agente.equipo.equipoId
            };

            estActivo = new TicketWS.estadoTicket
            {
                estadoId = (int)Estado.Activo
            };

            estRecategorizado = new TicketWS.estadoTicket
            {
                estadoId = (int)Estado.Recategorizado
            };

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
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreEmpleado"].Value = data.empleado.apellidoPaterno + " " + data.empleado.apellidoMaterno + ", " + data.empleado.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["FechaApertura"].Value = data.fechaEnvio.Replace("T", " ");
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreCategoria"].Value = data.categoria.nombre;
            dgvTicketsEspera.Rows[e.RowIndex].Cells["NombreUrgencia"].Value = data.urgencia.nombre;

        }

        private void Refrescar()
        {
            TicketWS.ticket[] arrTickets = ticketDAO.listarTicketsPorEstadoPorEquipo(estActivo, equipo);
            if (arrTickets == null)
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>();
            }
            else
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>(arrTickets);
            }

            arrTickets = ticketDAO.listarTicketsPorEstadoPorEquipo(estRecategorizado, equipo);
            if (arrTickets != null)
            {
                foreach (TicketWS.ticket t in arrTickets)
                {
                    ticketsEnEspera.Add(t);
                }
            }

            dgvTicketsEspera.AutoGenerateColumns = false;
            dgvTicketsEspera.DataSource = ticketsEnEspera;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
