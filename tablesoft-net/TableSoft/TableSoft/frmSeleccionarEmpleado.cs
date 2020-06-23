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
            InitializeComponent();
            empleados = new BindingList<EmpleadoWS.empleado>(empleadoDAO.listarEmpleados().ToArray());
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = empleados;
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
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpleadoWS.empleado emp = (EmpleadoWS.empleado)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarEmpleado frm = new frmGestionarEmpleado(emp);
            frm.ShowDialog();
        }
    }
}
