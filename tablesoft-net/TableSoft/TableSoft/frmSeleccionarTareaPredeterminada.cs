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
    public partial class frmSeleccionarTareaPredeterminada : Form
    {
        private CategoriaWS.categoria categoria;
        private TareaPredeterminadaWS.TareaPredeterminadaWSClient tareaPredeterminadaDAO = new TareaPredeterminadaWS.TareaPredeterminadaWSClient();
        private BindingList<TareaPredeterminadaWS.tareaPredeterminada> tareasPredeterminadas;
        public frmSeleccionarTareaPredeterminada(CategoriaWS.categoria cat)
        {
            categoria = cat;
            //tareasPredeterminadas = new BindingList<TareaPredeterminadaWS.tareaPredeterminada>(tareaPredeterminadaDAO.listarTareasPredeterminadasPorCategoria(categoria));
            InitializeComponent();
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
            frmGestionarTareaPredeterminada frm = new frmGestionarTareaPredeterminada();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmGestionarTareaPredeterminada frm = new frmGestionarTareaPredeterminada(1);
            frm.ShowDialog();
        }
    }
}
