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
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmReasignarCategoriaTicketAgente : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;
        private TicketWS.ticket ticket;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private TicketWS.agente agente;
        public frmReasignarCategoriaTicketAgente(TicketWS.ticket tck)
        {
            ticket = tck;
            agente.agenteId = frmInicioSesion.agenteLogueado.agenteId;
            agente.codigo = frmInicioSesion.agenteLogueado.codigo;

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
                CategoriaWS.categoria cat = (CategoriaWS.categoria)dgvCategoria.CurrentRow.DataBoundItem;
                TicketWS.categoria cateGo = new TicketWS.categoria();
                cateGo.categoriaId = cat.categoriaId;
                ticket.categoria = cateGo;

                TicketWS.estadoTicket estAsignado = new TicketWS.estadoTicket();
                estAsignado.estadoId = (int)Estado.Recategorizado;
                ticket.estado = estAsignado;
                

                // Creamos el cambio de estado
                var ag = new TicketWS.agente();
                ag.agenteId = agente.agenteId;
                var cambioEstado = new TicketWS.cambioEstadoTicket();
                cambioEstado.comentario = rtfComentario.Text;
                cambioEstado.agenteResponsable = ag;
                cambioEstado.estadoTo = estAsignado;

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
                
                
                // Se actualiza el ticket
                if (ticketDAO.actualizarTicket(ticket) > -1)
                {
                    MessageBox.Show(
                        "Se ha cambiado la categoría seleccionada.",
                        "Reasignación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
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
