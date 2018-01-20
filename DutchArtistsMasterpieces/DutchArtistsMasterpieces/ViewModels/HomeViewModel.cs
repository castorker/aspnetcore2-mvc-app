using DutchArtistsMasterpieces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
