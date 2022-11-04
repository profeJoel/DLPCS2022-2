using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options) { }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().ToTable("Autor");
            modelBuilder.Entity<Libro>().ToTable("Libro");
        }
    }
}