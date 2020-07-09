using System;
using System.Text.RegularExpressions;
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
        }

        public frmGestionarActivoFijo(ActivoFijoWS.activoFijo activo)
        {
            activoFijo = activo;
            InitializeComponent();
            txtIDActivoFijo.Text = activoFijo.activoFijoId.ToString();
            txtCodigo.Text = activoFijo.codigo;
            txtMarca.Text = activoFijo.marca;
            txtTipo.Text = activoFijo.tipo;
            txtNombre.Text = activoFijo.nombre;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("No ha ingresado el código", "Error de código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("El código es un campo numérico", "Error de código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigo.Text.Length > 5)
            {
                MessageBox.Show("El código no debe tener más de 5 digitos", "Error de código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtMarca.Text) || String.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("No ha ingresado la marca del activo fijo", "Error de marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtMarca.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La marca del activo fijo debe contener al menos una letra",
                    "Error de marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (String.IsNullOrEmpty(txtTipo.Text) || String.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("No ha ingresado el tipo de activo fijo", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtTipo.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El tipo del activo fijo debe contener al menos una letra",
                    "Error de tipo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("No ha ingresado el nombre del activo fijo", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre del activo fijo debe contener al menos una letra",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            activoFijo.codigo = txtCodigo.Text;
            activoFijo.marca = txtMarca.Text;
            activoFijo.tipo = txtTipo.Text;
            activoFijo.nombre = txtNombre.Text;


            if (activoFijoDAO.insertarActivoFijo(activoFijo) > 0)
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
            txtIDActivoFijo.Text = activoFijo.activoFijoId.ToString();
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("No ha ingresado el código", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("El código es un campo numérico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigo.Text.Length > 5)
            {
                MessageBox.Show("El código no debe tener más de 5 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtMarca.Text) || String.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("No ha ingresado la marca", "Error de marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtMarca.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show("La marca debe contener al menos una letra", "Error de marca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtTipo.Text) || String.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("No ha ingresado el tipo", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtTipo.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show("El tipo debe contener al menos una letra", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("No ha ingresado el nombre", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show("El nombre debe contener al menos una letra", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            activoFijo.activoFijoId = Int32.Parse(txtIDActivoFijo.Text);
            activoFijo.codigo = txtCodigo.Text;
            activoFijo.marca = txtMarca.Text;
            activoFijo.tipo = txtTipo.Text;
            activoFijo.nombre = txtNombre.Text;


            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Activo Fijo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (activoFijoDAO.actualizarActivoFijo(activoFijo) > -1)
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
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
