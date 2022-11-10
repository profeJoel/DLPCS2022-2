using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuiaEFDatabaseFirst.Models;

namespace GuiaEFDatabaseFirst.Data
{
    public class GuiaEFDatabaseFirstContext : DbContext
    {
        public GuiaEFDatabaseFirstContext (DbContextOptions<GuiaEFDatabaseFirstContext> options)
            : base(options)
        {
        }

        public DbSet<GuiaEFDatabaseFirst.Models.Clientes> Clientes { get; set; } = default!;
    }
}
