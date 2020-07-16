using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft.frmReportes
{
    public partial class frmSeleccionarFecha : Form
    {
        public frmSeleccionarFecha()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteWS.ReporteWSClient daoReporte = new ReporteWS.ReporteWSClient();
                byte[] arreglo;
                sfdReporte.ShowDialog();
                arreglo = daoReporte.generarReporteGeneral(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddHours(23).AddMinutes(59));
                File.WriteAllBytes(sfdReporte.FileName + ".pdf", arreglo);
                MessageBox.Show("Se ha guardado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
