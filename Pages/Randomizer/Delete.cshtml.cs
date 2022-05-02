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

        [BindProperty]
        public Primary Primary { get; set; }

        [BindProperty]
        public Secondary Secondary { get; set; }

        [BindProperty]
        public Heavy Heavy { get; set; }

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

            Primary = await _context.Primary.FirstOrDefaultAsync(m => m.PrimaryID == id);

            if (Primary == null)
            {
                return NotFound();
            }

            Secondary = await _context.Secondary.FirstOrDefaultAsync(m => m.SecondaryID == id);

            if (Secondary == null)
            {
                return NotFound();
            }

            Heavy = await _context.Heavy.FirstOrDefaultAsync(m => m.HeavyID == id);

            if (Heavy == null)
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

            Primary = await _context.Primary.FindAsync(id);

            if (Primary != null)
            {
                _context.Primary.Remove(Primary);
                await _context.SaveChangesAsync();
            }

            Secondary = await _context.Secondary.FindAsync(id);

            if (Secondary != null)
            {
                _context.Secondary.Remove(Secondary);
                await _context.SaveChangesAsync();
            }

            Heavy = await _context.Heavy.FindAsync(id);

            if (Heavy != null)
            {
                _context.Heavy.Remove(Heavy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
