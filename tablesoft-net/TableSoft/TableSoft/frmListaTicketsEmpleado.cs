using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableSoft.temp; // para clases temporales

namespace TableSoft
{
    public partial class frmListaTicketsEmpleado : Form
    {
        BindingList<Ticket> tickets = new BindingList<Ticket>();
        Ticket t1 = new Ticket(
            19258321,
            "Falla en las impresoras del Complejo de Innovación Académica",
            "ROLDAN HUAYLLASCO, STEFANO",
            new DateTime(2020, 06, 18, 16, 20, 40),
            new DateTime(2020, 06, 20, 12, 51, 00),
            "Abierto"
        );

        public frmListaTicketsEmpleado()
        {
            InitializeComponent();
            tickets.Add(t1);
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.DataSource = tickets;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmInfoTicketEmpleado frm = new frmInfoTicketEmpleado();
            frm.ShowDialog();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
