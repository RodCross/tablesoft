using System;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInicioEmpleado : Form
    {
        public frmInicioEmpleado()
        {
            InitializeComponent();
            SetUsername(lblUsuario);
        }
        
        private void SetUsername(Label lblUser)
        {
            EmpleadoWS.empleado emp = frmLogin.empleadoLogueado;
            lblUser.Text = emp.apellidoPaterno + " " + emp.apellidoMaterno + ", " + emp.nombre;
        }

        private void lklLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmCrearNuevoTicket frm = new frmCrearNuevoTicket
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            frmListaTicketsEmpleado frm = new frmListaTicketsEmpleado
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
