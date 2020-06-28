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
    public partial class frmCrearNuevoTicket : Form
    {
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private UrgenciaWS.UrgenciaWSClient urgenciaDAO = new UrgenciaWS.UrgenciaWSClient();
        private ActivoFijoWS.ActivoFijoWSClient activoFijoDAO = new ActivoFijoWS.ActivoFijoWSClient();
        private BindingList<BibliotecaWS.biblioteca> bibliotecas;
        private BindingList<CategoriaWS.categoria> categorias;
        private BindingList<UrgenciaWS.urgencia> urgencias;
        private BindingList<ActivoFijoWS.activoFijo> activosFijos;

        public frmCrearNuevoTicket()
        {
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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ticket correctamente creado y enviado.",
                "Envío exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void txtActivoFijo_Leave(object sender, EventArgs e)
        {
            activosFijos = new BindingList<ActivoFijoWS.activoFijo>(activoFijoDAO.listarActivosFijos().ToArray());
            ActivoFijoWS.activoFijo actFij = null;
            foreach(ActivoFijoWS.activoFijo aux in activosFijos)
            {
                if(aux.codigo == txtActivoFijo.Text)
                {
                    actFij = aux;
                    break;
                }
            }
            if(actFij == null)
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
    }
}
