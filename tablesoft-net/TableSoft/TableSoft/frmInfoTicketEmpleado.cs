using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInfoTicketEmpleado : Form
    {
        private ComentarioWS.ComentarioWSClient comentarioDAO = new ComentarioWS.ComentarioWSClient();
        private ComentarioWS.comentario[] comentarios;
        private ComentarioWS.comentario comentarioActual;
        private TicketWS.ticket ticket;

        private int numPanel = 0;
        private int longitudY = 0;
        private Dictionary<int, Panel> paneles = new Dictionary<int, Panel>();
        private Label lblNombre;
        private Label lblFecha;
        private Label lblCom;

        public frmInfoTicketEmpleado()
        {
            InitializeComponent();
        }

        public frmInfoTicketEmpleado(TicketWS.ticket tick)
        {
            ticket = tick;
            InitializeComponent();
            LlenarComentarios();
            CrearPaneles();
            lblAsunto.Text = tick.asunto;
            lblId.Text = "# " + tick.ticketId.ToString();
            lblFecIni.Text = tick.fechaEnvio.Replace('-', '/').Replace("T", " - "); 
            lblFecCieEst.Text = tick.fechaCierreMaximo.Replace('-', '/').Replace("T", " - ");
            lblEstado.Text = tick.estado.nombre;
            lblBib.Text = tick.biblioteca.nombre;
            lblCat.Text = tick.categoria.nombre;
            lblUrg.Text = tick.urgencia.nombre;
            if(tick.activoFijo.activoFijoId > 0)
            {
                lblActFij.Text = tick.activoFijo.codigo;
            }
            else
            {
                lblTituloActFij.Text = "";
            }

            if (ticket.estado.estadoId == (int)Estado.Cerrado)
            {
                btnResponder.Enabled = false;
            }
        }

        private void LlenarComentarios()
        {
            ComentarioWS.ticket tCom = new ComentarioWS.ticket
            {
                ticketId = ticket.ticketId
            };

            comentarios = comentarioDAO.listarComentariosDeTicket(tCom);
        }

        private void CrearPaneles()
        {
            if (comentarios != null)
            {
                numPanel = 0;
                longitudY = 0;

                foreach (ComentarioWS.comentario comentario in comentarios)
                {
                    paneles.Add(numPanel, new Panel
                    {
                        Location = new Point(3, longitudY + 6),
                        Name = "pnlMsg" + numPanel,
                        Size = new Size(706, 170),
                        BackColor = SystemColors.Control
                    });

                    lblNombre = new Label
                    {
                        Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Location = new Point(17, 3),
                        Name = "lblNombre" + numPanel,
                        Size = new Size(654, 22),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Text = (comentario.autor.apellidoPaterno + " " + comentario.autor.apellidoMaterno + ", " + comentario.autor.nombre).ToUpper()
                    };

                    lblFecha = new Label
                    {
                        Font = new Font("Microsoft PhagsPa", 10.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Location = new Point(18, 28),
                        Name = "lblFecha" + numPanel,
                        Size = new Size(654, 20),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Text = comentario.fecha.Replace('-', '/').Replace("T", " - ")
                    };

                    lblCom = new Label
                    {
                        Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(18, 53),
                        Name = "lblCom" + numPanel,
                        Size = new Size(10, 10),
                        TextAlign = ContentAlignment.TopLeft,
                        Text = comentario.texto
                    };

                    // Toda la seccion va de color azul si el comentario ha sido
                    // escrito por un agente. Caso contrario, va en escala de grises.
                    if (comentario.autor.tipo == 'A')
                    {
                        lblNombre.ForeColor = lblFecha.ForeColor = lblCom.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblNombre.ForeColor = Color.FromArgb(71, 82, 94);
                        lblFecha.ForeColor = Color.Gray;
                        lblCom.ForeColor = Color.Black;
                    }

                    paneles[numPanel].Controls.Add(lblNombre);
                    paneles[numPanel].Controls.Add(lblFecha);

                    // Acomodar panel a longitud de comentario
                    lblCom.MaximumSize = new Size(666, 0);
                    lblCom.AutoSize = true;
                    paneles[numPanel].Controls.Add(lblCom);
                    paneles[numPanel].Size = new Size(706, lblCom.Size.Height + 68);
                    longitudY = paneles[numPanel].Location.Y + paneles[numPanel].Size.Height;

                    pnlMensajes.Controls.Add(paneles[numPanel]);
                    numPanel++;
                }
            }
        }

        private void RecargarComentarios()
        {
            // Elimina los paneles de los mensajes individuales junto con la memoria usada
            foreach (KeyValuePair<int, Panel> entrada in paneles)
            {
                pnlMensajes.Controls.Remove(entrada.Value);
                entrada.Value.Dispose();
            }

            // Limpia el diccionario que guarda paneles para poder llenarlo otra vez
            paneles.Clear();
            CrearPaneles();
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
            if (Regex.Matches(rtfRespuesta.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                "El comentario es inválido.",
                "Comentario no puede ser registrado",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show(
                    "¿Deseas registrar el comentario ingresado?",
                    "Registrar comentario",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comentarioActual = new ComentarioWS.comentario
                    {
                        texto = rtfRespuesta.Text,
                        autor = new ComentarioWS.persona()
                    };
                    comentarioActual.autor.codigo = frmInicioSesion.empleadoLogueado.codigo;
                    ComentarioWS.ticket tCom = new ComentarioWS.ticket
                    {
                        ticketId = ticket.ticketId
                    };

                    if (comentarioDAO.insertarComentario(comentarioActual, tCom) != 0)
                    {
                        MessageBox.Show(
                        "El comentario se ha registrado correctamente.",
                        "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar respuesta, actualizar lista de comentarios y recargar paneles
                        rtfRespuesta.Text = "";
                        rtfRespuesta.Select();
                        comentarios = comentarioDAO.listarComentariosDeTicket(tCom);
                        RecargarComentarios();
                    }
                    else
                    {
                        MessageBox.Show(
                        "El comentario no se ha podido registrar.",
                        "Registro fallido",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
