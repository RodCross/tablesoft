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
    public partial class frmActualizarEstadoTicketAgente : Form
    {
        private EstadoTicketWS.EstadoTicketWSClient estadoDAO = new EstadoTicketWS.EstadoTicketWSClient();
        private BindingList<EstadoTicketWS.estadoTicket> estados;

        public frmActualizarEstadoTicketAgente()
        {
            InitializeComponent();
            estados = new BindingList<EstadoTicketWS.estadoTicket>(estadoDAO.listarEstadosTicket().ToArray());
            dgvActualizar.AutoGenerateColumns = false;
            dgvActualizar.DataSource = estados;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha actualizado correctamente el estado del ticket.",
                "Actualización de estado exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
