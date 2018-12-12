using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatabaseFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFinal.Controllers
{
    public class HomeController : Controller
    {
        private ShowsContext context;
        public HomeController(ShowsContext c)
        {
            context = c;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddAnime()
        {
            return View(context.Animes.ToList());
        }
        
        [HttpPost]
        public IActionResult HandleNewAnime(string name, string description, string company)
        {
            Anime newAnime = new Anime() { Name = name, Description = description, Company = company};
            context.Animes.Add(newAnime);
            context.SaveChanges();

            return RedirectToAction("AddAnime");
        }

        public IActionResult AddSeason()
        {
            //var allAnime = context.Animes.Include(anime => anime.Name).ToList();
            ViewData["animeNames"] = context.Animes.Include(Animes=> Animes.Seasons).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult HandleNewSeason(int animeID, int seasonNum, string description, int numEpisodes)
        {
            Anime existingAnime = context.Animes.Where(location => location.Id == animeID).Single();
            Season newSeason = new Season() { Anime = existingAnime, SeasonNum = seasonNum, Description = description, NumEpisodes = numEpisodes };
            context.Seasons.Add(newSeason);
            context.SaveChanges();

            return RedirectToAction("AddSeason");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
