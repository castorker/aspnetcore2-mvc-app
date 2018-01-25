using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
    }
}
