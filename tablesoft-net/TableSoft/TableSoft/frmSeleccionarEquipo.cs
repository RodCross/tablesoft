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
    public partial class frmSeleccionarEquipo : Form
    {
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private BindingList<EquipoWS.equipo> equipos;

        public frmSeleccionarEquipo()
        {
            InitializeComponent();
            var equis = equipoDAO.listarEquipos();
            if(equis == null)
            {
                equipos = new BindingList<EquipoWS.equipo>();
            }
            else
            {
                equipos = new BindingList<EquipoWS.equipo>(equis);
            }
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = equipos;
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
            frmGestionarEquipo frm = new frmGestionarEquipo();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var equis = equipoDAO.listarEquipos();
                if (equis == null)
                {
                    equipos = new BindingList<EquipoWS.equipo>();
                }
                else
                {
                    equipos = new BindingList<EquipoWS.equipo>(equis);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = equipos;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EquipoWS.equipo equipo = (EquipoWS.equipo)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarEquipo frm = new frmGestionarEquipo(equipo);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var equis = equipoDAO.listarEquipos();
                if (equis == null)
                {
                    equipos = new BindingList<EquipoWS.equipo>();
                }
                else
                {
                    equipos = new BindingList<EquipoWS.equipo>(equis);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = equipos;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EquipoWS.equipo equipo = (EquipoWS.equipo)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Equipo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (equipoDAO.eliminarEquipo(equipo) > -1)
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
                var equis = equipoDAO.listarEquipos();
                if (equis == null)
                {
                    equipos = new BindingList<EquipoWS.equipo>();
                }
                else
                {
                    equipos = new BindingList<EquipoWS.equipo>(equis);
                }
                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = equipos;
            }
        }
    }
}
