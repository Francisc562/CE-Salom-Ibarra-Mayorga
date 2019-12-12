using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Estudiantes
{
    public class DeleteModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DeleteModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estudiante = await _context.Estudiantes
                .Include(e => e.Tutor).FirstOrDefaultAsync(m => m.estudianteID == id);

            if (Estudiante == null)
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

            Estudiante = await _context.Estudiantes.FindAsync(id);

            if (Estudiante != null)
            {
                _context.Estudiantes.Remove(Estudiante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
