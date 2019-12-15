using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CESIM.Data;
using CESIM.Models;
using Microsoft.AspNetCore.Authorization;

namespace CESIM.Pages.Estudiantes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public IndexModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; }

        public async Task OnGetAsync()
        {
            Estudiante = await _context.Estudiantes
                .Include(e => e.Tutor).ToListAsync();
        }
    }
}
