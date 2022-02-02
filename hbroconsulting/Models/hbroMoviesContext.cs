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

        protected override void OnModelCreating(ModelBuilder ab)
        {
            ab.Entity<movieresponse>().HasData(

                new movieresponse
                {
                    MovieId = 1,
                    Category = "Family",
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
                    Category = "Comedy",
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
                    Category = "Horror/Suspence",
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
