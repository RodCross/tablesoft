using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft.temp
{
    public class Urgencia
    {
        private String _nombre;
        private int _plazoMaximo;

        public Urgencia()
        {
        }

        public Urgencia(string nombre, int plazoMaximo)
        {
            _nombre = nombre;
            _plazoMaximo = plazoMaximo;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int PlazoMaximo { get => _plazoMaximo; set => _plazoMaximo = value; }
    }
}
