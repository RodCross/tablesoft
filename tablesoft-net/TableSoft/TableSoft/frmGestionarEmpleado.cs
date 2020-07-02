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
    public partial class frmGestionarEmpleado : Form
    {
        private EmpleadoWS.EmpleadoWSClient empleadoDAO = new EmpleadoWS.EmpleadoWSClient();
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private EmpleadoWS.empleado empleadoSel;
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();

        public frmGestionarEmpleado()
        {
            InitializeComponent();
            LlenarCboBiblioteca();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            chkActivo.Visible = false;
            lblActivo.Visible = false;
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
            txtCodigo.ReadOnly = true;
            txtDNI.Text = emp.dni;
            cboBiblioteca.SelectedValue = emp.biblioteca.bibliotecaId;
            txtEmailPersonal.Text = emp.personaEmail;
            txtDireccion.Text = emp.direccion;
            txtTel.Text = emp.telefono;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
            chkActivo.Checked = emp.activo;
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
                    "Falta indicar el apellido paterno del empleado.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido paterno del empleado de contener solo letras.",
                    "Error de apellido paterno",
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
            if (txtTel.Text.Length != 9)
            {
                MessageBox.Show("El telefono del empleado debe de tener 9 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    "El codigo del empleado debe de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del empleado debe de contener 8 digitos.",
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
            if (Regex.Matches(txtDNI.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El dni del empleado debe de contener 8 digitos.",
                    "Error de dni",
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
            empleadoSel.password = PasswordGenerator.GenerateRandomPassword();

            if (MessageBox.Show("¿Desea crear el registro?", "Crear Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rpta = personaDAO.verificarCorreo(txtEmailPersonal.Text);
                EmpleadoWS.empleado empBusc = empleadoDAO.buscarEmpleadoPorCodigo(empleadoSel.codigo);

                if (rpta == 1)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese correo",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if (empBusc.empleadoId != 0)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese código",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }

                if (rpta == -1) { 
                    if (empleadoDAO.insertarEmpleado(empleadoSel) > 0)
                    {
                        MessageBox.Show(
                        "Se ha creado el registro exitosamente",
                        "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        EnviarEmailRegistrado(empleadoSel);
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
                    "Ya existe un empleado con ese código",
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
                    "Falta indicar el apellido paterno del empleado.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido paterno del empleado de contener solo letras.",
                    "Error de apellido paterno",
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
            if (txtTel.Text.Length != 9)
            {
                MessageBox.Show("El telefono del empleado debe de tener 9 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    "El codigo del empleado debe de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del empleado debe de contener 8 digitos.",
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
            if (Regex.Matches(txtDNI.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El dni del empleado debe de contener 8 digitos.",
                    "Error de dni",
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
            empleadoSel.activo = chkActivo.Checked;

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

        private void EnviarEmailRegistrado(EmpleadoWS.empleado emp)
        {
            string body = "Estimado " + emp.nombre + " " + emp.apellidoPaterno + ":\n";
            body += "Tienes un nuevo usuario en el sistema Yanapay.\n";
            body += "Puedes iniciar sesion como empleado con las siguientes credenciales:\n";
            body += "Email: " + emp.personaEmail + "\n";
            body += "Password: " + emp.password + "\n";
            body += "Saludos,\nSistema de mesa de ayuda Yanapay";

            YanapayEmail email = new YanapayEmail()
            {
                FromAddress = "noreply.yanapay@gmail.com",
                ToRecipients = emp.personaEmail,
                Subject = "Yanapay - Nuevo empleado",
                Body = body,
                IsHtml = false
            };

            GmailAPI.ConectarAPI(email);
        }
    }
}
