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
    public class IndexModel : PageModel
    {
        private readonly CESIM.Data.CESIMContext _context;

        public IndexModel(CESIM.Data.CESIMContext context)
        {
            _context = context;
        }

        public IList<Tutor> Tutor { get;set; }

        public async Task OnGetAsync()
        {
            Tutor = await _context.Tutors.ToListAsync();
        }
    }
}
