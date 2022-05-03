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
    public class SecondaryModel : PageModel
    {
        private readonly final_project.Models.D2RandomContext _context;

        public SecondaryModel(final_project.Models.D2RandomContext context)
        {
            _context = context;
        }

        public IList<Secondary> Secondary { get; set; }

        //Paging
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        //Sorting
        [BindProperty(SupportsGet = true)]
        public string CurrentSort { get; set; }
        public SelectList SortList { get; set; }

        public async Task OnGetAsync()
        {
            var secondary = _context.Secondary.Select(s => s);
            List<SelectListItem> sortItems = new List<SelectListItem>
            {
                new SelectListItem {Text = "Alphabetical Ascending", Value = "first_asc"},
                new SelectListItem {Text="Alphabetical Decending", Value = "first_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                case "first_asc":
                    secondary = secondary.OrderBy(s => s.Sname);
                    break;
                case "first_desc":
                    secondary = secondary.OrderByDescending(s => s.Sname);
                    break;
            }
            Secondary = await secondary.ToListAsync();
        }
    }
}
