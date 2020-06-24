using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            btnEliminar.Visible = false;
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
            btnEliminar.Visible = true;
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
            if (txtNombre.Text == "" || txtPaterno.Text == "" || txtMaterno.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtEmailPersonal.Text == "" || -1 == (int)cboBiblioteca.SelectedValue || txtDireccion.Text == "" || txtTel.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show(
                "Debe llenar todos los campos.",
                "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
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

            if (empleadoDAO.insertarEmpleado(empleadoSel) > 0)
            {
                MessageBox.Show(
                "Se ha guardado el registro.",
                "Guardado exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = empleadoDAO.eliminarEmpleado(empleadoSel);

            MessageBox.Show(
                "Se ha eliminado el registro.",
                "Eliminación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPaterno.Text == "" || txtMaterno.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtEmailPersonal.Text == "" || txtDireccion.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show(
                "Debe llenar todos los campos.",
                "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
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

            if (empleadoDAO.actualizarEmpleado(empleadoSel) == 0)
            {
                MessageBox.Show(
                    "Se ha actualizado el registro.",
                    "Actualización exitosa",
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
