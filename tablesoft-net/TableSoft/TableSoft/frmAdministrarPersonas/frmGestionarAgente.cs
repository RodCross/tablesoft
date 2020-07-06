using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.AgenteWS;
using TableSoft.EmailWS;

namespace TableSoft
{
    public partial class frmGestionarAgente : Form
    {
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private RolWS.RolWSClient rolDAO = new RolWS.RolWSClient();
        private AgenteWS.agente agenteSel;
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();

        private EmailWS.EmailWSSoapClient servicioEmail = new EmailWS.EmailWSSoapClient();

        public frmGestionarAgente()
        {
            InitializeComponent();
            LlenarCboRoles();
            LlenarCboEquipos();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            chkActivo.Visible = false;
            lblActivo.Visible = false;
        }

        public frmGestionarAgente(AgenteWS.agente age)
        {
            agenteSel = age;
            InitializeComponent();
            LlenarCboRoles();
            LlenarCboEquipos();
            txtIDAgente.Text = age.agenteId.ToString();
            txtNombre.Text = age.nombre;
            txtPaterno.Text = age.apellidoPaterno;
            txtMaterno.Text = age.apellidoMaterno;
            txtCodigo.Text = age.codigo;
            txtCodigo.ReadOnly = true;
            txtDNI.Text = age.dni;
            cboRol.SelectedValue = age.rol.rolId;
            cboEquipo.SelectedValue = age.equipo.equipoId;
            txtEmailPersonal.Text = age.personaEmail;
            txtEmailAgente.Text = age.agenteEmail;
            txtDireccion.Text = age.direccion;
            txtTel.Text = age.telefono;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
            chkActivo.Checked = age.activo;
        }

        private void LlenarCboRoles()
        {
            cboRol.DataSource = rolDAO.listarRoles();
            cboRol.DisplayMember = "nombre";
            cboRol.ValueMember = "rolId";
            cboRol.SelectedIndex = -1;
        }

        private void LlenarCboEquipos()
        {
            cboEquipo.DataSource = equipoDAO.listarEquipos();
            cboEquipo.DisplayMember = "nombre";
            cboEquipo.ValueMember = "equipoId";
            cboEquipo.SelectedIndex = -1;
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
                    "Falta indicar el nombre del agente.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtNombre.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El nombre del agente de contener solo letras.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtPaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido paterno del agente.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido paterno del agente de contener solo letras.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtMaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido materno del agente.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtMaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido materno del agente de contener solo letras.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del agente.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del agente de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del agente.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtTel.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El telefono del agente de contener solo numeros.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text.Length != 9)
            {
                MessageBox.Show("El telefono del agente debe de tener 9 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTel.Text[0] != '9')
            {
                MessageBox.Show("El telefono del agente debe iniciar con el digito 9", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigo.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el codigo del agente.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El codigo del agente de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del agente debe de contener 8 digitos.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el dni del agente.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtDNI.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El dni del agente de contener solo numeros.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDNI.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El dni del agente debe de contener 8 digitos.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar el rol del agente.",
                    "Error de rol",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboEquipo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar el equipo del agente.",
                    "Error de equipo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailPersonal.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email personal del agente.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtEmailPersonal.Text, @"^([\w-.]+)@(pucp.(edu.)?pe)$"))
            {
                MessageBox.Show(
                    "Debe ingresar un correo válido del dominio PUCP.",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailAgente.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email agente del agente.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtEmailAgente.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show(
                    "Existe un error en el formato del email del agente.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            agenteSel = new AgenteWS.agente();
            agenteSel.nombre = txtNombre.Text;
            agenteSel.apellidoPaterno = txtPaterno.Text;
            agenteSel.apellidoMaterno = txtMaterno.Text;
            agenteSel.codigo = txtCodigo.Text;
            agenteSel.dni = txtDNI.Text;

            agenteSel.equipo = new AgenteWS.equipo();
            agenteSel.rol = new AgenteWS.rol();

            agenteSel.equipo.equipoId = (int)cboEquipo.SelectedValue;
            agenteSel.rol.rolId = (int)cboRol.SelectedValue;
            agenteSel.rol.nombre = ((RolWS.rol)(cboRol.SelectedItem)).nombre;
            agenteSel.personaEmail = txtEmailPersonal.Text;
            agenteSel.agenteEmail = txtEmailAgente.Text;
            agenteSel.direccion = txtDireccion.Text;
            agenteSel.telefono = txtTel.Text;
            agenteSel.password = RandomGenerator.GenerateRandomPassword();


            if (MessageBox.Show("¿Desea crear el registro?", "Crear Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rpta = personaDAO.verificarCorreo(txtEmailPersonal.Text);
                AgenteWS.agente agBusc = agenteDAO.buscarAgentePorCodigo(agenteSel.codigo);

                if(rpta == 1)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese correo",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if(agBusc.agenteId != 0)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese código",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }

                if (rpta == -1)
                {
                    if (agenteDAO.insertarAgente(agenteSel) > 0)
                    {
                        MessageBox.Show(
                        "Se ha creado el registro exitosamente",
                        "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        EnviarEmailRegistrado(agenteSel);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Ha ocurrido un error al realizar el registro",
                        "Registro no realizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    }
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del agente.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtNombre.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El nombre del agente de contener solo letras.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtPaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido paterno del agente.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido paterno del agente de contener solo letras.",
                    "Error de apellido paterno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtMaterno.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el apellido materno del agente.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtMaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido materno del agente de contener solo letras.",
                    "Error de apellido materno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la direccion del agente.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDireccion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La direccion del agente de contener al menos una letra.",
                    "Error de direccion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el telefono del agente.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtTel.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El telefono del agente de contener solo numeros.",
                    "Error de telefono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtTel.Text.Length != 9)
            {
                MessageBox.Show("El telefono del agente debe de tener 9 digitos", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTel.Text[0] != '9')
            {
                MessageBox.Show("El telefono del agente debe iniciar con el digito 9", "Error de telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigo.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el codigo del agente.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtCodigo.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El codigo del agente de contener solo numeros.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del agente de contener 8 digitos.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el dni del agente.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtDNI.Text, @"[0-9]"))
            {
                MessageBox.Show(
                    "El dni del agente de contener solo numeros.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDNI.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El dni del agente debe de contener 8 digitos.",
                    "Error de dni",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar el rol del agente.",
                    "Error de rol",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboEquipo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar el equipo del agente.",
                    "Error de equipo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailPersonal.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email personal del agente.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtEmailPersonal.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show(
                    "Existe un error en el formato del email personal del agente.",
                    "Error de email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtEmailAgente.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el email agente del agente.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtEmailAgente.Text, @"^([\w-.]+)@(pucp.(edu.)?pe)$"))
            {
                MessageBox.Show(
                    "Existe un error en el formato del email del agente.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtNombre.Text == ""|| txtPaterno.Text == "" || txtMaterno.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtEmailAgente.Text == "" || txtEmailPersonal.Text == "" || txtDireccion.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show(
                "Debe llenar todos los campos.",
                "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            
            agenteSel.nombre = txtNombre.Text;
            agenteSel.apellidoPaterno = txtPaterno.Text;
            agenteSel.apellidoMaterno = txtMaterno.Text;
            agenteSel.codigo = txtCodigo.Text;
            agenteSel.dni = txtDNI.Text;

            agenteSel.equipo = new AgenteWS.equipo();
            agenteSel.rol = new AgenteWS.rol();

            agenteSel.equipo.equipoId = (int)cboEquipo.SelectedValue;
            agenteSel.rol.rolId = (int)cboRol.SelectedValue;
            agenteSel.personaEmail = txtEmailPersonal.Text;
            agenteSel.agenteEmail = txtEmailAgente.Text;
            agenteSel.direccion = txtDireccion.Text;
            agenteSel.telefono = txtTel.Text;
            agenteSel.activo = chkActivo.Checked;

            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rpta = personaDAO.verificarCorreo(txtEmailPersonal.Text);
                AgenteWS.agente agBusc = agenteDAO.buscarAgentePorCodigo(agenteSel.codigo);

                if (rpta == 1)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese correo",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if (agBusc.agenteId != 0)
                {
                    MessageBox.Show(
                    "Ya existe un usuario con ese código",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if (agenteDAO.actualizarAgente(agenteSel) > -1)
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

        private void EnviarEmailRegistrado(AgenteWS.agente age)
        {

            StreamReader streamReader = new StreamReader("../../html/EmailCrearPersona.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*NOMBREPH*", age.nombre);
            body = body.Replace("*APELLIDOPH*", age.apellidoPaterno);
            body = body.Replace("*TIPOPH*", age.rol.nombre);
            body = body.Replace("*EMAILPH*", age.personaEmail);
            body = body.Replace("*PASSPH*", age.password);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = age.personaEmail;
            correo.Subject = "Yanapay - Nuevo agente";
            correo.Body = body;
            correo.IsHtml = true;

            if (servicioEmail.EnviarCorreo(correo) == false)
            {
                MessageBox.Show(
                "Ha ocurrido un error al enviar el correo de confirmación",
                "Correo no enviado",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
