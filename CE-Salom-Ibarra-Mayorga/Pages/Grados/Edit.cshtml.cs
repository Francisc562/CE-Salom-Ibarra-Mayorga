using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Grados
{
    public class EditModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public EditModel(CESIM.Data.CESIMContext context)
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
           ViewData["docenteID"] = new SelectList(_context.Docentes, "docenteID", "docenteID");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Grado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradoExists(Grado.gradoID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GradoExists(int id)
        {
            return _context.Grados.Any(e => e.gradoID == id);
        }
    }
}
