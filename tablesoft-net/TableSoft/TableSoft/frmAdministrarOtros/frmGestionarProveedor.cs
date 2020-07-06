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
    public partial class frmGestionarProveedor : Form
    {
        private ProveedorWS.ProveedorWSClient proveedorDAO = new ProveedorWS.ProveedorWSClient();
        private PaisWS.PaisWSClient paisDAO = new PaisWS.PaisWSClient();
        private CiudadWS.CiudadWSClient ciudadDAO = new CiudadWS.CiudadWSClient();
        private ProveedorWS.proveedor proveedor;
        private CiudadWS.pais pais;

        public frmGestionarProveedor()
        {
            pais = new CiudadWS.pais();
            InitializeComponent();
            LlenarCboPais();
            cboCiudad.Enabled = false;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }

        public frmGestionarProveedor(ProveedorWS.proveedor prov)
        {
            proveedor = prov;
            pais = new CiudadWS.pais();
            InitializeComponent();
            LlenarCboPais();
            txtIDProveedor.Text = proveedor.proveedorId.ToString();
            txtRUC.Text = proveedor.ruc;
            txtRazonSocial.Text = proveedor.razonSocial;
            txtDireccion.Text = proveedor.direccion;
            txtTelefono.Text = proveedor.telefono;
            txtEmail.Text = proveedor.email;
            cboPais.SelectedIndex = proveedor.ciudad.pais.paisId - 1;
            cboCiudad.SelectedValue = proveedor.ciudad.nombre;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void LlenarCboPais()
        {
            cboPais.DataSource = paisDAO.listarPaises();
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "paisId";
            cboPais.SelectedIndex = -1;
        }

        public void LlenarCboCiudad()
        {
            cboCiudad.DataSource = ciudadDAO.listarCiudadesDePais(pais);
            cboCiudad.DisplayMember = "nombre";
            cboCiudad.ValueMember = "nombre";
            cboCiudad.SelectedIndex = 0;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRUC.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el ruc del proveedor.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtRUC.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El ruc del proveedor de contener solo numeros.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if(Regex.Matches(txtRUC.Text, @"[0-9]").Count != 11)
            {
                MessageBox.Show(
                    "El ruc del proveedor de contener 11 digitos.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la razon social del proveedor.",
                    "Error en la razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if(txtRazonSocial.Text.Length > 200)
            {
                MessageBox.Show(
                    "La longitud de la razon social no debe ser mayor a 200 caracteres",
                    "Error en la razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtRazonSocial.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La razon social del proveedor de contener al menos una letra.",
                    "Error de razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del proveedor.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del proveedor de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboPais.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Falta seleccionar el pais del proveedor.",
                    "Error de pais",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboCiudad.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Falta seleccionar la ciudad del proveedor.",
                    "Error de ciudad",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del proveedor.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtTelefono.Text, @"[0-9]").Count == 0)
            {
                MessageBox.Show(
                    "El telefono del proveedor de contener al menos un numero.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTelefono.Text.Length != 7)
            {
                MessageBox.Show("El telefono del proveedor debe de tener 7 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email del proveedor.",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show(
                    "Existe un error en el formato del email",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            proveedor = new ProveedorWS.proveedor();
            proveedor.ruc = txtRUC.Text;
            proveedor.razonSocial = txtRazonSocial.Text;
            proveedor.direccion = txtDireccion.Text;

            proveedor.ciudad = new ProveedorWS.ciudad();
            CiudadWS.ciudad ciudadAux = (CiudadWS.ciudad)cboCiudad.SelectedItem;
            proveedor.ciudad.ciudadId = ciudadAux.ciudadId;
            proveedor.ciudad.nombre = ciudadAux.nombre;

            proveedor.ciudad.pais = new ProveedorWS.pais();
            PaisWS.pais paisAux = (PaisWS.pais)cboPais.SelectedItem;
            proveedor.ciudad.pais.paisId = paisAux.paisId;
            proveedor.ciudad.pais.nombre = paisAux.nombre;

            proveedor.telefono = txtTelefono.Text;
            proveedor.email = txtEmail.Text;
            if (MessageBox.Show("¿Desea crear el registro?", "Crear Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (proveedorDAO.insertarProveedor(proveedor) > 0)
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
                txtIDProveedor.Text = proveedor.proveedorId.ToString();
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            if (txtRUC.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el ruc del proveedor.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtRUC.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El ruc del proveedor de contener solo numeros.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtRUC.Text, @"[0-9]").Count != 11)
            {
                MessageBox.Show(
                    "El ruc del proveedor de contener 11 digitos.",
                    "Error de ruc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la razon social del proveedor.",
                    "Error de razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtRazonSocial.Text.Length > 200)
            {
                MessageBox.Show(
                    "La longitud de la razon social no debe ser mayor a 200 caracteres",
                    "Error en la razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtRazonSocial.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La razon social del proveedor de contener al menos una letra.",
                    "Error de razon social",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del proveedor.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del proveedor de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboPais.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Falta seleccionar el pais del proveedor.",
                    "Error de pais",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboCiudad.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Falta seleccionar la ciudad del proveedor.",
                    "Error de ciudad",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del proveedor.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtTelefono.Text, @"[0-9]").Count == 0)
            {
                MessageBox.Show(
                    "El telefono del proveedor de contener al menos un numero.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTelefono.Text.Length != 7)
            {
                MessageBox.Show("El telefono del proveedor debe de tener 7 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email del proveedor.",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show(
                    "Existe un error en el formato del email",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            proveedor.ruc = txtRUC.Text;
            proveedor.razonSocial = txtRazonSocial.Text;
            proveedor.direccion = txtDireccion.Text;

            CiudadWS.ciudad ciudadAux = (CiudadWS.ciudad)cboCiudad.SelectedItem;
            proveedor.ciudad.ciudadId = ciudadAux.ciudadId;
            proveedor.ciudad.nombre = ciudadAux.nombre;

            PaisWS.pais paisAux = (PaisWS.pais)cboPais.SelectedItem;
            proveedor.ciudad.pais.paisId = paisAux.paisId;
            proveedor.ciudad.pais.nombre = paisAux.nombre;

            proveedor.telefono = txtTelefono.Text;
            proveedor.email = txtEmail.Text;
            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (proveedorDAO.actualizarProveedor(proveedor) > -1)
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

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPais.SelectedIndex != -1)
            {
                if (!cboCiudad.Enabled)
                {
                    cboCiudad.Enabled = true;
                }
                PaisWS.pais paisAux = (PaisWS.pais)cboPais.SelectedItem;
                pais.paisId = paisAux.paisId;
                pais.nombre = paisAux.nombre;
                LlenarCboCiudad();
            }
            else
            {
                cboCiudad.SelectedIndex = -1;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='+'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
