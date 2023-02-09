using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_allipope.Models
{
    public class MovieContext : DbContext
    {
        // constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // leave it blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Adventure/Comedy",
                    Title = "Hunt for the Wilderpeople",
                    Director = "Taika Watiti",
                    Year = 2016,
                    Edited = false,
                    Rating = "pg13"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Comedy/Drama",
                    Title = "The Intern",
                    Director = "Nancy Meyers",
                    Year = 2015,
                    Edited = false,
                    Rating = "pg13"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Musical",
                    Title = "Mamma Mia!",
                    Director = "Phyllida Lloyd",
                    Year = 2008,
                    Edited = false,
                    Rating = "pg13"
                }
            );
        }
    }
}
