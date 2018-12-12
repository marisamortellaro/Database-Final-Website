using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFinal.Models
{
    public class ShowHasGenre
    {
       public int Id { get; set; }

        //public ICollection<Genre> Genres { get; set; } = new List<Genre>();
       //public ICollection<Anime> Anime { get; set; } = new List<Anime>();
        public Anime Anime { get; set; }
        public int AnimeId { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}