using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public IList<Primary> Primary { get; set; }
        public IList<Secondary> Secondary { get; set; }
        public IList<Heavy> Heavy { get; set; }
        public IList<Armor> Armor { get; set; }
    }
}