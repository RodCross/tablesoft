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
            proveedores = new BindingList<ProveedorWS.proveedor>(proveedorDAO.listarProveedores().ToArray());
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
            if (MessageBox.Show("¿Desea reasignar la categoria?", "Reasignar Categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProveedorWS.proveedor prov = (ProveedorWS.proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                TicketWS.estadoTicket estAsignado = new TicketWS.estadoTicket();
                estAsignado.estadoId = (int)Estado.Escalado;

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

                ticket.proveedor.proveedorId = prov.proveedorId;
                // Asignar la lista de cambios de estado
                ticket.historialEstado = historialEstados.ToArray();
                if (ticketDAO.actualizarTicket(ticket) > -1)
                {
                    MessageBox.Show(
                        "Se ha escalado el ticket al proveedor.",
                        "Escalamiento exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(
                        "Ha ocurrido un error con el escalado.",
                        "Escalamiento no realizado",
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
            ProveedorWS.proveedor[] nuevosProveedores = proveedorDAO.listarProveedoresPorNombre(txtBuscar.Text);
            if (nuevosProveedores != null)
            {
                proveedores = new BindingList<ProveedorWS.proveedor>(nuevosProveedores);
                dgvProveedores.DataSource = proveedores;
            }
            else
            {
                dgvProveedores.DataSource = null;
            }
        }
    }
}
