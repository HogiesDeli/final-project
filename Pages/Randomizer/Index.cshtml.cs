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

        public async Task OnGetAsync()
        {
            var armor = _context.Armor.Select(a => a);
            Random rand = new Random();
            int toSkip = rand.Next(1, Armor.Count());  

            Armor = await armor.Skip(toSkip).Take(1).ToListAsync();
        }
    }
}
