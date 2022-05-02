using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using final_project;

    public class RazorPagesD2RandomizerContext : DbContext
    {
        public RazorPagesD2RandomizerContext (DbContextOptions<RazorPagesD2RandomizerContext> options)
            : base(options)
        {
        }

        public DbSet<final_project.Armor> Armor { get; set; }
    }
