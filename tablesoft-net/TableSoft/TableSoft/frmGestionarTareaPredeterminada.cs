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
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmGestionarTareaPredeterminada : Form
    {
        TareaPredeterminadaWS.tareaPredeterminada tareaPredeterminada;
        TareaPredeterminadaWS.categoria categoria;
        TareaPredeterminadaWS.TareaPredeterminadaWSClient tareaPredeterminadaDAO;
        
        public frmGestionarTareaPredeterminada(TareaPredeterminadaWS.categoria cat)
        {
            InitializeComponent();
            tareaPredeterminadaDAO = new TareaPredeterminadaWS.TareaPredeterminadaWSClient();
            tareaPredeterminada = new TareaPredeterminadaWS.tareaPredeterminada();

            categoria = cat;

            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarTareaPredeterminada(TareaPredeterminadaWS.tareaPredeterminada tar)
        {
            InitializeComponent();
            tareaPredeterminadaDAO = new TareaPredeterminadaWS.TareaPredeterminadaWSClient();

            tareaPredeterminada = tar;

            txtIDTarea.Text = tareaPredeterminada.tareaPredeterminadaId.ToString();
            txtDesc.Text = tareaPredeterminada.descripcion;

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
            // Validaciones
            if(txtDesc.Text == "")
            {
                MessageBox.Show(
                    "Debe indicar una descripción.",
                    "Error de descripción",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDesc.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion debe contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            tareaPredeterminada.descripcion = txtDesc.Text;
            if (tareaPredeterminadaDAO.insertarTareaPredeterminada(tareaPredeterminada, categoria) > 0)
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
                "Ha ocurrido un error al crear el registro",
                "Registro no realizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            

            txtIDTarea.Text = tareaPredeterminada.tareaPredeterminadaId.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Tarea Predeterminada", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tareaPredeterminadaDAO.eliminarTareaPredeterminada(tareaPredeterminada) > -1)
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
                    "Eliminación no realizada",
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
            if (txtDesc.Text == "")
            {
                MessageBox.Show(
                    "Debe indicar una descripción.",
                    "Error de descripción",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDesc.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion debe contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            tareaPredeterminada.descripcion = txtDesc.Text;

            if (tareaPredeterminadaDAO.actualizarTareaPredeterminada(tareaPredeterminada) > -1)
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
                "Ha ocurrido un error al actualizar el registro",
                "Actualización no realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
