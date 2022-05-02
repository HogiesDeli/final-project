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
    public class DeleteModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public DeleteModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Armor = await _context.Armor.FindAsync(id);

            if (Armor != null)
            {
                _context.Armor.Remove(Armor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
