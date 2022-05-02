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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesD2RandomizerContext _context;

        public DetailsModel(RazorPagesD2RandomizerContext context)
        {
            _context = context;
        }

        public Armor Armor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Armor = await _context.Armor.FirstOrDefaultAsync(m => m.ArmorID == id);

            if (Armor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
