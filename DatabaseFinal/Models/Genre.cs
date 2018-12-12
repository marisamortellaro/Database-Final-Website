using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFinal.Models
{
    public class Genre 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public ShowHasGenre ShowsHaveGenre { get; set; }
        public ICollection<ShowHasGenre> ShowsHaveGenre { get; set; } = new List<ShowHasGenre>();



    }
}