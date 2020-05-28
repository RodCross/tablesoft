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
    public partial class frmEscalarTicketAgente : Form
    {
        public frmEscalarTicketAgente()
        {
            InitializeComponent();
        }

        private void frmEscalarTicketAgente_Load(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se ha escalado el ticket al proveedor.",
                "Escalamiento exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
