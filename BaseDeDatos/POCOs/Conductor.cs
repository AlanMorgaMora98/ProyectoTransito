using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.POCOs
{
    class Conductor
    {
        private int idConductor;
        private int numeroLicenciaConducir;
        private DateTime fechaNacimiento;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string nombres;

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public int NumeroLicenciaConducir { get => numeroLicenciaConducir; set => numeroLicenciaConducir = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
    }
}
