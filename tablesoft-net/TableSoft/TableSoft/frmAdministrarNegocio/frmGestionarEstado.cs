using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmGestionarEstado : Form
    {
        private EstadoTicketWS.EstadoTicketWSClient estadoDAO = new EstadoTicketWS.EstadoTicketWSClient();
        private EstadoTicketWS.estadoTicket estado;
        public frmGestionarEstado()
        {
            estado = new EstadoTicketWS.estadoTicket();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }

        public frmGestionarEstado(EstadoTicketWS.estadoTicket et)
        {
            estado = et;
            InitializeComponent();
            txtIDEstado.Text = estado.estadoId.ToString();
            txtNombre.Text = estado.nombre;
            txtDescripcion.Text = estado.descripcion;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del estado.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre del estado de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del estado.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del estado de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            estado.nombre = txtNombre.Text;
            estado.descripcion = txtDescripcion.Text;
            if (MessageBox.Show("¿Desea crear el registro?", "Crear Estado de Ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (estadoDAO.insertarEstadoTicket(estado) > 0)
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
            }
            else
            {
                MessageBox.Show(
                "No se ha creado el registro",
                "Registro no realizado",
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del estado.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre del estado de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del estado.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del estado de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            estado.nombre = txtNombre.Text;
            estado.descripcion = txtDescripcion.Text;
            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Estado de Ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (estadoDAO.actualizarEstadoTicket(estado) > -1)
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
    }
}
