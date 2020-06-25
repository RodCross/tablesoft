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
    public partial class frmSeleccionarEstado : Form
    {
        private EstadoTicketWS.EstadoTicketWSClient estadoDAO = new EstadoTicketWS.EstadoTicketWSClient();
        private BindingList<EstadoTicketWS.estadoTicket> estados;

        public frmSeleccionarEstado()
        {
            InitializeComponent();
            var ests = estadoDAO.listarEstadosTicket();
            if(ests == null)
            {
                estados = new BindingList<EstadoTicketWS.estadoTicket>();
            }
            else
            {
                estados = new BindingList<EstadoTicketWS.estadoTicket>(ests);
            }
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = estados;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarEstado frm = new frmGestionarEstado();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var ests = estadoDAO.listarEstadosTicket();
                if (ests == null)
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>();
                }
                else
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>(ests);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = estados;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EstadoTicketWS.estadoTicket et = (EstadoTicketWS.estadoTicket)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarEstado frm = new frmGestionarEstado(et);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var ests = estadoDAO.listarEstadosTicket();
                if (ests == null)
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>();
                }
                else
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>(ests);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = estados;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EstadoTicketWS.estadoTicket et = (EstadoTicketWS.estadoTicket)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Estado de Ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (estadoDAO.eliminarEstadoTicket(et) > -1)
                {
                    MessageBox.Show(
                    "Se ha eliminado el registro exitosamente",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se eliminó el registro",
                    "Eliminación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                var ests = estadoDAO.listarEstadosTicket();
                if (ests == null)
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>();
                }
                else
                {
                    estados = new BindingList<EstadoTicketWS.estadoTicket>(ests);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = estados;
            }
            else
            {
                MessageBox.Show(
                "No se eliminó el registro",
                "Eliminación no realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }
    }
}
