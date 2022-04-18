using Microsoft.EntityFrameworkCore;

namespace final_project.Models
{
    public class D2RandomContext : DbContext
    {
        public D2RandomContext(DbContextOptions<D2RandomContext> options)
        : base(options) { }

        public DbSet<D2Random> D2Randoms { get; set; }
    }
}