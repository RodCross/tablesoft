using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lanzamos el Formulario
            //Application.Run(new frmInicioEmpleado());
            Application.Run(new frmHistorialTicket());
        }
    }
}
