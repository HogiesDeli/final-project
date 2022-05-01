using Microsoft.EntityFrameworkCore;

namespace final_project.Models
{
    public class D2RandomContext : DbContext
    {
        public D2RandomContext(DbContextOptions<D2RandomContext> options)
        : base(options) { }

        public DbSet<Primary> Primary { get; set; }
        public DbSet<Secondary> Secondary{ get; set; }
        public DbSet<Heavy> Heavy { get; set; }
        public DbSet<Armor> Armor { get; set; }

    }
}