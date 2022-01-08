using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Models;

namespace Proiect_MPD.Data
{
    public class Proiect_MPDContext : DbContext
    {
        public Proiect_MPDContext (DbContextOptions<Proiect_MPDContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_MPD.Models.Product> Product { get; set; }

        public DbSet<Proiect_MPD.Models.Retailer> Retailer { get; set; }

        public DbSet<Proiect_MPD.Models.Category> Category { get; set; }
    }
}
