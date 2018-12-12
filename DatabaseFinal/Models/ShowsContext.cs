using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFinal.Models
{
    public class ShowsContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<ShowHasGenre> ShowsHaveGenres { get; set; }


        public ShowsContext(DbContextOptions<ShowsContext> options)
        : base(options)
        {
            //create but leave empty to call the base class constructor
        }
    }
}
