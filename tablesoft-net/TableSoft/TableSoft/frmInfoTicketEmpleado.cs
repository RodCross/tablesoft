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
    public partial class frmInfoTicketEmpleado : Form
    {
        String defaultRespuesta = "Escribe aquí tu comentario.";

        public frmInfoTicketEmpleado()
        {
            InitializeComponent();
            MostrarDefaultRespuesta();
        }
        public frmInfoTicketEmpleado(TicketWS.ticket tick)
        {
            InitializeComponent();
            MostrarDefaultRespuesta();
            lblAsunto.Text = tick.asunto;
            lblId.Text = "# " + tick.ticketId.ToString();
            lblCreacion.Text = tick.fechaEnvio.ToString();
            lblFecCieEst.Text = tick.fechaCierreMaximo.ToString();
            lblEstado.Text = tick.estado.nombre;
            lblBiblioteca.Text = tick.biblioteca.nombre;
            lblCategoria.Text = tick.categoria.nombre;
            lblUrgencia.Text = tick.urgencia.nombre;
            if(tick.activoFijo.activoFijoId > 0)
            {
                lblActFij.Text = tick.activoFijo.codigo;
            }
            else
            {
                lblTituloActFij.Text = "";
            }
            
        }

        private void MostrarDefaultRespuesta()
        {
            rtfRespuesta.ForeColor = Color.Gray;
            rtfRespuesta.Text = defaultRespuesta;
        }
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La respuesta se ha registrado correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void rtfRespuesta_Enter(object sender, EventArgs e)
        {
            if (rtfRespuesta.Text == defaultRespuesta)
            {
                rtfRespuesta.Text = "";
                rtfRespuesta.ForeColor = Color.Black;
            }
        }

        private void rtfRespuesta_Leave(object sender, EventArgs e)
        {
            if (rtfRespuesta.Text == "")
            {
                MostrarDefaultRespuesta();
            }
        }

    }
}
