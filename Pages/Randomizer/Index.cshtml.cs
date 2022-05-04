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
    public class IndexModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public IndexModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IList<Armor> Armor { get; set; }
        public IList<Primary> Primary { get; set; }
        public IList<Secondary> Secondary { get; set; }
        public IList<Heavy> Heavy { get; set; }

        public async Task OnGetAsync()
        {
            var armor = _context.Armor.Select(a => a);
            Random Arand = new Random();
            int armSkip = Arand.Next(1, armor.Count());
            Armor = await armor.Skip(armSkip).Take(1).ToListAsync();

            var primary = _context.Primary.Select(a => a);
            Random Prand = new Random();
            int priSkip = Prand.Next(1, primary.Count());
            Primary = await primary.Skip(priSkip).Take(1).ToListAsync();

            var secondary = _context.Secondary.Select(a => a);
            Random Srand = new Random();
            int secSkip = Srand.Next(1, secondary.Count());
            Secondary = await secondary.Skip(secSkip).Take(1).ToListAsync();

            var heavy = _context.Heavy.Select(a => a);
            Random Hrand = new Random();
            int hevSkip = Hrand.Next(1, heavy.Count());
            Heavy = await heavy.Skip(hevSkip).Take(1).ToListAsync();
        }

         public async Task OnPostAsync()
        {
            var armor = _context.Armor.Select(a => a);
            Random Arand = new Random();
            int armSkip = Arand.Next(1, armor.Count());
            Armor = await armor.Skip(armSkip).Take(1).ToListAsync();

            var primary = _context.Primary.Select(a => a);
            Random Prand = new Random();
            int priSkip = Prand.Next(1, primary.Count());
            Primary = await primary.Skip(priSkip).Take(1).ToListAsync();

            var secondary = _context.Secondary.Select(a => a);
            Random Srand = new Random();
            int secSkip = Srand.Next(1, secondary.Count());
            Secondary = await secondary.Skip(secSkip).Take(1).ToListAsync();

            var heavy = _context.Heavy.Select(a => a);
            Random Hrand = new Random();
            int hevSkip = Hrand.Next(1, heavy.Count());
            Heavy = await heavy.Skip(hevSkip).Take(1).ToListAsync();
        }
    }
}
