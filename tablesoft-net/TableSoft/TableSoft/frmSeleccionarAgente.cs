using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmSeleccionarAgente : Form
    {
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private BindingList<AgenteWS.agente> agentes;

        public frmSeleccionarAgente()
        {
            
            InitializeComponent();
            agentes = new BindingList<AgenteWS.agente>(agenteDAO.listarAgentes().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = agentes;
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
            frmGestionarAgente frm = new frmGestionarAgente();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AgenteWS.agente age = (AgenteWS.agente)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarAgente frm = new frmGestionarAgente(age);
            frm.ShowDialog();
        }
    }
}
