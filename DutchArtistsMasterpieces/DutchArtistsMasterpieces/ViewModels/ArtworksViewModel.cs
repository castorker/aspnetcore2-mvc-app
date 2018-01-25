using DutchArtistsMasterpieces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.ViewModels
{
    public class ArtworksViewModel
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public List<Artwork> Artworks { get; set; }
    }
}
