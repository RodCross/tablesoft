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
    public partial class frmReasignarCategoriaTicketAgente : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;

        public frmReasignarCategoriaTicketAgente()
        {
            InitializeComponent();
            categorias = new BindingList<CategoriaWS.categoria>(categoriaDAO.listarCategorias().ToArray());
            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = categorias;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnReasignar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha cambiado la categoría anterior a la seleccionada.",
                "Reasignación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CategoriaWS.categoria[] nuevasCategorias = categoriaDAO.listarCategoriasPorNombre(txtBuscar.Text);
            if (nuevasCategorias != null)
            {
                categorias = new BindingList<CategoriaWS.categoria>(nuevasCategorias);
                dgvCategoria.DataSource = categorias;
            }
            else
            {
                dgvCategoria.DataSource = null;
            }
        }
    }
}
