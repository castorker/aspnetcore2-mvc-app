using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtistRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Artist> GetAllArtists()
        {
            return _appDbContext.Artists;
        }

        public Artist GetArtistById(int id)
        {
            return _appDbContext.Artists.FirstOrDefault(a => a.Id == id);
        }
    }
}
