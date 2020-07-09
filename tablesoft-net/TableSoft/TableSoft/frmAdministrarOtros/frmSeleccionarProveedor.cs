using System;
using System.ComponentModel;
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
            var provs = proveedorDAO.listarProveedores();
            if (provs == null)
            {
                proveedores = new BindingList<ProveedorWS.proveedor>();
            }
            else
            {
                proveedores = new BindingList<ProveedorWS.proveedor>(provs);
            }
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = proveedores;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProveedorWS.proveedor data = dgvLista.Rows[e.RowIndex].DataBoundItem as ProveedorWS.proveedor;
            dgvLista.Rows[e.RowIndex].Cells["Ciudad"].Value = data.ciudad.nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarProveedor frm = new frmGestionarProveedor();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var provs = proveedorDAO.listarProveedores();
                if (provs == null)
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>();
                }
                else
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>(provs);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = proveedores;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProveedorWS.proveedor prov = (ProveedorWS.proveedor)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarProveedor frm = new frmGestionarProveedor(prov);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var provs = proveedorDAO.listarProveedores();
                if (provs == null)
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>();
                }
                else
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>(provs);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = proveedores;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedorWS.proveedor prov = (ProveedorWS.proveedor)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (proveedorDAO.eliminarProveedor(prov) > -1)
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
                var provs = proveedorDAO.listarProveedores();
                if (provs == null)
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>();
                }
                else
                {
                    proveedores = new BindingList<ProveedorWS.proveedor>(provs);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = proveedores;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProveedorWS.proveedor[] nuevosProveedores = proveedorDAO.listarProveedoresPorNombre(txtBuscar.Text);
            if (nuevosProveedores != null)
            {
                proveedores = new BindingList<ProveedorWS.proveedor>(nuevosProveedores);
                dgvLista.DataSource = proveedores;
            }
            else
            {
                dgvLista.DataSource = null;
            }
        }
    }
}
