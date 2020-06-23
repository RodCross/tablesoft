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
    public partial class frmSeleccionarBiblioteca : Form
    {
        private BibliotecaWS.BibliotecaWSClient bibliotecaDAO = new BibliotecaWS.BibliotecaWSClient();
        private BindingList<BibliotecaWS.biblioteca> bibliotecas;

        public frmSeleccionarBiblioteca()
        {
            InitializeComponent();
            bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibliotecaDAO.listarBibliotecas().ToArray());
            dgvGestionar.AutoGenerateColumns = false;
            dgvGestionar.DataSource = bibliotecas;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarBiblioteca frm = new frmGestionarBiblioteca();
            frm.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            BibliotecaWS.biblioteca bibl = (BibliotecaWS.biblioteca)dgvGestionar.CurrentRow.DataBoundItem;
            frmGestionarBiblioteca frm = new frmGestionarBiblioteca(bibl);
            frm.ShowDialog();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
