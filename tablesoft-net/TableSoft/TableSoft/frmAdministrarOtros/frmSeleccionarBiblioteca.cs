using System;
using System.ComponentModel;
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
            var bibls = bibliotecaDAO.listarBibliotecas();
            if(bibls == null)
            {
                bibliotecas = new BindingList<BibliotecaWS.biblioteca>();
            }
            else
            {
                bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibls);
            }
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
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var bibls = bibliotecaDAO.listarBibliotecas();
                if (bibls == null)
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>();
                }
                else
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibls);
                }
                dgvGestionar.DataSource = bibliotecas;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            BibliotecaWS.biblioteca bibl = (BibliotecaWS.biblioteca)dgvGestionar.CurrentRow.DataBoundItem;
            frmGestionarBiblioteca frm = new frmGestionarBiblioteca(bibl);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var bibls = bibliotecaDAO.listarBibliotecas();
                if (bibls == null)
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>();
                }
                else
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibls);
                }
                dgvGestionar.DataSource = bibliotecas;
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BibliotecaWS.biblioteca bibl = (BibliotecaWS.biblioteca)dgvGestionar.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Biblioteca", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bibliotecaDAO.eliminarBiblioteca(bibl) > -1)
                {
                    MessageBox.Show(
                    "Se ha eliminado el registro exitosamente",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se eliminó el registro",
                    "Eliminación no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                var bibls = bibliotecaDAO.listarBibliotecas();
                if (bibls == null)
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>();
                }
                else
                {
                    bibliotecas = new BindingList<BibliotecaWS.biblioteca>(bibls);
                }
                dgvGestionar.DataSource = bibliotecas;
            }
            else
            {
                MessageBox.Show(
                "No se eliminó el registro",
                "Eliminación no realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }
    }
}
