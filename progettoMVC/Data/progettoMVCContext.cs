using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using progettoMVC.Models;

namespace progettoMVC.Data
{
    public class progettoMVCContext : DbContext
    {
        public progettoMVCContext (DbContextOptions<progettoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<progettoMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
