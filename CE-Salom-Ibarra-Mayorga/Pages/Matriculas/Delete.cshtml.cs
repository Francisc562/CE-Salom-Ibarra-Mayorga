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
    public class DeleteModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DeleteModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Matricula = await _context.Matriculas.FindAsync(id);

            if (Matricula != null)
            {
                _context.Matriculas.Remove(Matricula);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
