using System;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmGestionarTareasTicket : Form
    {
        private TareaWS.TareaWSClient tareaDAO = new TareaWS.TareaWSClient();
        private TareaWS.tarea tarea;

        public frmGestionarTareasTicket()
        {
            tarea = new TareaWS.tarea();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
        }

        public frmGestionarTareasTicket(TareaWS.tarea tarea)
        {
            InitializeComponent();
            txtIDTarea.Text = tarea.tareaId.ToString();
            txtDescripcion.Text = tarea.descripcion;
            chkCompletado.Checked = tarea.completado;
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
            if(txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            tarea.descripcion = txtDescripcion.Text;

            MessageBox.Show(
                "Se ha guardado el registro.",
                "Guardado exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            txtDescripcion.Text = tarea.tareaId.ToString();
            this.DialogResult = DialogResult.OK;
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
