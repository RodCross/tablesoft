using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft.temp
{
    public class Ticket
    {
        private int _id;
        private String _asunto;
        private String _empleado;
        private DateTime _apertura;
        private DateTime _cierre;
        private String _estado;

        public Ticket()
        {
        }

        public Ticket(int id, string asunto, string empleado, DateTime apertura, DateTime cierre, string estado)
        {
            _id = id;
            _asunto = asunto;
            _empleado = empleado;
            _apertura = apertura;
            _cierre = cierre;
            _estado = estado;
        }

        public int Id { get => _id; set => _id = value; }
        public string Asunto { get => _asunto; set => _asunto = value; }
        public string Empleado { get => _empleado; set => _empleado = value; }
        public DateTime Apertura { get => _apertura; set => _apertura = value; }
        public DateTime Cierre { get => _cierre; set => _cierre = value; }
        public string Estado { get => _estado; set => _estado = value; }
    }
}
