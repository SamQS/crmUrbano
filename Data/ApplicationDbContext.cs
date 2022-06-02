using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using crmUrbano.Models;

namespace crmUrbano.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dco)
            : base(dco)
        {
        }

        public DbSet<Consulta> Consultas {get ;set; }
        public DbSet<crmUrbano.Models.Catalogo> Catalogo { get; set; }

        public DbSet<crmUrbano.Models.Carrito> Carrito { get; set; }

        
    }
}
