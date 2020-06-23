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
                dgvLista.DataSource = activosFijos;
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
    }
}
