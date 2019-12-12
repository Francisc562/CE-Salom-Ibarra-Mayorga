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
    public class DeleteModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DeleteModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grado = await _context.Grados.FindAsync(id);

            if (Grado != null)
            {
                _context.Grados.Remove(Grado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
