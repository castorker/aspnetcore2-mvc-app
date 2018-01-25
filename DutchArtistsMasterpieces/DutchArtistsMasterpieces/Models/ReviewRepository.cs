using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddReview(Review review)
        {
            _appDbContext.Reviews.Add(review);
            _appDbContext.SaveChanges();
        }
    }
}
