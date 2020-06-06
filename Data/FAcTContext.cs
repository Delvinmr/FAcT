using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAcT.Models;

namespace FAcT.Data
{
    public class FAcTContext : DbContext
    {
        public FAcTContext (DbContextOptions<FAcTContext> options)
            : base(options)
        {
        }

        public DbSet<FAcT.Models.Articulos> Articulos { get; set; }

        public DbSet<FAcT.Models.Empleado> Empleado { get; set; }
    }
}
