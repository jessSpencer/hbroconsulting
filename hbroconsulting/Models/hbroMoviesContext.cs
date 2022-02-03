using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hbroconsulting.Models
{
    public class hbroMoviesContext : DbContext
    {
        //Constructor
        public hbroMoviesContext (DbContextOptions<hbroMoviesContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<movieresponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder ab)
        {
            ab.Entity<Category>().HasData(
                new Category { CategoryId = 9, CategoryName = "Action/Adventure" }, new Category { CategoryId = 1, CategoryName = "Comedy" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );
            ab.Entity<movieresponse>().HasData(

                new movieresponse
                {
                    MovieId = 1,
                    CategoryId = 4,
                    Title = "Encanto",
                    Year = 2021,
                    Director = "Byron Howard",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "mom",
                    Notes = "no"
                },
                new movieresponse
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Hot Rot",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Lindy",
                    Notes = "no"
                },
                new movieresponse
                {
                    MovieId = 3,
                    CategoryId = 5,
                    Title = "A Quiet Place",
                    Year = 2018,
                    Director = "John Krasinski",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "paul",
                    Notes = "no"
                }
            );
        }
    }
}
