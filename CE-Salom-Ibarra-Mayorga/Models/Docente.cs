using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CESIM.Models
{

    public class Docente
    {
        public int docenteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public ICollection<Grado> Grados { get; set; }

    }
}
