using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchArtistsMasterpieces.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchArtistsMasterpieces.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewRepository.AddReview(review);
                return RedirectToAction("ReviewComplete");
            }

            return View(review);
        }

        public IActionResult ReviewComplete()
        {
            return View();
        }
    }
}
