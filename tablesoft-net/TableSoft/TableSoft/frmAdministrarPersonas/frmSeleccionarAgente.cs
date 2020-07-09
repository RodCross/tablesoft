using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmSeleccionarAgente : Form
    {
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private BindingList<AgenteWS.agente> agentes;

        public frmSeleccionarAgente()
        {
            AgenteWS.agente[] arrAgentes = agenteDAO.listarAgentes();
            InitializeComponent();
            dgvLista.AutoGenerateColumns = false;
            if (arrAgentes != null){
                agentes = new BindingList<AgenteWS.agente>(arrAgentes);
                dgvLista.DataSource = agentes;
            }
            else
            {
                dgvLista.DataSource = null;
            }
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AgenteWS.agente data = dgvLista.Rows[e.RowIndex].DataBoundItem as AgenteWS.agente;
            dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = data.apellidoPaterno + " " + data.apellidoMaterno + ", " + data.nombre;
            dgvLista.Rows[e.RowIndex].Cells["Rol"].Value = data.rol.nombre;
            dgvLista.Rows[e.RowIndex].Cells["Equipo"].Value = data.equipo.nombre;
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
            frmGestionarAgente frm = new frmGestionarAgente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                agentes = new BindingList<AgenteWS.agente>(agenteDAO.listarAgentes());
                dgvLista.DataSource = agentes;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AgenteWS.agente age = (AgenteWS.agente)dgvLista.CurrentRow.DataBoundItem;
            frmGestionarAgente frm = new frmGestionarAgente(age);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                agentes = new BindingList<AgenteWS.agente>(agenteDAO.listarAgentes());
                dgvLista.DataSource = agentes;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AgenteWS.agente[] nuevosAgentes = agenteDAO.listarAgentesPorNombre(txtBuscar.Text);
            if (nuevosAgentes != null)
            {
                agentes = new BindingList<AgenteWS.agente>(nuevosAgentes);
                dgvLista.DataSource = agentes;
            }
            else
            {
                dgvLista.DataSource = null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AgenteWS.agente age = (AgenteWS.agente)dgvLista.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Agente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (agenteDAO.eliminarAgente(age) > -1)
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
                agentes = new BindingList<AgenteWS.agente>(agenteDAO.listarAgentes());
                dgvLista.DataSource = agentes;
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
    }
}
