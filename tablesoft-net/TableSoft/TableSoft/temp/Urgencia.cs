using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft.temp
{
    public class Urgencia
    {
        private int _urgenciaId;
        private String _nombre;
        private int _plazoMaximo;

        public Urgencia()
        {
        }

        public Urgencia(int id, string nombre, int plazoMaximo)
        {
            _urgenciaId = id;
            _nombre = nombre;
            _plazoMaximo = plazoMaximo;
        }

        public Urgencia(string nombre, int plazoMaximo)
        {
            _nombre = nombre;
            _plazoMaximo = plazoMaximo;
        }

        public int UrgenciaId { get => _urgenciaId; set => _urgenciaId = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int PlazoMaximo { get => _plazoMaximo; set => _plazoMaximo = value; }
    }
}
