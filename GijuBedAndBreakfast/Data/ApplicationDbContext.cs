using GijuBedAndBreakfast.Models;
using Microsoft.EntityFrameworkCore;

namespace GijuBedAndBreakfast.Data
{
    public class ApplicationDbContext : DbContext
    {
        // ctor for DI
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets must be declared as class members (not inside the ctor)
        public DbSet<Category> Categories { get; set; }
    }
}
