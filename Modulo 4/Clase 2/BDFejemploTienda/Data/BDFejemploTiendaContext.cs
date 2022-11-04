using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDFejemploTienda.Models;

namespace BDFejemploTienda.Data
{
    public class BDFejemploTiendaContext : DbContext
    {
        public BDFejemploTiendaContext (DbContextOptions<BDFejemploTiendaContext> options)
            : base(options)
        {
        }

        public DbSet<BDFejemploTienda.Models.Clientes> Clientes { get; set; } = default!;
    }
}
