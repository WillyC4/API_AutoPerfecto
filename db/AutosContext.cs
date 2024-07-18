using API_AutoPerfecto.Models;
using Microsoft.EntityFrameworkCore;

namespace API_AutoPerfecto.db
{
    public class AutosContext : DbContext
    {
        public AutosContext(DbContextOptions<AutosContext> options)
            : base(options)
        {
        }

        public DbSet<Auto> Vehicles { get; set; }
    }
}
