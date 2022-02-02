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

        public DbSet<movieresponse> Responses { get; set; }

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
                }
            );
        }
    }
}
