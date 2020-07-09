using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmSeleccionarActivoFijo : Form
    {
        private ActivoFijoWS.ActivoFijoWSClient activoFijoDAO = new ActivoFijoWS.ActivoFijoWSClient();
        private BindingList<ActivoFijoWS.activoFijo> activosFijos;
        public frmSeleccionarActivoFijo()
        {
            InitializeComponent();
            activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = activosFijos;
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
            frmGestionarActivoFijo frm = new frmGestionarActivoFijo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
                dgvLista.DataSource = activoFijoDAO.listarActivosFijos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActivoFijoWS.activoFijo activo = (ActivoFijoWS.activoFijo)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarActivoFijo frm = new frmGestionarActivoFijo(activo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
                dgvLista.DataSource = activosFijos;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivoFijoWS.activoFijo activo = (ActivoFijoWS.activoFijo)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Activo Fijo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (activoFijoDAO.eliminarActivoFijo(activo) > -1)
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
                activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
                dgvLista.DataSource = activosFijos;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActivoFijoWS.activoFijo[] nuevosActivos = activoFijoDAO.listarActivosFijosPorNombre(txtBuscar.Text);
            if (nuevosActivos != null)
            {
                activosFijos = new BindingList<ActivoFijoWS.activoFijo>(nuevosActivos);
                dgvLista.DataSource = activosFijos;
            }
            else
            {
                dgvLista.DataSource = null;
            }
        }
    }
}
