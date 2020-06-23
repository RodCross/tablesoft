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
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            UrgenciaWS.urgencia urg = (UrgenciaWS.urgencia)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarUrgencia frm = new frmGestionarUrgencia(urg);
            frm.ShowDialog();
        }
    }
}
