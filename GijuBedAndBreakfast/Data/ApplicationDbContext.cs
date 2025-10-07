using Microsoft.EntityFrameworkCore;

namespace GijuBedAndBreakfast.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {

        }
    }
}
