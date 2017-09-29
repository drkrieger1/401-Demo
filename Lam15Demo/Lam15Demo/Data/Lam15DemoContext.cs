using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lam15Demo.Models
{
    public class Lam15DemoContext : DbContext
    {
        public Lam15DemoContext (DbContextOptions<Lam15DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Lam15Demo.Models.Movie> Movie { get; set; }
    }
}
