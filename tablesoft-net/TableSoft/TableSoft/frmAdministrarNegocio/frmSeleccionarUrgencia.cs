using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmSeleccionarUrgencia : Form
    {
        private UrgenciaWS.UrgenciaWSClient urgenciaDAO = new UrgenciaWS.UrgenciaWSClient();
        private BindingList<UrgenciaWS.urgencia> urgencias;

        public frmSeleccionarUrgencia()
        {
            InitializeComponent();
            urgencias = new BindingList<UrgenciaWS.urgencia>(urgenciaDAO.listarUrgencias().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = urgencias;
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
            frmGestionarUrgencia frm = new frmGestionarUrgencia();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                urgencias = new BindingList<UrgenciaWS.urgencia>(urgenciaDAO.listarUrgencias().ToArray());
                dgvLista.DataSource = urgenciaDAO.listarUrgencias();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            UrgenciaWS.urgencia urg = (UrgenciaWS.urgencia)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarUrgencia frm = new frmGestionarUrgencia(urg);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                urgencias = new BindingList<UrgenciaWS.urgencia>(urgenciaDAO.listarUrgencias().ToArray());
                dgvLista.DataSource = urgencias;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UrgenciaWS.urgencia urg = (UrgenciaWS.urgencia)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Urgencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (urgenciaDAO.eliminarUrgencia(urg) > -1)
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
                urgencias = new BindingList<UrgenciaWS.urgencia>(urgenciaDAO.listarUrgencias().ToArray());
                dgvLista.DataSource = urgencias;
            }
        }
    }
}
