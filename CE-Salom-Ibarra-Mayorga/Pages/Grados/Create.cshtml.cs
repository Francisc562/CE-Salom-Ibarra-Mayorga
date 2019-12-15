using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Grados
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
        ViewData["docenteID"] = new SelectList(_context.Docentes, "docenteID", "Nombres");
            return Page();
        }

        [BindProperty]
        public Grado Grado { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Grados.Add(Grado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
