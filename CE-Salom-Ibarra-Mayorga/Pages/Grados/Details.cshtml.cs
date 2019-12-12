using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Grados
{
    public class DetailsModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DetailsModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public Grado Grado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grado = await _context.Grados
                .Include(g => g.Docente).FirstOrDefaultAsync(m => m.gradoID == id);

            if (Grado == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
