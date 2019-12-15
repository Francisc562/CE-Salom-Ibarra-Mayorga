using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Matriculas
{
    public class CreateModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public CreateModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["estudianteID"] = new SelectList(_context.Estudiantes, "estudianteID", "Nombres");
        ViewData["gradoID"] = new SelectList(_context.Grados, "gradoID", "Nivel");
            return Page();
        }

        [BindProperty]
        public Matricula Matricula { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Matriculas.Add(Matricula);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
