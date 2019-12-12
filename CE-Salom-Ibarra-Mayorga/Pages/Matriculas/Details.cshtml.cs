using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Matriculas
{
    public class DetailsModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DetailsModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public Matricula Matricula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Matricula = await _context.Matriculas
                .Include(m => m.Estudiante)
                .Include(m => m.Grado).FirstOrDefaultAsync(m => m.matriculaID == id);

            if (Matricula == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
