using Microsoft.EntityFrameworkCore;

namespace MotaAPI
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }

        // public DbSet<CompetitionEvents> Comp { get; set; }
    }
}
