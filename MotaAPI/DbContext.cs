using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotaAPI
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }

        // public DbSet<CompetitionEvents> Comp { get; set; }

        public DbSet<Athl_Competition> athl_Competition { get; set; }



        //public DbSet<Code> Code { get; set; }
        
        /*[NotMapped]
        public Code code { get; set; } //internal set; }
        */
    }
}
