using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public string Source { get; set; }
        public Artist Artist { get; set; }

        [Required]
        public int ArtistId { get; set; }
    }
}
