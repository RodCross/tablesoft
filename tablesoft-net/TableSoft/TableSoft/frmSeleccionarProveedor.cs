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
    public partial class frmSeleccionarProveedor : Form
    {
        private ProveedorWS.ProveedorWSClient proveedorDAO = new ProveedorWS.ProveedorWSClient();
        private BindingList<ProveedorWS.proveedor> proveedores;

        public frmSeleccionarProveedor()
        {
            InitializeComponent();
            proveedores = new BindingList<ProveedorWS.proveedor>(proveedorDAO.listarProveedores().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = proveedores;
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
            frmGestionarProveedor frm = new frmGestionarProveedor();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProveedorWS.proveedor prov = (ProveedorWS.proveedor)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarProveedor frm = new frmGestionarProveedor(prov);
            frm.ShowDialog();
        }
    }
}
