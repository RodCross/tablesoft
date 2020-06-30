using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmSeleccionarTareasTicket : Form
    {
        private TareaWS.TareaWSClient tareaDAO = new TareaWS.TareaWSClient();
        private BindingList<TareaWS.tarea> tareas;

        private TareaWS.ticket ticket = new TareaWS.ticket();
        private TareaWS.agente agente = new TareaWS.agente();

        public frmSeleccionarTareasTicket(TicketWS.ticket tick)
        {
            InitializeComponent();

            ticket.ticketId = tick.ticketId;
            agente.agenteId = frmInicioSesion.agenteLogueado.agenteId;

            TareaWS.tarea[] arrTareas = tareaDAO.listarTareasPorTicket(ticket);
            
            if (arrTareas != null)
            {
                tareas = new BindingList<TareaWS.tarea>(arrTareas.ToList());
            }
            else
            {
                tareas = new BindingList<TareaWS.tarea>();
            }

            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = tareas;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios realizados?", "Actualizar Lista de Tareas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Obtener un arreglo de las tareas a eliminar y eliminarlas
                
                List<DataGridViewRow> filasEliminar = dgvLista.Rows.Cast<DataGridViewRow>().Where(g => Convert.ToBoolean(g.Cells["Eliminar"].Value) == true).ToList();
                BindingList<TareaWS.tarea> tareasUpdate = new BindingList<TareaWS.tarea>();
                foreach (var fila in filasEliminar)
                {
                    var tar = (TareaWS.tarea)fila.DataBoundItem;
                    if (tar.tareaId != 0)
                    {
                        tareasUpdate.Add(tar);
                    }
                }

                tareaDAO.eliminarTareas(tareasUpdate.ToArray());

                // Obtener un arreglo de las taeras a actualizar y actualizarlas

                List<DataGridViewRow> filasActualizarInsertar = dgvLista.Rows.Cast<DataGridViewRow>().Where(g => Convert.ToBoolean(g.Cells["Eliminar"].Value) == false).ToList();
                tareasUpdate = new BindingList<TareaWS.tarea>();
                foreach(var fila in filasActualizarInsertar)
                {
                    tareasUpdate.Add((TareaWS.tarea)fila.DataBoundItem);
                }

                tareaDAO.actualizarInsertarTareas(tareasUpdate.ToArray(), ticket);
                
                // Actualizar dgv

                var arrTareas = tareaDAO.listarTareasPorTicket(ticket);

                if (arrTareas != null)
                {
                    tareas = new BindingList<TareaWS.tarea>(arrTareas.ToList());
                }
                else
                {
                    tareas = new BindingList<TareaWS.tarea>();
                }

                dgvLista.AutoGenerateColumns = false;
                dgvLista.DataSource = tareas;
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                TareaWS.tarea tareaNueva = new TareaWS.tarea();

                tareaNueva.descripcion = txtDescripcion.Text;
                tareaNueva.completado = false;
                tareaNueva.tareaId = 0;
                tareaNueva.agente = new TareaWS.agente();
                tareaNueva.agente.agenteId = agente.agenteId;

                tareas.Add(tareaNueva);
                dgvLista.Refresh();
                txtDescripcion.Text = "";
            }
            
        }
    }
}
