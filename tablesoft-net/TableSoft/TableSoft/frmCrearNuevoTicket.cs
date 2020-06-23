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
        private BindingList<BibliotecaWS.biblioteca> bibliotecas;
        private BindingList<CategoriaWS.categoria> categorias;
        private BindingList<UrgenciaWS.urgencia> urgencias;

        public frmCrearNuevoTicket()
        {
            InitializeComponent();
            bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibliotecaDAO.listarBibliotecas().ToArray());
            categorias = new BindingList<CategoriaWS.categoria>(categoriaDAO.listarCategorias().ToArray());
            urgencias = new BindingList<UrgenciaWS.urgencia>(urgenciaDAO.listarUrgencias().ToArray());

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
    }
}
