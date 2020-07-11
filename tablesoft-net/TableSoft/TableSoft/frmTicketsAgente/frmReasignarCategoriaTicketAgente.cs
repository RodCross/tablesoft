using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmReasignarCategoriaTicketAgente : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;
        private TicketWS.ticket ticket;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private TicketWS.agente agente = new TicketWS.agente();

        public frmReasignarCategoriaTicketAgente(TicketWS.ticket tck)
        {
            ticket = tck;
            agente.agenteId = frmLogin.agenteLogueado.agenteId;

            InitializeComponent();

            var cats = categoriaDAO.listarCategorias();

            if(cats == null)
            {
                categorias = new BindingList<CategoriaWS.categoria>();
            }
            else
            {
                categorias = new BindingList<CategoriaWS.categoria>(cats.ToList());
            }

            foreach(var cat in categorias)
            {
                if(cat.categoriaId == ticket.categoria.categoriaId)
                {
                    categorias.Remove(cat);
                    break;
                }
            }

            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = categorias;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnReasignar_Click(object sender, EventArgs e)
        {
            if (rtfComentario.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el comentario de la recategorizacion.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(rtfComentario.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El comentario de la recategorizacion de contener al menos una letra.",
                    "Error de comentario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (MessageBox.Show("¿Desea reasignar la categoria?", "Reasignar Categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ticket.agente = null;
                
                CategoriaWS.categoria cat = (CategoriaWS.categoria)dgvCategoria.CurrentRow.DataBoundItem;
                TicketWS.categoria cateGo = new TicketWS.categoria();
                cateGo.nombre = cat.nombre;
                cateGo.categoriaId = cat.categoriaId;
                ticket.categoria = cateGo;

                TicketWS.estadoTicket estRecategorizado = new TicketWS.estadoTicket();
                estRecategorizado.estadoId = (int)Estado.Recategorizado;
                estRecategorizado.nombre = "RECATEGORIZADO";
                ticket.estado = estRecategorizado;
                
                var ag = new TicketWS.agente();
                ag.agenteId = agente.agenteId;

                // Creamos el cambio de estado
                var cambioEstado = new TicketWS.cambioEstadoTicket();
                cambioEstado.comentario = "El ticket ha sido recategorizado";
                cambioEstado.agenteResponsable = ag;
                cambioEstado.estadoTo = estRecategorizado;
                cambioEstado.cambioEstadoTicketId = 0;

                // Registrar el cambio de estado

                // Agregarlo al historial del ticket
                BindingList<TicketWS.cambioEstadoTicket> historialEstados;

                if(ticket.historialEstado == null)
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

                // Creamos la transferencia interna
                var transfer = new TicketWS.transferenciaInterna();
                transfer.agenteResponsable = ag;
                transfer.comentario = rtfComentario.Text;
                transfer.categoriaTo = cateGo;
                transfer.transferenciaId = 0;

                // Registrar la transferenica

                BindingList<TicketWS.transferenciaInterna> historialTransfInterna;

                if(ticket.historialTransfInterna == null)
                {
                    historialTransfInterna = new BindingList<TicketWS.transferenciaInterna>();
                }
                else
                {
                    historialTransfInterna = new BindingList<TicketWS.transferenciaInterna>(ticket.historialTransfInterna.ToList());
                }
                historialTransfInterna.Add(transfer);

                ticket.historialTransfInterna = historialTransfInterna.ToArray();

                // Se actualiza el ticket
                if (ticketDAO.actualizarTicket(ticket) > -1)
                {
                    MessageBox.Show(
                        "Se ha cambiado la categoría seleccionada.",
                        "Reasignación exitosa",
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
                        "Ha ocurrido un error con la reasignación",
                        "Reasignación no realizada",
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
            var cats = categoriaDAO.listarCategoriasPorNombre(txtBuscar.Text);

            if (cats == null)
            {
                categorias = new BindingList<CategoriaWS.categoria>();
            }
            else
            {
                categorias = new BindingList<CategoriaWS.categoria>(cats.ToList());
            }

            foreach (var cat in categorias)
            {
                if (cat.categoriaId == ticket.categoria.categoriaId)
                {
                    categorias.Remove(cat);
                    break;
                }
            }

            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = categorias;
        }
    }
}
