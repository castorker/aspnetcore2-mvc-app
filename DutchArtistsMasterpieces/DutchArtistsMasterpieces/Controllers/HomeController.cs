using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchArtistsMasterpieces.Models;
using DutchArtistsMasterpieces.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchArtistsMasterpieces.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IArtworkRepository _artworkRepository;

        public HomeController(IArtistRepository artistRepository, IArtworkRepository artworkRepository)
        {
            _artistRepository = artistRepository;
            _artworkRepository = artworkRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var artists = _artistRepository.GetAllArtists().OrderBy(a => a.Id);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Famous Dutch Artists and their Masterpieces",
                Artists = artists.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var artist = _artistRepository.GetArtistById(id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        public IActionResult Artworks(int id)
        {
            var artist = _artistRepository.GetArtistById(id);

            var artworks = _artworkRepository.GetAllArtworksByArtistId(id).OrderBy(a => a.Year);

            var artworksViewModel = new ArtworksViewModel()
            {
                Title = $"{artist.Name} masterpieces",
                Artist = artist,
                Artworks = artworks.ToList()
            };

            return View(artworksViewModel);
        }
    }
}
