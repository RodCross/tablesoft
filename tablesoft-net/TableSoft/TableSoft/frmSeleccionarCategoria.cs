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
    public partial class frmSeleccionarCategoria : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;

        public frmSeleccionarCategoria()
        {
            InitializeComponent();
            categorias = new BindingList<CategoriaWS.categoria>(categoriaDAO.listarCategorias().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = categorias;
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
            frmGestionarCategoria frm = new frmGestionarCategoria();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CategoriaWS.categoria cat = (CategoriaWS.categoria)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarCategoria frm = new frmGestionarCategoria(cat);
            frm.ShowDialog();
        }
    }
}
