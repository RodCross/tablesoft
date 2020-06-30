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
        private TicketWS.ticket ticket;
        private const string comentarioPorDefecto = "Escribe aquí tu comentario.";
        private int numPanel = 0;
        private int longitudY = 0;
        private Panel panel;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblCom;

        // temporal
        private BindingList<string> nombres = new BindingList<string>();
        private BindingList<string> fechas = new BindingList<string>();
        private BindingList<string> comentarios = new BindingList<string>();

        public frmInfoTicketAgente(TicketWS.ticket tick)
        {
            ticket = tick;
            InitializeComponent();
            CrearPaneles();
            MostrarComentarioPorDefecto();
            lblAsunto.Text = tick.asunto;
            lblId.Text = "# " + tick.ticketId.ToString();
            lblFecIni.Text = tick.fechaEnvio.Replace('-', '/').Replace("T", " - ");
            lblFecCieEst.Text = tick.fechaCierreMaximo.Replace('-', '/').Replace("T", " - ");
            lblEstado.Text = tick.estado.nombre;
            lblBib.Text = tick.biblioteca.nombre;
            lblCat.Text = tick.categoria.nombre;
            lblUrg.Text = tick.urgencia.nombre;
            if (tick.activoFijo.activoFijoId > 0)
            {
                lblActFij.Text = tick.activoFijo.codigo;
            }
            else
            {
                lblTituloActFij.Text = "";
            }
        }

        private void CrearPaneles()
        {
            nombres.Add("ROLDÁN HUAYLLASCO, STEFANO");
            nombres.Add("VERÁSTEGUI SÁNCHEZ, FERNANDO GUILLERMO");
            nombres.Add("ROLDÁN HUAYLLASCO, STEFANO");
            fechas.Add("2020/06/29 - 22:44:45");
            fechas.Add("2020/05/17 - 16:33:02");
            fechas.Add("2020/04/03 - 04:14:57");
            comentarios.Add("Estimado Fernando:\nHe procedido a realizar lo que usted me ha indicado y estoy a la espera de su nueva respuesta. Agradezco de antemano su comprensión ante estos inesperados inconvenientes.");
            comentarios.Add("Saludos, Stefano:\nPara poder determinar la raíz del problema, necesitamos un poco más de información de su parte. ¿Podría intentar volver a realizar las impresiones, para luego revisar si hay mensajes en los displays de las dos impresoras ? Si esto fuera así, le agradecería que nos brinde el contenido de dichos mensajes.Esto ayudará a identificar con más facilidad la causa y también a determinar si es necesario enviar un técnico al área de las impresoras.También sería bueno que adjunte una foto del documento impreso a medias.Espero su respuesta.Si esto fuera así, le agradecería que nos brinde el contenido de dichos mensajes.Esto ayudará a identificar con más facilidad la causa y también a determinar si es necesario enviar un técnico al área de las impresoras.También sería bueno que adjunte una foto del documento impreso a medias.Espero su respuesta.También sería bueno que adjunte una foto del documento impreso a medias.Espero su respuesta.Espero su respuesta.Espero respuesta.");
            comentarios.Add("Saludos,\nEscribo para comunicar un problema que yo y mis colegas hemos notado hace unos minutos.Al intentar imprimir documentos, ninguna de las dos impresoras funciona correctamente.Una de ellas mueve el papel de la bandeja, pero solo imprime un par de líneas y luego deja la hoja en blanco, mientras que la otra directamente no comienza la impresion.Espero su respuesta.Gracias de antemano.");

            foreach (string nombre in nombres)
            {
                panel = new Panel
                {
                    Location = new Point(3, longitudY + 6),
                    Name = "pnlMsg" + numPanel,
                    Size = new Size(706, 170),
                    BackColor = SystemColors.Control
                };

                lblNombre = new Label
                {
                    Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(17, 3),
                    Name = "lblNombre" + numPanel,
                    Size = new Size(654, 22),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = nombre
                };

                lblFecha = new Label
                {
                    Font = new Font("Microsoft PhagsPa", 10.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(18, 28),
                    Name = "lblFecha" + numPanel,
                    Size = new Size(654, 20),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = fechas[numPanel]
                };

                lblCom = new Label
                {
                    Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(18, 53),
                    Name = "lblCom" + numPanel,
                    Size = new Size(10, 10),
                    TextAlign = ContentAlignment.TopLeft,
                    Text = comentarios[numPanel]
                };

                // AQUI VERIFICAR SI LA RESPUESTA VIENE DE UN AGENTE
                if (nombre[0] == 'V')
                {
                    lblNombre.ForeColor = lblFecha.ForeColor = lblCom.ForeColor = Color.MediumBlue;
                }
                else
                {
                    lblNombre.ForeColor = Color.FromArgb(71, 82, 94);
                    lblFecha.ForeColor = Color.Gray;
                    lblCom.ForeColor = Color.Black;
                }

                panel.Controls.Add(lblNombre);
                panel.Controls.Add(lblFecha);

                // Acomodar panel a longitud de comentario
                lblCom.MaximumSize = new Size(666, 0);
                lblCom.AutoSize = true;
                panel.Controls.Add(lblCom);
                panel.Size = new Size(706, lblCom.Size.Height + 68);
                longitudY = panel.Location.Y + panel.Size.Height;

                pnlMensajes.Controls.Add(panel);
                numPanel++;
            }
        }

        private void MostrarComentarioPorDefecto()
        {
            rtfRespuesta.ForeColor = Color.Gray;
            rtfRespuesta.Text = comentarioPorDefecto;
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
            if (rtfRespuesta.Text == comentarioPorDefecto)
            {
                rtfRespuesta.Text = "";
                rtfRespuesta.ForeColor = Color.Black;
            }
        }

        private void rtfRespuesta_Leave(object sender, EventArgs e)
        {
            if (rtfRespuesta.Text == "")
            {
                MostrarComentarioPorDefecto();
            }
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            //frmEscalarTicketAgente frm = new frmEscalarTicketAgente();
            //frm.ShowDialog();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            frmActualizarEstadoTicketAgente frm = new frmActualizarEstadoTicketAgente();
            frm.ShowDialog();
        }

        private void btnCambiarCategoria_Click(object sender, EventArgs e)
        {
            frmReasignarCategoriaTicketAgente frm = new frmReasignarCategoriaTicketAgente(ticket);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            frmSeleccionarTareasTicket frm = new frmSeleccionarTareasTicket(ticket);
            frm.ShowDialog();
        }
    }
}
