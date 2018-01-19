using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public class MockArtistRepository : IArtistRepository
    {
        private List<Artist> _artists;

        public MockArtistRepository()
        {
            if (_artists == null)
            {
                InitializeArtists();
            }
        }

        private void InitializeArtists()
        {
            var month = DateTime.Now.Month;

            _artists = new List<Artist>
            {
                new Artist {
                    Id = 1,
                    Name = "Rembrandt van Rijn",
                    City = "Leiden",
                    BirthYear = 1606,
                    Birth = new DateTime(1606, 7, 15),
                    DeathYear = 1669,
                    Death = new DateTime(1669, 10, 4),
                    ShortDescription = "Was a Dutch draughtsman, painter, and printmaker.",
                    LongDescription = "Rembrandt dominated the Dutch Golden Age which is considered as a very important period in the development of art. He is known as the master of light and shadow. His paintings are of exceptional realism always making use of his trademark of light and shadow effects. Rembrandt is most famous for his portraits and depictions of biblical scenes. In portraiture Rembrandt captured the various moods of his subjects brilliantly and as a self-portrait artist he is known for not showing any mercy to himself. Rembrandt is not only the most famous Dutch painter but he ranks among the greatest the world has ever seen.",
                    ImageUrl = "/images/Artists/Rembrandt-van-Rijn.jpg",
                    ImageThumbnailUrl = "/images/Artists/Rembrandt-van-Rijn_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1606, 7, 15).Month == month ? true : false
                },
                new Artist
                {
                    Id = 2,
                    Name = "Vincent van Gogh",
                    City = "Zundert",
                    BirthYear = 1853,
                    Birth = new DateTime(1853, 3, 30),
                    DeathYear = 1890,
                    Death = new DateTime(1890, 7, 29),
                    ShortDescription = "Was a Dutch Post-Impressionist painter who is among the most famous and influential figures in the history of Western art.",
                    LongDescription = "Vincent Van Gogh was a Post-Impressionist artist whose difficult life and posthumous fame are well known around the world. During his life Van Gogh’s work was known to only a handful of people. He rose to fame in the early 20th century, a decade after his death. Now considered one of the greatest painters of all time, Van Gogh’s work is notable for its rough beauty, emotional honesty, and bold color. His paintings have had a deep and profound influence on twentieth century art and together with Pablo Picasso’s they are among the world’s most expensive paintings ever sold.",
                    ImageUrl = "/images/Artists/Vincent-Van-Gogh.jpg",
                    ImageThumbnailUrl = "/images/Artists/Vincent-Van-Gogh_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1853, 3, 30).Month == month ? true : false
                },
                new Artist
                {
                    Id = 3,
                    Name = "Maurits Cornelis Escher",
                    City = "Leeuwarden",
                    BirthYear = 1898,
                    Birth = new DateTime(1898, 6, 17),
                    DeathYear = 1972,
                    Death = new DateTime(1972, 3, 27),
                    ShortDescription = "Was a Dutch graphic artist who made mathematically inspired woodcuts, lithographs, and mezzotints.",
                    LongDescription = "M.C. Escher is one of the world’s most famous graphic artists. Tessellation is dividing the plane into multiple tiles with no overlaps and no gaps and M. C. Escher is regarded as the Father of Modern Tessellations. He also made 8 Mezzotints which are considered to be masterpieces of the technique. Escher represents the perfect coming together of mathematics and art and is most famous for his impossible constructions: images that look convincing but defy logic. Escher’s art was way ahead of his time and some of his work anticipated deep features of modern Cosmology.",
                    ImageUrl = "/images/Artists/M.C.-Escher.jpg",
                    ImageThumbnailUrl = "/images/Artists/M.C.-Escher_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1898, 6, 17).Month == month ? true : false
                },
                new Artist
                {
                    Id = 4,
                    Name = "Piet Mondrian",
                    City = "Amersfoort",
                    BirthYear = 1872,
                    Birth = new DateTime(1872, 3, 7),
                    DeathYear = 1944,
                    Death = new DateTime(1944, 2, 1),
                    ShortDescription = "Was a Dutch painter and theoretician who is regarded as one of the greatest artists of the 20th century.",
                    LongDescription = "De Stijl (The Style) was a Dutch artistic movement which laid emphasis on abstraction and reduced the elements of form and color. Piet Mondrian was one of the pioneers of this art movement. His artwork is famous for the purity of its abstractions, radical simplification of elements and for reflecting the spirituality of nature. Piet Mondrian was crucial in the development of modern art and his iconic abstract works remain influential in designs and popular culture to this day.",
                    ImageUrl = "/images/Artists/Piet-Mondrian.jpg",
                    ImageThumbnailUrl = "/images/Artists/Piet-Mondrian_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1872, 3, 7).Month == month ? true : false
                },
                new Artist
                {
                    Id = 5,
                    Name = "Johannes Vermeer",
                    City = "Delft",
                    BirthYear = 1632,
                    Birth = new DateTime(1632, 10, 31),
                    DeathYear = 1675,
                    Death = new DateTime(1675, 12, 15),
                    ShortDescription = "Was a Dutch painter who specialized in domestic interior scenes of middle-class life.",
                    LongDescription = "Johannes Vermeer today ranks among the most admired Dutch artists but he was relatively obscure during his time. It was perhaps because he was less prolific and created only about forty five artworks during his life of which thirty six survive. But such is there quality that they are among the most revered images in the history of art. Although he also painted religious and mythological scenes, Vermeer is most famous for his paintings of scenes of daily life in interior settings. Vermeer is renowned for masterful use of light in his work and for creating realistic bright images that captivate the viewer.",
                    ImageUrl = "/images/Artists/Johannes-Vermeer.jpg",
                    ImageThumbnailUrl = "/images/Artists/Johannes-Vermeer_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1632, 10, 31).Month == month ? true : false
                },
                new Artist
                {
                    Id = 6,
                    Name = "Frans Hals",
                    City = "Antwerp",
                    BirthYear = 1582,
                    DeathYear = 1666,
                    Death = new DateTime(1666, 8, 26),
                    ShortDescription = "Was a Dutch Golden Age painter, normally of portraits, who lived and worked in Haarlem.",
                    LongDescription = "Frans Hals revolutionized the field of portraiture with his radically free approach. He used loose painterly brushwork and captured light like never before. He is also responsible for the evolution of group portraiture. Along with Rembrandt, Frans Hals was the most famous artist during the Dutch Golden Age. His popularity however waned after his death. Interest in his artwork was revived in the nineteenth century and it inspired the hugely successful art movement Impressionism. Many Impressionist artists including Claude Monet and Vincent Van Gogh studied the works of Hals deeply and build on his unique techniques.",
                    ImageUrl = "/images/Artists/Frans-Hals.jpg",
                    ImageThumbnailUrl = "/images/Artists/Frans-Hals_tn.jpg",
                    IsArtistOfTheMonth = false
                },
                new Artist
                {
                    Id = 7,
                    Name = "Willem de Kooning",
                    City = "Rotterdam",
                    BirthYear = 1904,
                    Birth = new DateTime(1904, 4, 24),
                    DeathYear = 1997,
                    Death = new DateTime(1997, 3, 19),
                    ShortDescription = "Was a Dutch abstract expressionist artist.",
                    LongDescription = "Willem de Kooning was a Dutch American artist who was born in Netherlands but immigrated to United States in 1926. He first supported himself by painting signs, departmental store displays etc. but later became one of the most important and prolific artists of the twentieth century. The hallmark of De Kooning’s style was his emphasis on complex figure ground ambiguity. Kooning’s artwork was increasingly identified with the Abstract Expressionism art movement which initiated in the 1940s and he became one of the most famous artists of the movement.",
                    ImageUrl = "/images/Artists/Willem-de-Kooning.jpg",
                    ImageThumbnailUrl = "/images/Artists/Willem-de-Kooning_tn.jpg",
                    IsArtistOfTheMonth = new DateTime(1904, 4, 24).Month == month ? true : false
                },
                new Artist
                {
                    Id = 8,
                    Name = "Jan Steen",
                    City = "Leiden",
                    BirthYear = 1626,
                    DeathYear = 1679,
                    Death = new DateTime(1679, 2, 3),
                    ShortDescription = "Was a Dutch genre painter of the 17th century (also known as the Dutch Golden Age).",
                    LongDescription = "Jan Steen was one of the most prolific painters of the Dutch Golden Age creating about 800 paintings. Though he also excelled in other genres, he is most famous for genre art which depicts scenes from everyday life. Steen’s genre paintings are known for depicting humorous, warm-hearted and animated scenes. Many of his works bear references to Dutch proverbs and literature; and many have a moral for the viewer. Steen’s sense of humor has made him hugely popular in Netherlands and “a Jan Steen household” has become a Dutch proverb for a messy scene.",
                    ImageUrl = "/images/Artists/Jan-Steen.jpg",
                    ImageThumbnailUrl = "/images/Artists/Jan-Steen_tn.jpg",
                    IsArtistOfTheMonth = false
                },
                new Artist
                {
                    Id = 9,
                    Name = "Jacob Isaacksz van Ruisdael",
                    City = "Haarlem",
                    BirthYear = 1628,
                    DeathYear = 1682,
                    Death = new DateTime(1682, 3, 10),
                    ShortDescription = "Was a Dutch painter, draughtsman, and etcher.",
                    LongDescription = "A pioneer of landscape painting, Jacob van Ruisdael produced some of the most breathtaking landscape paintings ever produced. He gave landscape art a new dimension by portraying nature as a metaphor of the dark aspects of human psychology. Simple woodland scenes were his favorite subjects and he is particularly famous for his spirited portrayal of trees and cloudscapes. Ruisdael was the most important landscape painter of seventeenth century Netherlands. His art greatly influenced landscape artists for centuries and paved the way for the popular Romantic style of the eighteenth century.",
                    ImageUrl = "/images/Artists/Jacob-Isaacksz-van-Ruisdael.jpg",
                    ImageThumbnailUrl = "/images/Artists/Jacob-Isaacksz-van-Ruisdael_tn.jpg",
                    IsArtistOfTheMonth = false
                },
                new Artist
                {
                    Id = 10,
                    Name = "Pieter Claesz",
                    City = "Berchem",
                    BirthYear = 1597,
                    DeathYear = 1661,
                    Death = new DateTime(1661, 1, 1),
                    ShortDescription = "Was a Dutch Golden Age painter of still lifes.",
                    LongDescription = "Active during the Dutch Golden Age, Pieter Claesz is considered among the masters of still life painting. Among the foremost still-life painters of his time, Claesz was the first artist to portray everyday objects in his paintings in such a way that they exuded a dazzling beauty. He often used the same objects: a glass of wine, a knife, a metal plate with fish or bread, and a bowl of berries in his still lifes and used light masterfully to create a rich effect.",
                    ImageUrl = "/images/Artists/Pieter-Claesz.jpg",
                    ImageThumbnailUrl = "/images/Artists/Pieter-Claesz_tn.jpg",
                    IsArtistOfTheMonth = false
                }
            };
        }

        public IEnumerable<Artist> GetAllArtists()
        {
            return _artists;
        }

        public Artist GetArtistById(int id)
        {
            return _artists.FirstOrDefault(a => a.Id == id);
        }
    }
}
