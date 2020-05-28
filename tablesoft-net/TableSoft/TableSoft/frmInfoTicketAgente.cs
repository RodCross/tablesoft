using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInfoTicketAgente : Form
    {
        String defaultRespuesta = "Escribe aquí tu comentario.";

        public frmInfoTicketAgente()
        {
            InitializeComponent();
            MostrarDefaultRespuesta();
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

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            frmEscalarTicketAgente frm = new frmEscalarTicketAgente();
            frm.ShowDialog();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            frmActualizarEstadoTicketAgente frm = new frmActualizarEstadoTicketAgente();
            frm.ShowDialog();
        }

        private void btnCambiarCategoria_Click(object sender, EventArgs e)
        {
            frmReasignarCategoriaTicketAgente frm = new frmReasignarCategoriaTicketAgente();
            frm.ShowDialog();
        }
    }
}
