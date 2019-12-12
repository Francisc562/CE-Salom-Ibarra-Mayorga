using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CESIM.Models
{

    public enum Seccion
    {
        A, B, C
    }
    public class Matricula
    {
        
        public int matriculaID { get; set; }
        public int gradoID { get; set; }
       
        public int estudianteID { get; set; }

        public Seccion? Seccion { get; set; }


        public Grado Grado { get; set; }
      
        public Estudiante Estudiante { get; set; }

    }
}
