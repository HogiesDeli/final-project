using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //Paging
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        //Search Bar
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {
            //Search Bar Query
            var armor = _context.Armor.Select(a => a);
            armor = from a in _context.Armor
                    select a;
            if (!string.IsNullOrEmpty(SearchString))
            {
                armor = armor.Where(s => s.Aname.Contains(SearchString));
            }

            Armor = await armor.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
