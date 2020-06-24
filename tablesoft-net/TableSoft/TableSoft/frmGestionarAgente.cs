using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (txtNombre.Text == "" || txtPaterno.Text == "" || txtMaterno.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtEmailAgente.Text == "" || txtEmailPersonal.Text == "" || -1 == (int)cboEquipo.SelectedValue || -1 == (int)cboRol.SelectedValue || txtDireccion.Text == "" || txtTel.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show(
                "Debe llenar todos los campos.",
                "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
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
