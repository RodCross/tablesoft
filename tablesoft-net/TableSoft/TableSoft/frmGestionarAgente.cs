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
    public partial class frmGestionarAgente : Form
    {
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private RolWS.RolWSClient rolDAO = new RolWS.RolWSClient();
        private AgenteWS.agente agenteSel;


        public frmGestionarAgente()
        {
            InitializeComponent();
            LlenarCboRoles();
            LlenarCboEquipos();
            txtPass.Enabled = true;
            picEye.Visible = true;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
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
            txtDNI.Text = age.dni;
            cboRol.SelectedValue = age.rol.rolId;
            cboEquipo.SelectedValue = age.equipo.equipoId;
            txtEmailPersonal.Text = age.personaEmail;
            txtEmailAgente.Text = age.agenteEmail;
            txtDireccion.Text = age.direccion;
            txtTel.Text = age.telefono;
            txtPass.Enabled = false;
            picEye.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = false;
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
                    "Falta indicar el apellido parteno del agente.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido parteno del agente de contener solo letras.",
                    "Error de apellido parteno",
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
            if (txtPass.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la contraseña del agente.",
                    "Error de contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
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
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del agente de contener 8 digitos.",
                    "Error de codigo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if(cboRol.SelectedIndex == -1)
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
            if (Regex.Matches(txtEmailPersonal.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email personal del agente de contener un arroba.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email personal del agente de contener un punto.",
                    "Error de email personal",
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
            if (Regex.Matches(txtEmailAgente.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email agente del agente de contener un arroba.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailAgente.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email agente del agente de contener un punto.",
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
            agenteSel.personaEmail = txtEmailPersonal.Text;
            agenteSel.agenteEmail = txtEmailAgente.Text;
            agenteSel.direccion = txtDireccion.Text;
            agenteSel.telefono = txtTel.Text;
            agenteSel.password = txtPass.Text;

            
            if (MessageBox.Show("¿Desea crear el registro?", "Crear Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (agenteDAO.insertarAgente(agenteSel) > 0)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (agenteDAO.eliminarAgente(agenteSel) > -1)
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
                    "No se eliminó el registro",
                    "Eliminación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "No se eliminó el registro",
                "Eliminación no realizada",
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
                    "Falta indicar el apellido parteno del agente.",
                    "Error de apellido parteno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (!Regex.IsMatch(txtPaterno.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show(
                    "El apellido parteno del agente de contener solo letras.",
                    "Error de apellido parteno",
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
            if (Regex.Matches(txtCodigo.Text, @"[0-9]").Count != 8)
            {
                MessageBox.Show(
                    "El codigo del agente de contener 8 digitos.",
                    "Error de codigo",
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
            if (Regex.Matches(txtEmailPersonal.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email personal del agente de contener un arroba.",
                    "Error de email personal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailPersonal.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email personal del agente de contener un punto.",
                    "Error de email personal",
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
            if (Regex.Matches(txtEmailAgente.Text, @"@").Count != 1)
            {
                MessageBox.Show(
                    "El email agente del agente de contener un arroba.",
                    "Error de email agente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtEmailAgente.Text, @"[.]").Count == 0)
            {
                MessageBox.Show(
                    "El email agente del agente de contener un punto.",
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

            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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
