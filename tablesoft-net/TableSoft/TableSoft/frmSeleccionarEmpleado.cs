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
    public partial class frmSeleccionarEmpleado : Form
    {
        private EmpleadoWS.EmpleadoWSClient empleadoDAO = new EmpleadoWS.EmpleadoWSClient();
        private BindingList<EmpleadoWS.empleado> empleados;

        public frmSeleccionarEmpleado()
        {
            EmpleadoWS.empleado[] arrEmpleados = empleadoDAO.listarEmpleados();
            InitializeComponent();
            dgvLista.AutoGenerateColumns = false;
            if (arrEmpleados != null)
            {
                empleados = new BindingList<EmpleadoWS.empleado>(arrEmpleados);
                dgvLista.DataSource = empleados;
            }
            else
            {
                dgvLista.DataSource = null;
            }
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EmpleadoWS.empleado data = dgvLista.Rows[e.RowIndex].DataBoundItem as EmpleadoWS.empleado;
            dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = data.apellidoPaterno + " " + data.apellidoMaterno + ", " + data.nombre;
            dgvLista.Rows[e.RowIndex].Cells["Biblioteca"].Value = data.biblioteca.nombre;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarEmpleado frm = new frmGestionarEmpleado();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                empleados = new BindingList<EmpleadoWS.empleado>(empleadoDAO.listarEmpleados());
                dgvLista.DataSource = empleados;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpleadoWS.empleado emp = (EmpleadoWS.empleado)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarEmpleado frm = new frmGestionarEmpleado(emp);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                empleados = new BindingList<EmpleadoWS.empleado>(empleadoDAO.listarEmpleados());
                dgvLista.DataSource = empleados;
            }
        }
    }
}
