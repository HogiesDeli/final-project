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
    public class ArmorModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public ArmorModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IList<Armor> Armor { get; set; }

        public async Task OnGetAsync()
        {
            Armor = await _context.Armor.ToListAsync();
        }
    }
}
