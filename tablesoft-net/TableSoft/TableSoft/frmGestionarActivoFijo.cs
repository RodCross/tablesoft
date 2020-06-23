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
    public partial class frmGestionarActivoFijo : Form
    {
        private ActivoFijoWS.ActivoFijoWSClient activoFijoDAO = new ActivoFijoWS.ActivoFijoWSClient();
        private ActivoFijoWS.activoFijo activoFijo;
        public frmGestionarActivoFijo()
        {
            activoFijo = new ActivoFijoWS.activoFijo();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarActivoFijo(ActivoFijoWS.activoFijo activo)
        {
            activoFijo = activo;
            InitializeComponent();
            txtIDActivoFijo.Text = activoFijo.activoFijoId.ToString();
            txtCodigo.Text = activoFijo.nombre;
            txtMarca.Text = activoFijo.marca;
            txtTipo.Text = activoFijo.tipo;
            txtNombre.Text = activoFijo.nombre;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            activoFijo.codigo = txtCodigo.Text;
            activoFijo.marca = txtMarca.Text;
            activoFijo.tipo = txtTipo.Text;
            activoFijo.nombre = txtNombre.Text;
            if (activoFijoDAO.insertarActivoFijo(activoFijo) > 0)
            {
                MessageBox.Show(
                "Se ha guardado el registro.",
                "Guardado exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtIDActivoFijo.Text = activoFijo.activoFijoId.ToString();
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (activoFijoDAO.eliminarActivoFijo(activoFijo) > -1)
            {
                MessageBox.Show(
                    "Se ha eliminado el registro.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activoFijo.activoFijoId = Int32.Parse(txtIDActivoFijo.Text);
            activoFijo.codigo = txtCodigo.Text;
            activoFijo.marca = txtMarca.Text;
            activoFijo.tipo = txtTipo.Text;
            activoFijo.nombre = txtNombre.Text;
            if (activoFijoDAO.actualizarActivoFijo(activoFijo) > -1)
            {
                MessageBox.Show(
                    "Se ha actualizado el registro.",
                    "Actualización exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
