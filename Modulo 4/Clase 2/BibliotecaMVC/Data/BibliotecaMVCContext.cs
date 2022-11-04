using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class BibliotecaMVCContext : DbContext
    {
        public BibliotecaMVCContext (DbContextOptions<BibliotecaMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BibliotecaMVC.Models.Autor> Autor { get; set; } = default!;
    }
}
