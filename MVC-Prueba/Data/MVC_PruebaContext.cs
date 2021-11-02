using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVC_Prueba.Data
{
    public class MVC_PruebaContext : DbContext
    {
        public MVC_PruebaContext (DbContextOptions<MVC_PruebaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
