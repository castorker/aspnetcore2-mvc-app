using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchArtistsMasterpieces.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchArtistsMasterpieces.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtistRepository _artistRepository;

        public HomeController(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Artist overview";

            var artists = _artistRepository.GetAllArtists().OrderBy(a => a.Name);

            return View(artists);
        }
    }
}
