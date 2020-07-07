using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmInfoTicketAgente : Form
    {
        private ComentarioWS.ComentarioWSClient comentarioDAO = new ComentarioWS.ComentarioWSClient();
        private ComentarioWS.comentario[] comentarios;
        private ComentarioWS.comentario comentarioActual;
        private TicketWS.ticket ticket;

        private EmailWS.EmailWSSoapClient servicioEmail = new EmailWS.EmailWSSoapClient();

        private int numPanel = 0;
        private int longitudY = 0;
        private Dictionary<int, Panel> paneles = new Dictionary<int, Panel>();
        private Label lblNombre;
        private Label lblFecha;
        private Label lblCom;

        public frmInfoTicketAgente(TicketWS.ticket tick)
        {
            ticket = tick;

            InitializeComponent();
            LlenarComentarios();
            CrearPaneles();

            lblAsunto.Text = tick.asunto;
            lblId.Text = "# " + tick.ticketId.ToString();
            lblFecIni.Text = tick.fechaEnvio.Replace('-', '/').Replace("T", " - ");
            if(tick.fechaCierreMaximo != null)
            {
                lblFecCieEst.Text = tick.fechaCierreMaximo.Replace('-', '/').Replace("T", " - ");
            }
            else
            {
                lblFecCieEst.Text = "Error en la fecha";
            }
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

            // Segun el estado del ticket

            if(ticket.estado.estadoId == (int)Estado.Cerrado)
            {
                btnCambiarCategoria.Enabled = false;
                btnCerrarTicket.Enabled = false;
                btnEscalar.Enabled = false;
                btnVerTareas.Enabled = false;
                btnResponder.Enabled = false;
            }
            if(ticket.estado.estadoId == (int)Estado.Escalado)
            {
                btnCambiarCategoria.Enabled = false;
                //btnVerTareas.Enabled = false;
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
                    comentarioActual.autor.codigo = frmInicioSesion.agenteLogueado.codigo;
                    ComentarioWS.ticket tCom = new ComentarioWS.ticket
                    {
                        ticketId = ticket.ticketId
                    };

                    if (comentarioDAO.insertarComentario(comentarioActual, tCom) != 0)
                    {
                        //MessageBox.Show(
                        //"El comentario se ha registrado correctamente.",
                        //"Registro exitoso",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar respuesta, actualizar lista de comentarios y recargar paneles
                        rtfRespuesta.Text = "";
                        rtfRespuesta.Select();
                        comentarios = comentarioDAO.listarComentariosDeTicket(tCom);
                        RecargarComentarios();
                        
                        // Mandar correo al empleado

                        EnviarEmailNoficacion(ticket.empleado);
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

        private void EnviarEmailNoficacion(TicketWS.empleado emp)
        {

            StreamReader streamReader = new StreamReader("../../emails/EmailNotificacionComentario.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*NOMBREPH*", emp.nombre);
            body = body.Replace("*APELLIDOPH*", emp.apellidoPaterno);
            body = body.Replace("*TIPOPH*", "agente");
            body = body.Replace("*TICKETIDPH*", ticket.ticketId.ToString());
            body = body.Replace("*ASUNTOPH*", ticket.asunto);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = emp.personaEmail;
            correo.Subject = "Yanapay - Nuevo comentario";
            correo.Body = body;
            correo.IsHtml = true;

            if (servicioEmail.EnviarCorreo(correo) == false)
            {
                MessageBox.Show(
                "Ha ocurrido un error al enviar el correo de confirmación",
                "Correo no enviado",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {

            frmEscalarTicketAgente frm = new frmEscalarTicketAgente(this.ticket);
            frm.ShowDialog();
            
            lblAsunto.Text = ticket.asunto;
            lblId.Text = "# " + ticket.ticketId.ToString();
            lblFecIni.Text = ticket.fechaEnvio.Replace('-', '/').Replace("T", " - ");
            if (ticket.fechaCierreMaximo != null)
            {
                lblFecCieEst.Text = ticket.fechaCierreMaximo.Replace('-', '/').Replace("T", " - ");
            }
            else
            {
                lblFecCieEst.Text = "Error en la fecha";
            }
            lblEstado.Text = ticket.estado.nombre;
            lblBib.Text = ticket.biblioteca.nombre;
            lblCat.Text = ticket.categoria.nombre;
            lblUrg.Text = ticket.urgencia.nombre;
            if (ticket.activoFijo.activoFijoId > 0)
            {
                lblActFij.Text = ticket.activoFijo.codigo;
            }
            else
            {
                lblTituloActFij.Text = "";
            }

            // Segun el estado del ticket

            if (this.ticket.estado.estadoId == (int)Estado.Cerrado)
            {
                btnCambiarCategoria.Enabled = false;
                btnCerrarTicket.Enabled = false;
                btnEscalar.Enabled = false;
                btnVerTareas.Enabled = false;
                btnResponder.Enabled = false;
            }
            if (this.ticket.estado.estadoId == (int)Estado.Escalado)
            {
                btnCambiarCategoria.Enabled = false;
                //btnVerTareas.Enabled = false;
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            frmCerrarTicketAgente frm = new frmCerrarTicketAgente(ticket);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                sfdReporte.ShowDialog();
                ReporteWS.ReporteWSClient daoReporte = new ReporteWS.ReporteWSClient();
                byte[] arreglo = daoReporte.generarReporteTickets(ticket.ticketId);
                File.WriteAllBytes(sfdReporte.FileName + ".pdf", arreglo);
                MessageBox.Show("Se ha guardado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
