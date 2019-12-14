using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CESIM.Models
{
    public enum lev
    {
        Prescolar, Primero, Segundo, Tercero, Cuarto, Quinto, Sexto
    }
    public enum Seccion
    {
        A, B, C
    }
    public class Grado
    {
        public int gradoID { get; set; }
        [Display(Name = "Docente")]
        public int docenteID { get; set; }

        public lev? Nivel { get; set; }
        public Seccion? Seccion { get; set; }
        public Docente Docente { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
