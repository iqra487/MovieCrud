using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCrud.Data;
using MovieCrud.Models;
using MovieCrud.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieCrudContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieCrudContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        title = "When Harry Met Sally",
                        releasedDate = DateTime.Parse("1989-2-12"),
                        genre = "Romantic Comedy",
                        price = 7.99M
                    },

                    new Movie
                    {
                        title = "Ghostbusters ",
                        releasedDate = DateTime.Parse("1984-3-13"),
                        genre = "Comedy",
                        price = 8.99M
                    },

                    new Movie
                    {
                        title = "Ghostbusters 2",
                        releasedDate = DateTime.Parse("1986-2-23"),
                        genre = "Comedy",
                        price = 9.99M
                    },

                    new Movie
                    {
                        title = "Rio Bravo",
                        releasedDate = DateTime.Parse("1959-4-15"),
                        genre = "Western",
                        price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}