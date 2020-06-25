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
    public partial class frmGestionarEmpleado : Form
    {
        private EmpleadoWS.EmpleadoWSClient empleadoDAO = new EmpleadoWS.EmpleadoWSClient();
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private EmpleadoWS.empleado empleadoSel;

        public frmGestionarEmpleado()
        {
            InitializeComponent();
            LlenarCboBiblioteca();
            txtPass.Enabled = true;
            picEye.Visible = true;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }

        public frmGestionarEmpleado(EmpleadoWS.empleado emp)
        {
            empleadoSel = emp;
            InitializeComponent();
            LlenarCboBiblioteca();
            txtIDEmpleado.Text = emp.empleadoId.ToString();
            txtNombre.Text = emp.nombre;
            txtPaterno.Text = emp.apellidoPaterno;
            txtMaterno.Text = emp.apellidoMaterno;
            txtCodigo.Text = emp.codigo;
            txtDNI.Text = emp.dni;
            cboBiblioteca.SelectedValue = emp.biblioteca.bibliotecaId;
            txtEmailPersonal.Text = emp.personaEmail;
            txtDireccion.Text = emp.direccion;
            txtTel.Text = emp.telefono;
            txtPass.Enabled = false;
            picEye.Visible = false;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void LlenarCboBiblioteca()
        {
            cboBiblioteca.DataSource = bibliotecaDAO.listarBibliotecas();
            cboBiblioteca.DisplayMember = "nombre";
            cboBiblioteca.ValueMember = "bibliotecaId";
            cboBiblioteca.SelectedIndex = -1;
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
                    "Falta indicar el nombre del empleado.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtNombre.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El nombre del empleado de contener solo letras.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtPaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido parteno del empleado.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido parteno del empleado de contener solo letras.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtMaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido materno del empleado.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtMaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido materno del empleado de contener solo letras.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del empleado.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del empleado de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del empleado.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtTel.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El telefono del empleado de contener solo numeros.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la contraseña del empleado.",
                    "Error de contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtCodigo.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el codigo del empleado.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El codigo del empleado de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el dni del empleado.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtDNI.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El dni del empleado de contener solo numeros.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del empleado de contener 8 digitos.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar la biblioteca del empleado.",
                    "Error de biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailPersonal.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email personal del empleado.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email personal del empleado de contener un arroba.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email personal del empleado de contener un punto.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            empleadoSel = new EmpleadoWS.empleado();
            empleadoSel.nombre = txtNombre.Text;
            empleadoSel.apellidoPaterno = txtPaterno.Text;
            empleadoSel.apellidoMaterno = txtMaterno.Text;
            empleadoSel.codigo = txtCodigo.Text;
            empleadoSel.dni = txtDNI.Text;

            empleadoSel.biblioteca = new EmpleadoWS.biblioteca();

            empleadoSel.biblioteca.bibliotecaId = (int)cboBiblioteca.SelectedValue;
            empleadoSel.personaEmail = txtEmailPersonal.Text;
            empleadoSel.direccion = txtDireccion.Text;
            empleadoSel.telefono = txtTel.Text;
            empleadoSel.password = txtPass.Text;

            if (MessageBox.Show("¿Desea crear el registro?", "Crear Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (empleadoDAO.insertarEmpleado(empleadoSel) > 0)
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
                    "Falta indicar el nombre del empleado.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtNombre.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El nombre del empleado de contener solo letras.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtPaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido parteno del empleado.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido parteno del empleado de contener solo letras.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtMaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido materno del empleado.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtMaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido materno del empleado de contener solo letras.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del empleado.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del empleado de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del empleado.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtTel.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El telefono del empleado de contener solo numeros.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtCodigo.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el codigo del empleado.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El codigo del empleado de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el dni del empleado.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtDNI.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El dni del empleado de contener solo numeros.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del empleado de contener 8 digitos.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar la biblioteca del empleado.",
                    "Error de biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailPersonal.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email personal del empleado.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email personal del empleado de contener un arroba.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email personal del empleado de contener un punto.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            empleadoSel.nombre = txtNombre.Text;
            empleadoSel.apellidoPaterno = txtPaterno.Text;
            empleadoSel.apellidoMaterno = txtMaterno.Text;
            empleadoSel.codigo = txtCodigo.Text;
            empleadoSel.dni = txtDNI.Text;

            empleadoSel.biblioteca = new EmpleadoWS.biblioteca();

            empleadoSel.biblioteca.bibliotecaId = (int)cboBiblioteca.SelectedValue;
            empleadoSel.personaEmail = txtEmailPersonal.Text;
            empleadoSel.direccion = txtDireccion.Text;
            empleadoSel.telefono = txtTel.Text;

            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (empleadoDAO.actualizarEmpleado(empleadoSel) > -1)
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

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseDown;
            txtPass.PasswordChar = '\0';
        }

        private void picEye_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseEnter;
        }

        private void picEye_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.Eye;
        }

        private void picEye_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            pic.Image = Properties.Resources.EyeMouseEnter;
            txtPass.PasswordChar = '•';
        }
    }
}
