using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists();

        Artist GetArtistById(int id);
    }
}
