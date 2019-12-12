using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;

namespace CESIM.Pages.Tutores
{
    public class DetailsModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public DetailsModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public Tutor Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor = await _context.Tutors.FirstOrDefaultAsync(m => m.tutorID == id);

            if (Tutor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
