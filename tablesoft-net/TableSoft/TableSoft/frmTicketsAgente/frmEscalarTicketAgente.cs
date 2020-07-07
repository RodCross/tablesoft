using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmEscalarTicketAgente : Form
    {
        private ProveedorWS.ProveedorWSClient proveedorDAO = new ProveedorWS.ProveedorWSClient();
        private BindingList<ProveedorWS.proveedor> proveedores;
        private TicketWS.ticket ticket;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private AgenteWS.agente agente;

        public frmEscalarTicketAgente(TicketWS.ticket tck)
        {
            ticket = tck;
            agente = frmInicioSesion.agenteLogueado;
            InitializeComponent();

            var provs = proveedorDAO.listarProveedores();
            if(provs == null)
            {
                proveedores = new BindingList<ProveedorWS.proveedor>();
            }
            else
            {
                proveedores = new BindingList<ProveedorWS.proveedor>(provs.ToList());
            }

            if(ticket.proveedor != null)
            {
                foreach(var prov in proveedores)
                {
                    if (prov.proveedorId == ticket.proveedor.proveedorId)
                    {
                        proveedores.Remove(prov);
                        break;
                    }
                }
            }
                
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.DataSource = proveedores;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void dgvProveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProveedorWS.proveedor data = dgvProveedores.Rows[e.RowIndex].DataBoundItem as ProveedorWS.proveedor;
            dgvProveedores.Rows[e.RowIndex].Cells["Ciudad"].Value = data.ciudad.nombre;
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            if (rtfComentario.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el comentario del escalado.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(rtfComentario.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El comentario del escalado de contener al menos una letra.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (MessageBox.Show("¿Desea escalar el ticket?", "Escalar ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProveedorWS.proveedor prov = (ProveedorWS.proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                TicketWS.proveedor proveGo = new TicketWS.proveedor();
                proveGo.proveedorId = prov.proveedorId;
                proveGo.razonSocial = prov.razonSocial;
                proveGo.ruc = prov.ruc;
                ticket.proveedor = proveGo;

                TicketWS.estadoTicket estEscalado = new TicketWS.estadoTicket();
                estEscalado.estadoId = (int)Estado.Escalado;
                estEscalado.nombre = "ESCALADO";
                ticket.estado = estEscalado;

                var ag = new TicketWS.agente();
                ag.agenteId = agente.agenteId;

                // Creamos el cambio de estado
                var cambioEstado = new TicketWS.cambioEstadoTicket();
                cambioEstado.comentario = "El ticket ha sido escalado";
                cambioEstado.agenteResponsable = ag;
                cambioEstado.estadoTo = estEscalado;
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

                // Creamos la transferencia externa
                var transfer = new TicketWS.transferenciaExterna();
                transfer.agenteResponsable = ag;
                transfer.comentario = rtfComentario.Text;
                transfer.proveedorTo = proveGo;
                transfer.transferenciaId = 0;

                // Registrar la transferenica

                BindingList<TicketWS.transferenciaExterna> historialTransfExterna;

                if (ticket.historialTransfExterna == null)
                {
                    historialTransfExterna = new BindingList<TicketWS.transferenciaExterna>();
                }
                else
                {
                    historialTransfExterna = new BindingList<TicketWS.transferenciaExterna>(ticket.historialTransfExterna.ToList());
                }
                historialTransfExterna.Add(transfer);

                ticket.historialTransfExterna = historialTransfExterna.ToArray();

                // Se actualiza el ticket
                if (ticketDAO.actualizarTicket(ticket) > -1)
                {
                    MessageBox.Show(
                        "Se ha registrado el escalado de ticket.",
                        "Escalado exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    // Enviar correo al alumno
                    cambioEstado.comentario = rtfComentario.Text;
                    EnviarEmailNotificacion(ticket, cambioEstado);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(
                        "Ha ocurrido un error con el escalado",
                        "Escalado no realizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    this.Close();
                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var provs = proveedorDAO.listarProveedoresPorNombre(txtBuscar.Text);
            if (provs == null)
            {
                proveedores = new BindingList<ProveedorWS.proveedor>();
            }
            else
            {
                proveedores = new BindingList<ProveedorWS.proveedor>(provs.ToList());
            }

            if (ticket.proveedor != null)
            {
                foreach (var prov in proveedores)
                {
                    if (prov.proveedorId == ticket.proveedor.proveedorId)
                    {
                        proveedores.Remove(prov);
                        break;
                    }
                }
            }

            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.DataSource = proveedores;
        }
    }
}
