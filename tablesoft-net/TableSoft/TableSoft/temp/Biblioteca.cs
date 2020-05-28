using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft.temp
{
    public class Biblioteca
    {
        private String _nombre;
        private String _abreviatura;

        public Biblioteca()
        {
        }

        public Biblioteca(string nombre, string abreviatura)
        {
            _nombre = nombre;
            _abreviatura = abreviatura;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Abreviatura { get => _abreviatura; set => _abreviatura = value; }
    }
}
