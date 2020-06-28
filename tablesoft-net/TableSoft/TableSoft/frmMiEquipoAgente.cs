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
    public partial class frmMiEquipoAgente : Form
    {
        public AgenteWS.agente agente;
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BindingList<TicketWS.ticket> ticketsEnEspera;
        private EstadoTicketWS.EstadoTicketWSClient estadoTicketDAO = new EstadoTicketWS.EstadoTicketWSClient();
        private BindingList<EstadoTicketWS.estadoTicket> estados;
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private BindingList<EquipoWS.equipo> equipos;
        public frmMiEquipoAgente()
        {
            InitializeComponent();
            agente = frmInicioSesion.agenteLogueado;
            estados = new BindingList<EstadoTicketWS.estadoTicket>(estadoTicketDAO.listarEstadosTicket().ToArray());
            equipos = new BindingList<EquipoWS.equipo>(equipoDAO.listarEquipos().ToArray());
            TicketWS.ticket tick=new TicketWS.ticket();
            TicketWS.equipo equip = new TicketWS.equipo();
            
            foreach (EstadoTicketWS.estadoTicket e in estados)
            {
                if (e.nombre.ToLower().Equals("activo"))
                {
                    tick.estado = new TicketWS.estadoTicket();
                    tick.estado.estadoId = e.estadoId;
                    tick.estado.nombre = e.nombre;
                    tick.estado.descripcion = e.descripcion;
                    tick.estado.activo = e.activo;
                    break;
                }
            }

            foreach (EquipoWS.equipo eq in equipos)
            {
                if (eq.equipoId==agente.equipo.equipoId)
                {
                    equip.equipoId = eq.equipoId;
                    equip.nombre = eq.nombre;
                    equip.descripcion = eq.descripcion;
                    equip.fechaCreacion = eq.fechaCreacion;
                    equip.activo = eq.activo;
                    break;
                }
            }

            var tickts = ticketDAO.listarTicketsPorEstadoPorEquipo(tick.estado, equip);
            if (tickts == null)
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>();
            }
            else
            {
                ticketsEnEspera = new BindingList<TicketWS.ticket>(tickts);
            }

            dgvTicketsEspera.AutoGenerateColumns = false;
            dgvTicketsEspera.DataSource = ticketsEnEspera;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se te ha asignado el ticket seleccionado.",
                "Asignación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
