using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFinal.Models
{
    public class Anime 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }

        public ICollection<Season> Seasons { get; set; } = new List<Season>();
        public ICollection<ShowHasGenre> ShowHasGenres { get; set; } = new List<ShowHasGenre>();
       // public ShowHasGenre ShowHasGenres { get; set; }
    }
}