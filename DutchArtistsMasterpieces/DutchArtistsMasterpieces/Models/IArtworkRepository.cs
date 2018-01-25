using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public interface IArtworkRepository
    {
        IEnumerable<Artwork> GetAllArtworks();

        Artwork GetArtworkById(int id);

        IEnumerable<Artwork> GetAllArtworksByArtistId(int id);
    }
}
