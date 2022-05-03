using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace Autohaendler_Teil2.Data
{
    public class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options)
        {

        }
        public DbSet<Hersteller> Herstellers { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Autoverkauf> Autoverkaufs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Herstellers>().ToTable("Hersteller");
            modelBuilder.Entity<Autos>().ToTable("Auto");
            modelBuilder.Entity<Autoverkaufs>().ToTable("Autoverkauf");
        }
    }
}
