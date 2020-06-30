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
    public partial class frmReasignarCategoriaTicketAgente : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private List<CategoriaWS.categoria> categorias;
        private TicketWS.ticket ticket;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private AgenteWS.agente agente;
        public frmReasignarCategoriaTicketAgente(TicketWS.ticket tck)
        {
            ticket = tck;
            agente = frmInicioSesion.agenteLogueado;
            InitializeComponent();
            categorias = new List<CategoriaWS.categoria>(categoriaDAO.listarCategorias().ToArray());
            CategoriaWS.categoria catAux;
            int n = categorias.Count;
            for (int i = 0; i < n; i++)
            {
                catAux = categorias[i];
                if (catAux.categoriaId == ticket.categoria.categoriaId)
                {
                    categorias.Remove(catAux);
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
                TicketWS.estadoTicket estAsignado = new TicketWS.estadoTicket();
                estAsignado.estadoId = (int)Estado.Recategorizado;
                TicketWS.categoria catego = new TicketWS.categoria();
                catego.categoriaId = cat.categoriaId;
                ticket.estado = estAsignado;

                // Registrar el cambio de estado
                var historialEstados = new BindingList<TicketWS.cambioEstadoTicket>();

                var cambioEstado = new TicketWS.cambioEstadoTicket();
                cambioEstado.comentario = rtfComentario.Text;
                var ag = new TicketWS.agente();
                ag.agenteId = agente.agenteId;
                cambioEstado.agenteResponsable = ag;
                cambioEstado.estadoTo = estAsignado;

                historialEstados.Add(cambioEstado);

                //ticket.categoria.categoriaId = cat.categoriaId;
                ticket.categoria = catego;
                ticket.agente = null;
                // Asignar la lista de cambios de estado
                ticket.historialEstado = historialEstados.ToArray();
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
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CategoriaWS.categoria[] nuevasCategorias = categoriaDAO.listarCategoriasPorNombre(txtBuscar.Text);
            if (nuevasCategorias != null)
            {
                categorias = new List<CategoriaWS.categoria>(nuevasCategorias);
                dgvCategoria.DataSource = categorias;
            }
            else
            {
                dgvCategoria.DataSource = null;
            }
        }
    }
}
