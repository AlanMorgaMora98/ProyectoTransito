using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.POCOs
{
    class DelegacionesMunicipales
    {
        private int idDelegacion;
        private string nombre;
        private int numero;
        private string colonia;
        private string calle;
        private int codigoPostal;
        private string correo;
        private string telefono;
        private string municipio;

        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Calle { get => calle; set => calle = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Municipio { get => municipio; set => municipio = value; }
    }
}
