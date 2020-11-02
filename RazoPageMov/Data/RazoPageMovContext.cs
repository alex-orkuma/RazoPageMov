using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazoPageMov.Models;

namespace RazoPageMov.Data
{
    public class RazoPageMovContext : DbContext
    {
        public RazoPageMovContext (DbContextOptions<RazoPageMovContext> options)
            : base(options)
        {
        }

        public DbSet<RazoPageMov.Models.Movie> Movie { get; set; }
    }
}
