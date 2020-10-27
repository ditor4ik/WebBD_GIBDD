using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_GIBDD.Models;

namespace WebBD_GIBDD.Data
{
    public class WebBD_GIBDDContext : DbContext
    {
        public WebBD_GIBDDContext (DbContextOptions<WebBD_GIBDDContext> options)
            : base(options)
        {
        }

        public DbSet<BD_GIBDD.Models.Rank> Rank { get; set; }

        public DbSet<BD_GIBDD.Models.Position> Position { get; set; }

        public DbSet<BD_GIBDD.Models.Driver> Driver { get; set; }

        public DbSet<BD_GIBDD.Models.Staff> Staff { get; set; }

        public DbSet<BD_GIBDD.Models.BrandAuto> BrandAuto { get; set; }

        public DbSet<BD_GIBDD.Models.CarsStolen> CarsStolen { get; set; }

        public DbSet<BD_GIBDD.Models.Auto> Auto { get; set; }
    }
}
