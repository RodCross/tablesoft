using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmCerrarTicketAgente : Form
    {
        private TicketWS.ticket ticket;
        private TicketWS.estadoTicket estResuelto;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private TareaWS.TareaWSClient tareaDAO = new TareaWS.TareaWSClient();
        public frmCerrarTicketAgente(TicketWS.ticket tick)
        {
            InitializeComponent();

            ticket = tick;
            estResuelto = new TicketWS.estadoTicket();
            estResuelto.estadoId = (int)Estado.Cerrado;
            estResuelto.nombre = "CERRADO";
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rtfComentario.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el comentario de la resolución.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(rtfComentario.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El comentario no es válido.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            bool tareasCompletadas = true;

            var tck = new TareaWS.ticket();
            tck.ticketId = ticket.ticketId;
            var tareas = tareaDAO.listarTareasPorTicket(tck);
            
            if (tareas != null)
            {
                foreach (var t in tareas)
                {
                    if (t.completado == false)
                    {
                        tareasCompletadas = false;
                        break;
                    }

                }
            }


            if (tareasCompletadas)
            {
                if (MessageBox.Show("¿Está seguro de que desea cerrar el ticket?", "Resolución de ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var ag = new TicketWS.agente();
                    ag.agenteId = frmLogin.agenteLogueado.agenteId;

                    ticket.estado = estResuelto;

                    // Creamos el cambio de estado
                    var cambioEstado = new TicketWS.cambioEstadoTicket();
                    cambioEstado.comentario = rtfComentario.Text;
                    cambioEstado.agenteResponsable = ag;
                    cambioEstado.estadoTo = estResuelto;
                    cambioEstado.cambioEstadoTicketId = 0;

                    // Registrar el cambio de estado

                    // Agregarlo al historial del ticket
                    BindingList<TicketWS.cambioEstadoTicket> historialEstados;

                    if (ticket.historialEstado == null)
                    {
                        historialEstados = new BindingList<TicketWS.cambioEstadoTicket>();      // Si no tiene se crea una lista
                    }                                                                           // Sino se crea una lista a partir de este
                    else
                    {
                        historialEstados = new BindingList<TicketWS.cambioEstadoTicket>(ticket.historialEstado.ToList());
                    }
                    historialEstados.Add(cambioEstado);

                    // Se vuelve de nuevo a Array para ser asignado al ticket
                    ticket.historialEstado = historialEstados.ToArray();

                    // Se actualiza el ticket
                    if (ticketDAO.actualizarTicket(ticket) > -1)
                    {
                        MessageBox.Show(
                            "Se ha cerrado el ticket correctamente.",
                            "Actualización exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        // Enviar correo al alumno
                        EnviarEmailNotificacion(ticket, cambioEstado);

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ha ocurrido un error con la actualización",
                            "Actualización no realizada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tiene tareas no completadas, por favor complete las tareas antes de cerrar el ticket.",
                    "Tareas incompletas", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void EnviarEmailNotificacion(TicketWS.ticket tick, TicketWS.cambioEstadoTicket cambio)
        {
            if(tick.alumnoEmail != null)
            {
                if(EnvioCorreoNotificacion.NuevoCambioEstado(tick, cambio) == false)
                {
                    MessageBox.Show(
                    "Ha ocurrido un error al enviar el correo de notificación al alumno",
                    "Correo no enviado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
