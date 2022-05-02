using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project;

namespace final_project.Pages.Randomizer
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesD2RandomizerContext _context;

        public IndexModel(RazorPagesD2RandomizerContext context)
        {
            _context = context;
        }

        public IList<Armor> Armor { get;set; }

        public async Task OnGetAsync()
        {
            Armor = await _context.Armor.ToListAsync();
        }
    }
}
