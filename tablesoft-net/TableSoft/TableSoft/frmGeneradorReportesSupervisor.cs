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
    public partial class frmGeneradorReportesSupervisor : Form
    {
        public frmGeneradorReportesSupervisor()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
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
    }
}
