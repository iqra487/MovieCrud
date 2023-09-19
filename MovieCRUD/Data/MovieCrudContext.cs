using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCrud.Models;

namespace MovieCrud.Data
{
    public class MovieCrudContext : DbContext
    {
        public MovieCrudContext (DbContextOptions<MovieCrudContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCrud.Models.Movie> Movie { get; set; } = default!;
    }
}
