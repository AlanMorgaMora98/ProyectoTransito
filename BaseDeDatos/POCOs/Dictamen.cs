using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.POCOs
{
    class Dictamen
    {
        private string folio;
        private string nombreCompleto;
        private DateTime hora;
        private DateTime fecha;
        private string descripcion;

        public string Folio { get => folio; set => folio = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
