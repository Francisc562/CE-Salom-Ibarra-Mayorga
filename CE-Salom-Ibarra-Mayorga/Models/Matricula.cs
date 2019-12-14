using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CESIM.Models
{

   
    public class Matricula
    {
        
        public int matriculaID { get; set; }
        [Display(Name = "Grado")]
        public int gradoID { get; set; }
        [Display(Name = "Estudiante")]
        public int estudianteID { get; set; }
        public Seccion Seccion { get; set; }

       


        public Grado Grado { get; set; }
      
        public Estudiante Estudiante { get; set; }

    }
}
