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
    public partial class frmCrearNuevoTicket : Form
    {
        private TicketWS.TicketWSClient ticketDAO = new TicketWS.TicketWSClient();
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private UrgenciaWS.UrgenciaWSClient urgenciaDAO = new UrgenciaWS.UrgenciaWSClient();
        private ActivoFijoWS.ActivoFijoWSClient activoFijoDAO = new ActivoFijoWS.ActivoFijoWSClient();
        private TicketWS.ticket ticket;
        private BindingList<BibliotecaWS.biblioteca> bibliotecas;
        private BindingList<CategoriaWS.categoria> categorias;
        private BindingList<UrgenciaWS.urgencia> urgencias;
        private BindingList<ActivoFijoWS.activoFijo> activosFijos;
        private ActivoFijoWS.activoFijo actFij;

        public frmCrearNuevoTicket()
        {
            ticket = new TicketWS.ticket();
            InitializeComponent();
            var bibl = bibliotecaDAO.listarBibliotecas();
            var cate = categoriaDAO.listarCategorias();
            var urge = urgenciaDAO.listarUrgencias();

            if(bibl == null)
            {
                bibliotecas = new BindingList<BibliotecaWS.biblioteca>();
            }
            else
            {
                bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibl);
            }
            if (cate == null)
            {
                categorias = new BindingList<CategoriaWS.categoria>();
            }
            else
            {
                categorias = new BindingList<CategoriaWS.categoria>(cate);
            }
            if (urge == null)
            {
                urgencias = new BindingList<UrgenciaWS.urgencia>();
            }
            else
            {
                urgencias = new BindingList<UrgenciaWS.urgencia>(urge);
            }

            cboBiblioteca.DataSource = bibliotecas;
            cboBiblioteca.DisplayMember = "nombre";

            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "nombre";

            cboUrgencia.DataSource = urgencias;
            cboUrgencia.DisplayMember = "nombre";

            limpiarComponentes();
        }

        private void limpiarComponentes()
        {
            txtAsunto.Text = "";
            rtfDescripcion.Text = "";
            cboBiblioteca.SelectedItem = -1;
            cboCategoria.SelectedItem = -1;
            cboUrgencia.SelectedItem = -1;
            txtActivoFijo.Text = "";
            txtNombreActivoFijo.Text = "";
            txtEmail.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtAsunto.Text == "")
            {
                MessageBox.Show(
                    "El asunto no puede estar vacío",
                    "Error de asunto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtAsunto.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "Este asunto no es válido.",
                    "Error de asunto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (rtfDescripcion.Text == "")
            {
                MessageBox.Show(
                    "La descripción no puede estar vacía.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(rtfDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "Esta descripción no es válida.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar la biblioteca del ticket.",
                    "Error de biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar la categoria del ticket.",
                    "Error de categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (cboUrgencia.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Falta seleccionar la urgencia del ticket.",
                    "Error de urgencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtActivoFijo.Text != "")
            {
                if (!Regex.IsMatch(txtActivoFijo.Text, @"[0-9]"))
                {
                    MessageBox.Show(
                        "El codigo del activo fijo del ticket de contener solo numeros.",
                        "Error de de activo fijo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if (Regex.Matches(txtActivoFijo.Text, @"[0-9]").Count > 5)
                {
                    MessageBox.Show(
                        "El codigo del activo fijo del ticket de contener maximo 5 numeros.",
                        "Error de activo fijo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
                if (lblErrActFij.Text == "Codigo de activo fijo no valido")
                {
                    MessageBox.Show(
                        "El codigo del activo fijo del ticket debe ser valido.",
                        "Error de activo fijo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
            }
            if (txtEmail.Text != "")
            {
                if (!Regex.Match(txtEmail.Text, @"^([\w-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([\w-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$").Success)
                {
                    MessageBox.Show(
                        "Debe ingresar un email válido.",
                        "Error de email",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    return;
                }
            }
            ticket.asunto = txtAsunto.Text;
            ticket.descripcion = rtfDescripcion.Text;

            ticket.biblioteca = new TicketWS.biblioteca();
            BibliotecaWS.biblioteca bibliotecaAux = (BibliotecaWS.biblioteca)cboBiblioteca.SelectedItem;
            ticket.biblioteca.bibliotecaId = bibliotecaAux.bibliotecaId;
            ticket.biblioteca.nombre = bibliotecaAux.nombre;
            ticket.biblioteca.abreviatura = bibliotecaAux.abreviatura;
            ticket.biblioteca.activo = bibliotecaAux.activo;

            ticket.categoria= new TicketWS.categoria();
            CategoriaWS.categoria categoriaAux = (CategoriaWS.categoria)cboCategoria.SelectedItem;
            ticket.categoria.categoriaId= categoriaAux.categoriaId;
            ticket.categoria.nombre = categoriaAux.nombre;
            ticket.categoria.descripcion = categoriaAux.descripcion;
            ticket.categoria.activo = categoriaAux.activo;

            ticket.urgencia = new TicketWS.urgencia();
            UrgenciaWS.urgencia urgenciaAux = (UrgenciaWS.urgencia)cboUrgencia.SelectedItem;
            ticket.urgencia.urgenciaId= urgenciaAux.urgenciaId;
            ticket.urgencia.nombre = urgenciaAux.nombre;
            ticket.urgencia.plazoMaximo = urgenciaAux.plazoMaximo;
            ticket.urgencia.activo = urgenciaAux.activo;

            ticket.empleado = new TicketWS.empleado();
            ticket.empleado.empleadoId = frmInicioSesion.empleadoLogueado.empleadoId;
            ticket.estado = new TicketWS.estadoTicket();
            ticket.estado.estadoId = 1;
            
            ticket.activoFijo = new TicketWS.activoFijo();
            if (txtActivoFijo.Text != "")
            {
                ticket.activoFijo.activoFijoId = actFij.activoFijoId;
                ticket.activoFijo.codigo = actFij.codigo;
            }

           
            
            
            if (txtActivoFijo.Text != "")
            {
                ticket.activoFijo.activoFijoId = actFij.activoFijoId;
                ticket.activoFijo.tipo = actFij.tipo;
                ticket.activoFijo.marca = actFij.marca;
                ticket.activoFijo.nombre = actFij.nombre;
                ticket.activoFijo.activo = actFij.activo;
            }

            if (txtEmail.Text != "")
            {
                ticket.alumnoEmail = txtEmail.Text;
            }
            else
            {
                ticket.alumnoEmail = "";
            }

            if (MessageBox.Show("¿Desea crear el registro?", "Crear Ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ticketDAO.insertarTicket(ticket) > 0)
                {
                    MessageBox.Show(
                    "Ticket correctamente creado y enviado",
                    "Envio exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha creado el registro",
                    "Registro no realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                limpiarComponentes();
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void txtActivoFijo_Leave(object sender, EventArgs e)
        {
            if (txtActivoFijo.Text != "")
            {
                activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
                actFij = null;
                foreach (ActivoFijoWS.activoFijo aux in activosFijos)
                {
                    if (aux.codigo == txtActivoFijo.Text)
                    {
                        actFij = aux;
                        break;
                    }
                }
                if (actFij == null)
                {
                    lblErrActFij.Text = "Codigo de activo fijo no valido";
                    txtNombreActivoFijo.Text = "";
                }
                else
                {
                    lblErrActFij.Text = "";
                    txtNombreActivoFijo.Text = actFij.nombre;
                }
            }
            else
            {
                lblErrActFij.Text = "";
            }
        }
    }
}
