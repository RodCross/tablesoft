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
    public partial class frmSeleccionarCategoriaDisponible : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;
        public CategoriaWS.categoria categoriaSeleccionada;

        public frmSeleccionarCategoriaDisponible()
        {
            InitializeComponent();

            var catgs = categoriaDAO.listarCategoriasDisponibles();

            if (catgs == null)
            {
                categorias = new BindingList<CategoriaWS.categoria>();
            }
            else
            {
                categorias = new BindingList<CategoriaWS.categoria>(catgs);
            }

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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            categoriaSeleccionada = (CategoriaWS.categoria)dgvLista.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
