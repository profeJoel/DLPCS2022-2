using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjemploAlmacen.Models;

namespace EjemploAlmacen.Data
{
    public class EjemploAlmacenContext : DbContext
    {
        public EjemploAlmacenContext (DbContextOptions<EjemploAlmacenContext> options)
            : base(options)
        {
        }

        public DbSet<EjemploAlmacen.Models.Product> Product { get; set; } = default!;
    }
}
