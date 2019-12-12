using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CESIM.Models
{
    public enum lev
    {
        Prescolar, Primero, Segundo, Tercero, Cuarto, Quinto, Sexto
    }
    public class Grado
    {
        public int gradoID { get; set; }

        public int docenteID { get; set; }

        public lev? Nivel { get; set; }

        public Docente Docente { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
