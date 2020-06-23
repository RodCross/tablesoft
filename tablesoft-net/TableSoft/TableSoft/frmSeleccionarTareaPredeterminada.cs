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
        private TareaPredeterminadaWS.categoria categoria;
        private TareaPredeterminadaWS.tareaPredeterminada tareaSeleccionada;
        private TareaPredeterminadaWS.TareaPredeterminadaWSClient tareaPredeterminadaDAO;
        private BindingList<TareaPredeterminadaWS.tareaPredeterminada> tareasPredeterminadas;

        public frmSeleccionarTareaPredeterminada(CategoriaWS.categoria cat)
        {
            InitializeComponent();
            categoria = new TareaPredeterminadaWS.categoria();
            tareaPredeterminadaDAO = new TareaPredeterminadaWS.TareaPredeterminadaWSClient();

            categoria.categoriaId = cat.categoriaId;
            categoria.nombre = cat.nombre;

            tareasPredeterminadas = new BindingList<TareaPredeterminadaWS.tareaPredeterminada>(tareaPredeterminadaDAO.listarTareasPredeterminadasPorCategoria(categoria));
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = tareasPredeterminadas;
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
            frmGestionarTareaPredeterminada frm = new frmGestionarTareaPredeterminada(categoria);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tareasPredeterminadas = new BindingList<TareaPredeterminadaWS.tareaPredeterminada>(tareaPredeterminadaDAO.listarTareasPredeterminadasPorCategoria(categoria));
                dgvLista.DataSource = tareasPredeterminadas;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            tareaSeleccionada = (TareaPredeterminadaWS.tareaPredeterminada)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarTareaPredeterminada frm = new frmGestionarTareaPredeterminada(tareaSeleccionada);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                tareasPredeterminadas = new BindingList<TareaPredeterminadaWS.tareaPredeterminada>(tareaPredeterminadaDAO.listarTareasPredeterminadasPorCategoria(categoria));
                dgvLista.DataSource = tareasPredeterminadas;
            }
        }
    }
}
