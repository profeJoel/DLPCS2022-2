using Microsoft.EntityFrameworkCore;

namespace BDAutomotora
{
    public class AutomotoraContext : DbContext
    {
        public AutomotoraContext(DbContextOptions<AutomotoraContext> options)
            : base(options)
        {

        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Automovil> Automovils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Automovil>().ToTable("Automovil");
        }

    }
}