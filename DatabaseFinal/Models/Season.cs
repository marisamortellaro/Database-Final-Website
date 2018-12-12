using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFinal.Models
{
    public class Season 
    {
        public int Id { get; set; }
        public int SeasonNum { get; set; }
        public string Description { get; set; }
        public int NumEpisodes { get; set; }

        public Anime Anime { get; set; }
        public int AnimeId { get; set; }
    }
}