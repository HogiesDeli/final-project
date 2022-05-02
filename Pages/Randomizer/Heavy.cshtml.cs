using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project;
using final_project.Models;

namespace final_project.Pages.Randomizer
{
    public class HeavyModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public HeavyModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IList<Heavy> Heavy { get; set; }

        public async Task OnGetAsync()
        {
            Heavy = await _context.Heavy.ToListAsync();
        }
    }
}