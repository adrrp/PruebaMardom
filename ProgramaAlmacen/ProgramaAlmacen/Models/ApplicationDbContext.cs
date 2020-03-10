using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaAlmacen.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Almacenes> Almacenes { get; set; }
        public DbSet<Anexos> Anexos { get; set; }

        public DbSet<Articulo> Articulo { get; set; }

        public DbSet<Articulo_Proveedores> Articulo_Proveedores { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
    }
}
