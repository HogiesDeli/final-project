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
    public class PrimaryModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public PrimaryModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IList<Primary> Primary { get; set; }

        public async Task OnGetAsync()
        {
            Primary = await _context.Primary.ToListAsync();
        }
    }
}
