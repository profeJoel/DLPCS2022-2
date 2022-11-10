using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EjemploASPNETMVCCF.Models;

namespace EjemploASPNETMVCCF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EjemploASPNETMVCCF.Models.Persona> Persona { get; set; }
        public DbSet<EjemploASPNETMVCCF.Models.Asignatura> Asignatura { get; set; }
        public DbSet<EjemploASPNETMVCCF.Models.Curso> Curso { get; set; }
    }
}