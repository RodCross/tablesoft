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
    public partial class frmGestionarCategoria : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private CategoriaWS.categoria categoria;
        public frmGestionarCategoria()
        {
            categoria = new CategoriaWS.categoria();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnTareas.Visible = false;
        }

        public frmGestionarCategoria(CategoriaWS.categoria cat)
        {
            categoria = cat;
            InitializeComponent();
            txtIDCategoria.Text = categoria.categoriaId.ToString();
            txtNombre.Text = categoria.nombre;
            txtDescripcion.Text = categoria.descripcion;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnTareas.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones

            categoria.nombre = txtNombre.Text;
            categoria.descripcion = txtDescripcion.Text;

            if(categoriaDAO.insertarCategoria(categoria) > 0)
            {
                MessageBox.Show(
                    "Se ha guardado el registro.",
                    "Guardado exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            txtIDCategoria.Text = categoria.categoriaId.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validaciones


            if (categoriaDAO.eliminarCategoria(categoria) > -1)
            {
                MessageBox.Show(
                    "Se ha eliminado el registro.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validaciones


            if (categoriaDAO.actualizarCategoria(categoria) > -1)
            {
                MessageBox.Show(
                    "Se ha actualizado el registro.",
                    "Actualización exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            if(categoria.categoriaId > 0)
            {
                frmSeleccionarTareaPredeterminada frm = new frmSeleccionarTareaPredeterminada();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Esta categoria no ha sido registrada.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
