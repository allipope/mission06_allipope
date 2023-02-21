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

        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Action/Adventure"},
                new Category { CategoryID = 2, CategoryName="Drama"},
                new Category { CategoryID = 3, CategoryName = "Comedy"},
                new Category { CategoryID = 4, CategoryName = "Thriller"},
                new Category { CategoryID = 5, CategoryName = "Musical"},
                new Category { CategoryID = 6, CategoryName = "Fantasy"},
                new Category { CategoryID = 7, CategoryName = "Documetary"},
                new Category { CategoryID = 8, CategoryName = "Romantic Comedy"}
                );

            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "Hunt for the Wilderpeople",
                    Director = "Taika Watiti",
                    Year = 2016,
                    Edited = false,
                    Rating = "pg13"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    CategoryID = 3,
                    Title = "The Intern",
                    Director = "Nancy Meyers",
                    Year = 2015,
                    Edited = false,
                    Rating = "pg13"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    CategoryID = 5,
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
