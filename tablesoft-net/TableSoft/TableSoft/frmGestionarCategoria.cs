using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre de la categoria.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if( Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la categoria de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion de la categoria.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion de la categoria de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            categoria.nombre = txtNombre.Text;
            categoria.descripcion = txtDescripcion.Text;

                if (categoriaDAO.insertarCategoria(categoria) > 0)
                {
                    MessageBox.Show(
                    "Se ha creado el registro exitosamente",
                    "Registro exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha creado el registro",
                    "Registro no realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                txtIDCategoria.Text = categoria.categoriaId.ToString();
                this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validaciones


            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (categoriaDAO.eliminarCategoria(categoria) > -1)
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
                    "Ha ocurrido un error al eliminar el registro",
                    "Error de eliminación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                this.DialogResult = DialogResult.OK;
            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre de la categoria.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la categoria de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion de la categoria.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion de la categoria de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            categoria.nombre = txtNombre.Text;
            categoria.descripcion = txtDescripcion.Text;
                if (categoriaDAO.actualizarCategoria(categoria) > -1)
                {
                    MessageBox.Show(
                    "Se ha actualizado el registro exitosamente",
                    "Actualización exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha realizado la actualización",
                    "Actualización no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                this.DialogResult = DialogResult.OK;
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            if(categoria.categoriaId > 0)
            {
                frmSeleccionarTareaPredeterminada frm = new frmSeleccionarTareaPredeterminada(categoria);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Esta categoria no ha sido registrada.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            
        }
    }
}
