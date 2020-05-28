using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.temp;

namespace TableSoft
{
    public partial class frmSeleccionarUrgencia : Form
    {

        BindingList<Urgencia> urgencias = new BindingList<Urgencia>();
        Urgencia urg1 = new Urgencia(1, "Emergencia", 2);
        Urgencia urg2 = new Urgencia(2, "Incidente", 24);
        Urgencia urg3 = new Urgencia(3, "Consulta", 72);

        public frmSeleccionarUrgencia()
        {
            InitializeComponent();
            urgencias.Add(urg1);
            urgencias.Add(urg2);
            urgencias.Add(urg3);
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
            Urgencia urg = (Urgencia) dgvLista.CurrentRow.DataBoundItem;
            frmGestionarUrgencia frm = new frmGestionarUrgencia(urg);
            frm.ShowDialog();
        }
    }
}
