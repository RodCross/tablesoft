using System;
using System.Windows.Forms;
using TableSoft.frmReportes;

namespace TableSoft
{
    public partial class frmGeneradorReportesAdministrador : Form
    {
        public frmGeneradorReportesAdministrador()
        {
            InitializeComponent();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Se ha generado el reporte con los parámetros seleccionados.",
               "Reporte generado exitosamente",
               MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void btnGenerarReporteCategoria_Click(object sender, EventArgs e)
        {
            frmSeleccionarObjeto frm = new frmSeleccionarObjeto(1);

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGenerarReporteUrgencia_Click(object sender, EventArgs e)
        {
            frmSeleccionarObjeto frm = new frmSeleccionarObjeto(2);

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGenerarReporteEquipo_Click(object sender, EventArgs e)
        {
            frmSeleccionarObjeto frm = new frmSeleccionarObjeto(4);

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }

        private void btnGenerarReporteAgente_Click(object sender, EventArgs e)
        {
            frmSeleccionarObjeto frm = new frmSeleccionarObjeto(3);

            frm.FormClosing += delegate
            {
                this.Show();
            };

            frm.Show();
            this.Hide();
        }
    }
}
