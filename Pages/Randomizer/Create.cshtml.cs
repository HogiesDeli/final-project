using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using final_project;
using final_project.Models;

namespace final_project.Pages.Randomizer
{
    public class CreateModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public CreateModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Armor Armor { get; set; }

        // [BindProperty]
        // public Primary Primary { get; set; }

        // [BindProperty]
        // public Secondary Secondary { get; set; }

        // [BindProperty]
        // public Heavy Heavy { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Armor.Add(Armor);
            
            // _context.Primary.Add(Primary);

            // _context.Secondary.Add(Secondary);

            // _context.Heavy.Add(Heavy);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


    }
}
