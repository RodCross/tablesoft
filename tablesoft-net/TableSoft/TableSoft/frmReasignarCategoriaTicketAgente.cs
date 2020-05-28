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
    public partial class frmReasignarCategoriaTicketAgente : Form
    {
        public frmReasignarCategoriaTicketAgente()
        {
            InitializeComponent();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnReasignar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha cambiado la categoría anterior a la seleccionada.",
                "Reasignación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
