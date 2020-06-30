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

                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    TareaWS.tarea t = (TareaWS.tarea)row.DataBoundItem;

                    if (Convert.ToBoolean(row.Cells["Eliminar"].Value) == true)
                    {
                        if (t.tareaId != 0) tareaDAO.eliminarTarea(t);
                    }
                    else
                    {
                        if (t.tareaId == 0) tareaDAO.insertarTarea(t, ticket);
                        else
                        {
                            tareaDAO.actualizarTarea(t, agente);
                        }
                    }
                }

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

                MessageBox.Show("Actualizacion completa", "Actualizar Lista de Tareas", MessageBoxButtons.OK);
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
