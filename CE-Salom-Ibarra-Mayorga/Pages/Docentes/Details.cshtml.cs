using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Docentes
{
    public class DetailsModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DetailsModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public Docente Docente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Docente = await _context.Docente
          .Include(s => s.Grados)
          .ThenInclude(e => e.Matriculas)

          .AsNoTracking()
          .FirstOrDefaultAsync(m => m.docenteID == id);

            if (Docente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
