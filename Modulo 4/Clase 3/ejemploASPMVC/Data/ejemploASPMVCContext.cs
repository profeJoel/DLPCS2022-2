using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ejemploASPMVC.Models;

namespace ejemploASPMVC.Data
{
    public class ejemploASPMVCContext : DbContext
    {
        public ejemploASPMVCContext (DbContextOptions<ejemploASPMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ejemploASPMVC.Models.Automovil> Automovil { get; set; } = default!;

        public DbSet<ejemploASPMVC.Models.Marca> Marca { get; set; }
    }
}
