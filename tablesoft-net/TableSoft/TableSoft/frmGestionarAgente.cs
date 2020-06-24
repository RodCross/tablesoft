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
        private BindingList<BibliotecaWS.biblioteca> equipos;
        private RolWS.RolWSClient rolDAO = new RolWS.RolWSClient();
        private BindingList<RolWS.rol> roles;
        private RolWS.rol rol;
        private EquipoWS.equipo equipo;
        private AgenteWS.agente agenteSel;


        public frmGestionarAgente()
        {
            InitializeComponent();
            LlenarCboRoles();
            LlenarCboEquipos();
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
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = false;
        }


        private void LlenarCboRoles()
        {
            cboRol.DataSource = rolDAO.listarRoles(rol);
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



        public frmGestionarAgente(int i)
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
            int i = agenteDAO.eliminarAgente(agenteSel);

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
            if(txtNombre.Text == ""|| txtPaterno.Text == "" || txtMaterno.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtEmailAgente.Text == "" || txtEmailPersonal.Text == "")
            {
                MessageBox.Show(
                "Debe llenar todos los campos",
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
            agenteSel.equipo.equipoId = (int)cboEquipo.SelectedValue;

            agenteSel.personaEmail = txtEmailPersonal.Text;
            agenteSel.agenteEmail = txtEmailAgente.Text;

            agenteDAO.actualizarAgente(agenteSel);


            MessageBox.Show(
                "Se ha actualizado el registro.",
                "Actualización exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
