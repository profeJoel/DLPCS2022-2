using Microsoft.EntityFrameworkCore;

namespace BDContactos
{
    public class ContactosContext : DbContext
    {
        public ContactosContext(DbContextOptions<ContactosContext> options)
            : base(options) { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().ToTable("Persona");
            modelBuilder.Entity<Contacto>().ToTable("Contacto");

        }

    }
}