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

        public frmEscalarTicketAgente()
        {
            InitializeComponent();
            proveedores = new BindingList<ProveedorWS.proveedor>(proveedorDAO.listarProveedores().ToArray());
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.DataSource = proveedores;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha escalado el ticket al proveedor.",
                "Escalamiento exitoso",
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
