using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public class ArtworkRepository : IArtworkRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtworkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Artwork> GetAllArtworks()
        {
            return _appDbContext.Artworks;
        }

        public IEnumerable<Artwork> GetAllArtworksByArtistId(int id)
        {
            return _appDbContext.Artworks.Where(a => a.ArtistId == id).OrderBy(a => a.Year);
        }

        public Artwork GetArtworkById(int id)
        {
            return _appDbContext.Artworks.FirstOrDefault(a => a.Id == id);
        }
    }
}
