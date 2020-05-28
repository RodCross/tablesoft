using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.temp;

namespace TableSoft
{
    public partial class frmGestionarUrgencia : Form
    {
        public frmGestionarUrgencia()
        {
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarUrgencia(Urgencia urg)
        {
            InitializeComponent();
            txtIDUrgencia.Text = urg.UrgenciaId.ToString();
            txtNombre.Text = urg.Nombre;
            txtPlazoMaximo.Text = urg.PlazoMaximo.ToString();
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = false;
        }

        public frmGestionarUrgencia(int i)
        {
            InitializeComponent();
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
            MessageBox.Show(
                "Se ha guardado el registro.",
                "Guardado exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha eliminado el registro.",
                "Eliminación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(
                "Se ha actualizado el registro.",
                "Actualización exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
