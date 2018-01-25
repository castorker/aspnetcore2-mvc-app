using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArtistsMasterpieces.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            var month = DateTime.Now.Month;

            if (!context.Artists.Any())
            {
                context.AddRange
                (
                    new Artist
                    {
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
                );

                context.SaveChanges();
            }

            if (!context.Artworks.Any())
            {
                context.AddRange
                (
                    // Rembrandt van Rijn
                    new Artwork
                    {
                        Title = "The Abduction of Europa",
                        Year = 1632,
                        ShortDescription = "The Abduction of Europa (1632) is one of his rare mythological subject paintings. The piece is oil on canvas and now located in the J. Paul Getty Museum.",
                        LongDescription = "The inspiration for the painting is Ovid’s Metamorphoses, part of which tells the tale of Zeus’s seduction and capture of Europa. The painting shows a coastal scene with Europa being carried away in rough waters by a bull while her friends remain on shore with expressions of horror. Rembrandt combined his knowledge of classical literature with the interests of the patron in order to create this allegorical work. The use of an ancient myth to impart a contemporary thought and his portrayal of the scene using the High Baroque style are two strong aspects of the work. The Abduction of Europa is Rembrandt’s reinterpretation of the story, placed in a more contemporary setting.",
                        ImageUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1632-The-Abduction-of-Europa.jpg",
                        ImageThumbnailUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1632-tn_The-Abduction-of-Europa.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 1
                    },
                    new Artwork
                    {
                        Title = "The Nightwatch",
                        Year = 1642,
                        ShortDescription = "Militia Company of District II under the Command of Captain Frans Banninck Cocq, also known as The Shooting Company of Frans Banning Cocq and Willem van Ruytenburch, but commonly referred to as The Night Watch (Dutch: De Nachtwacht), is a 1642 painting by Rembrandt van Rijn. It is in the collection of the Amsterdam Museum but is prominently displayed in the Rijksmuseum as the best known painting in its collection. The Night Watch is one of the most famous Dutch Golden Age paintings.",
                        LongDescription = "The painting is famous for three things: its colossal size (363 cm × 437 cm (11.91 ft × 14.34 ft)), the dramatic use of light and shadow (tenebrism) and the perception of motion in what would have traditionally been a static military group portrait. The painting was completed in 1642, at the peak of the Dutch Golden Age. It depicts the eponymous company moving out, led by Captain Frans Banning Cocq (dressed in black, with a red sash) and his lieutenant, Willem van Ruytenburch (dressed in yellow, with a white sash). With effective use of sunlight and shade, Rembrandt leads the eye to the three most important characters among the crowd: the two gentlemen in the centre (from whom the painting gets its original title), and the woman in the centre-left background carrying a chicken. Behind them, the company's colours are carried by the ensign, Jan Visscher Cornelissen. The figures are almost life-size. Rembrandt has displayed the traditional emblem of the arquebusiers in a natural way, with the woman in the background carrying the main symbols. She is a kind of mascot herself; the claws of a dead chicken on her belt represent the clauweniers (arquebusiers), the pistol behind the chicken represents clover and she is holding the militia's goblet. The man in front of her is wearing a helmet with an oak leaf, a traditional motif of the arquebusiers. The dead chicken is also meant to represent a defeated adversary. The colour yellow is often associated with victory.",
                        ImageUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1642-The-Nightwatch.jpg",
                        ImageThumbnailUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1642-tn_The-Nightwatch.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 1
                    },
                    new Artwork
                    {
                        Title = "Self Portrait with Beret and Turned Up Collar",
                        Year = 1659,
                        ShortDescription = "Self-Portrait with Beret and Turned-Up Collar is a 1659 oil on canvas painting by the Dutch artist Rembrandt, one of over 40 self-portraits by Rembrandt. It has been noted as a self-portrayal of subtle and somber qualities, a work in which may be seen 'the stresses and strains of a life compounded of creative triumphs and personal and financial reverses'. Part of the Andrew W. Mellon Collection, it has been in the National Gallery of Art since 1937.",
                        LongDescription = "In Self-Portrait with Beret and Turned-Up Collar Rembrandt is seated in a broadly painted fur cloak, his hands clasped in his lap. Light from the upper right fully illuminates the face, hollowing the form of the cheek, and allowing for the representation of blemishes on the right cheek and ear lobe. The picture is painted in a restrained range of browns and grays, enriched by a red shape that probably indicates the back of his chair, while another red area at the lower left corner of the canvas may be a tablecloth. The most luminous area, the artist's face, is framed by a large beret and the high collar that flatteringly hides his jowls. The skin of the face is modeled with thick, tactile pigment, painted with rich and varied colors suggesting both the artist's physical aging and the emotional effects of life experience. At first Rembrandt painted himself wearing a light colored cap before opting for the black beret; since the original headdress was of a type that the artist included only in self - portraits where he is seen at the easel, it is possible that he initially intended for this painting to refer directly to his trade.",
                        ImageUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1659-Self-Portrait-with-Beret-and-Turned-Up-Collar.jpg",
                        ImageThumbnailUrl = "/images/Artworks/01-Rembrandt-van-Rijn/1659-tn_Self-Portrait-with-Beret-and-Turned-Up-Collar.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 1
                    },
                    // Vincent van Gogh
                    new Artwork
                    {
                        Title = "Vase with Fifteen Sunflowers",
                        Year = 1888,
                        ShortDescription = "This is one of four paintings of sunflowers dating from August and September 1888. Van Gogh intended to decorate Gauguin's room with these paintings in the so-called Yellow House that he rented in Arles in the South of France. He and Gauguin worked there together between October and December 1888.",
                        LongDescription = "Van Gogh wrote to his brother Theo in August 1888, 'I am hard at it, painting with the enthusiasm of a Marseillais eating bouillabaisse, which won't surprise you when you know that what I'm at is the painting of some sunflowers. If I carry out this idea there will be a dozen panels. So the whole thing will be a symphony in blue and yellow. I am working at it every morning from sunrise on, for the flowers fade so quickly. I am now on the fourth picture of sunflowers. This fourth one is a bunch of 14 flowers ... it gives a singular effect.' The dying flowers are built up with thick brushstrokes (impasto). The impasto evokes the texture of the seed-heads. Van Gogh produced a replica of this painting in January 1889, and perhaps another one later in the year. The various versions and replicas remain much debated among Van Gogh scholars.",
                        ImageUrl = "/images/Artworks/02-Vincent-van-Gogh/1888-Vase-with-Fifteen-Sunflowers.jpg",
                        ImageThumbnailUrl = "/images/Artworks/02-Vincent-van-Gogh/1888-tn_Vase-with-Fifteen-Sunflowers.jpg",
                        Source = "www.nationalgallery.org.uk",
                        ArtistId = 2
                    },
                    new Artwork
                    {
                        Title = "Irises",
                        Year = 1889,
                        ShortDescription = "Irises is one of several paintings of irises by the Dutch artist Vincent van Gogh, and one of a series of paintings he executed at the Saint Paul-de-Mausole asylum in Saint-Rémy-de-Provence, France, in the last year before his death in 1890.",
                        LongDescription = "Van Gogh started painting Irises within a week of entering the asylum, in May 1889, working from nature in the hospital garden. There is a lack of the high tension which is seen in his later works. He called painting 'the lightning conductor for my illness' because he felt that he could keep himself from going insane by continuing to paint. The painting was probably influenced by Japanese ukiyo - e woodblock prints like many of his works and those by other artists of the time.The similarities occur with strong outlines, unusual angles, including close - up views, and also flattish local colour(not modelled according to the fall of light).The painting is full of softness and lightness.Irises is full of life without tragedy. He considered this painting a study which is probably why there are no known drawings for it, although Theo, Van Gogh's brother, thought better of it and quickly submitted it to the annual exhibition of the Société des Artistes Indépendants in September 1889, together with Starry Night Over the Rhone. He wrote to Vincent of the exhibition: 'It strikes the eye from afar. The Irises are a beautiful study full of air and life.' The painting is one of his most renowned works.",
                        ImageUrl = "/images/Artworks/02-Vincent-van-Gogh/1889-Irises.jpg",
                        ImageThumbnailUrl = "/images/Artworks/02-Vincent-van-Gogh/1889-tn_Irises.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 2
                    },
                    new Artwork
                    {
                        Title = "The Starry Night",
                        Year = 1889,
                        ShortDescription = "The Starry Night is an oil on canvas by the Dutch post-impressionist painter Vincent van Gogh. Painted in June 1889, it depicts the view from the east-facing window of his asylum room at Saint-Rémy-de-Provence, just before sunrise, with the addition of an idealized village. It has been in the permanent collection of the Museum of Modern Art in New York City since 1941, acquired through the Lillie P. Bliss Bequest. It is regarded as among Van Gogh's finest works and is one of the most recognized paintings in the history of Western culture.",
                        LongDescription = "'This morning I saw the countryside from my window a long time before sunrise, with nothing but the morning star, which looked very big,' wrote van Gogh to his brother Theo, describing his inspiration for one of his best-known paintings, The Starry Night (1889). The window to which he refers was in the Saint-Paul asylum in Saint-Rémy, in southern France, where he sought respite from his emotional suffering while continuing to make art. This mid-scale, oil-on-canvas painting is dominated by a moon- and star-filled night sky. It takes up three-quarters of the picture plane and appears turbulent, even agitated, with intensely swirling patterns that seem to roll across its surface like waves. It is pocked with bright orbs—including the crescent moon to the far right, and Venus, the morning star, to the left of center—surrounded by concentric circles of radiant white and yellow light. Beneath this expressive sky sits a hushed village of humble houses surrounding a church, whose steeple rises sharply above the undulating blue-black mountains in the background. A cypress tree sits at the foreground of this night scene. Flame-like, it reaches almost to the top edge of the canvas, serving as a visual link between land and sky. Considered symbolically, the cypress could be seen as a bridge between life, as represented by the earth, and death, as represented by the sky, commonly associated with heaven. Cypresses were also regarded as trees of the graveyard and mourning. “But the sight of the stars always makes me dream,” van Gogh once wrote. 'Why, I say to myself, should the spots of light in the firmament be less accessible to us than the black spots on the map of France? Just as we take the train to go to Tarascon or Rouen, we take death to go to a star.'",
                        ImageUrl = "/images/Artworks/02-Vincent-van-Gogh/1889-The-Starry-Night.jpg",
                        ImageThumbnailUrl = "/images/Artworks/02-Vincent-van-Gogh/1889-tn_The-Starry-Night.jpg",
                        Source = "www.wikipedia.org, www.moma.org",
                        ArtistId = 2
                    },
                    // M. C. Escher
                    new Artwork
                    {
                        Title = "Metamorphosis I",
                        Year = 1937,
                        ShortDescription = "Metamorphosis I is a woodcut print by the Dutch artist M. C. Escher which was first printed in May, 1937. This piece measures 19.5 by 90.8 centimetres (7.7 in × 35.7 in) and is printed on two sheets.",
                        LongDescription = "The concept of this work is to morph one image into a tessellated pattern, then gradually to alter the outlines of that pattern to become an altogether different image. From left to right, the image begins with a depiction of the coastal Italian town of Atrani (see Atrani, Coast of Amalfi). The outlines of the architecture then morph to a pattern of three-dimensional blocks. These blocks then slowly become a tessellated pattern of cartoon-like figures in oriental attire.",
                        ImageUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1937-Metamorphosis-I.jpg",
                        ImageThumbnailUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1937-tn_Metamorphosis-I.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 3
                    },
                    new Artwork
                    {
                        Title = "Relativity",
                        Year = 1953,
                        ShortDescription = "Relativity is a lithograph print by the Dutch artist M. C. Escher, first printed in December 1953. It depicts a world in which the normal laws of gravity do not apply.",
                        LongDescription = "The architectural structure seems to be the centre of an idyllic community, with most of its inhabitants casually going about their ordinary business, such as dining. There are windows and doorways leading to park-like outdoor settings. All of the figures are dressed in identical attire and have featureless bulb-shaped heads. Identical characters such as these can be found in many other Escher works. In the world of Relativity, there are three sources of gravity, each being orthogonal to the two others. Each inhabitant lives in one of the gravity wells, where normal physical laws apply. There are sixteen characters, spread between each gravity source, six in one and five each in the other two. The apparent confusion of the lithograph print comes from the fact that the three gravity sources are depicted in the same space. The structure has seven stairways, and each stairway can be used by people who belong to two different gravity sources. This creates interesting phenomena, such as in the top stairway, where two inhabitants use the same stairway in the same direction and on the same side, but each using a different face of each step; thus, one descends the stairway as the other climbs it, even while moving in the same direction nearly side - by - side.In the other stairways, inhabitants are depicted as climbing the stairways upside - down, but based on their own gravity source, they are climbing normally. Each of the three parks belongs to one of the gravity wells. All but one of the doors seem to lead to basements below the parks. Though physically possible, such basements are certainly unusual and add to the surreal effect of the picture. This is one of Escher’s most popular works and has been used in a variety of ways.",
                        ImageUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1953-Relativity.jpg",
                        ImageThumbnailUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1953-tn_Relativity.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 3
                    },
                    new Artwork
                    {
                        Title = "Waterfall",
                        Year = 1961,
                        ShortDescription = "Waterfall (Waterval) is a lithograph by the Dutch artist M. C. Escher, first printed in October 1961. It shows a perpetual motion machine where water from the base of a waterfall appears to run downhill along the water path before reaching the top of the waterfall.",
                        LongDescription = "The image depicts a watermill with an elevated aqueduct and waterwheel as the main feature. The aqueduct begins at the waterwheel and flows behind it. The walls of the aqueduct step downward, suggesting that it slopes downhill. The aqueduct turns sharply three times, first to the left, then to the right, and finally to the left again. The viewer looks down at the scene diagonally, which means that from the viewer's perspective the aqueduct appears to be slanted upward. The viewer is also looking across the scene diagonally from the lower right, which means that from the viewer's perspective the two left-hand turns are directly in line with each other, while the waterwheel, the forward turn and the end of the aqueduct are all in line. The second left-hand turn is supported by pillars from the first, while the other two corners are supported by a tower of pillars that begins at the waterwheel. The water falls off the edge of the aqueduct and over the waterwheel in an impossible infinite cycle; in his notes on the picture, Escher points out that some water must be periodically added to this perpetual motion machine to compensate for evaporation. The use of the Penrose stairs is paralleled by Escher's Ascending and Descending (1960), where instead of the flow of water, two lines of monks endlessly march uphill or downhill around the four flights of stairs. The two support towers continue above the aqueduct and are topped by two compound polyhedra, revealing Escher's interest in mathematics as an artist. The one on the left is a compound of three cubes. The one on the right is a stellation of a rhombic dodecahedron (or a compound of three non-regular octahedra) and is known as Escher's solid. Below the mill is a garden of bizarre, giant plants.This is actually a magnified view of a cluster of moss and lichen that Escher drew in ink as a study in 1942. The background seems to be a climbing expanse of terraced farmland.",
                        ImageUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1961-Waterfall.jpg",
                        ImageThumbnailUrl = "/images/Artworks/03-Maurits-Cornelis-Escher/1961-tn_Waterfall.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 3
                    },
                    // Piet Mondrian
                    new Artwork
                    {
                        Title = "The Gray Tree",
                        Year = 1911,
                        ShortDescription = "The Gray Tree is one of the first paintings in which Mondrian applied to a natural subject the principles of cubist composition that he was in the process of assimilating and working out in his own way.",
                        LongDescription = "At the same time, it is a continuation of the series on the Tree theme, which began with the studies for the Red Tree of 1908. Although four years elapsed between the Red Tree and the The Gray Tree, it would be a mistake not to see them as two links in a single chain of development. Actually, there are a few additional links in the chain connecting the luminist version of 1908, with its bold red and blue, and the cubist one of 1912, in which color has receded almost completely, and form and rhythm dominate. These additional links date from Mondrian's Zeeland period and comprise a number of little works that reached a highpoint in the Blue Tree, probably created in 1910, the same year in which other motifs - dunes, mills, church facades - similarly acquired a character of their own. In 1912, or perhaps as early as the winter of 1911/12, Mondrian came back to the theme of trees in a large drawing in black chalk, in which his unmistakable aim was to bring the three-dimensional volume of the bare tree, with its twisted branches, onto the surface of the picture, into the second dimension. His project was to transform the thing that he saw in front of him into a rhythmic sign on his sheet of paper. This drawing became the starting point for at least three paintings: the The Gray Tree reproduced here; a closely related canvas, somewhat more oblong in shape and thus a little closer to the drawing; and the Flowering Apple Tree. It seems evident that the process which took place between the large 1911 / 12 drawing and the Flowering Apple Tree paralleled the change in conception between the first and second versions of the Still Life with Gingerpot II. The Gray Tree is a little further along in that course of development than the first version of the still life; the factual qualities of the tree have already been converted into a rhythmic play of lines, leaving the thing-value of each part far behind.Nonetheless, a certain painterly quality is still an important factor in the appearance of this tree painting. It is an effect attained by vigorous brush strokes with smooth paint, and it has almost totally disappeared in the second version of the still life.The Gray Tree, in turn, seems a major and successful effort to translate the drawing of a tree, which had itself been executed with a primarily compositional purpose, into a painting embodying the principles of cubism, which Mondrian had mastered for himself in the interim.",
                        ImageUrl = "/images/Artworks/04-Piet-Mondrian/1911-The-Gray-Tree.jpg",
                        ImageThumbnailUrl = "/images/Artworks/04-Piet-Mondrian/1911-tn_The-Gray-Tree.jpg",
                        Source = "www.piet-mondrian.org",
                        ArtistId = 4
                    },
                    new Artwork
                    {
                        Title = "Composition with Red Yellow and Blue",
                        Year = 1935,
                        ShortDescription = "Composition with Red Blue and Yellow is a 1930 painting by Piet Mondrian. A well-known work of abstraction, Mondrian contributes to the abstract visual language in a large way despite using a relatively small canvas. Thick, black brushwork defines the borders of the different geometric figures. Comparably, the black brushwork on the canvas is very minimal but it is masterfully applied to become one of the defining features of the work.",
                        LongDescription = "Composition with Red Blue and Yellow is a product of the Dutch De Stijl movement, which translates to 'The Style.' The De Stijl foundation can be viewed as an overlapping of individual theoretical and artistic pursuits. Mondrian is widely seen as the prominent artist for the movement and is thus held responsible for bringing popularity to the rather obscure style.\nAvoiding references to the real world, and using only the primary colors (red, blue, and yellow), the primary values (black, white, and grey), and the primary directions (horizontal and vertical), Piet Mondrian created abstract paintings through which he sought to reveal universal harmony and order. This idealistic pursuit was shared by his fellow Dutch painter Theo van Doesburg. Together they cofounded the pioneering and highly influential movement De Stijl (The Style) in 1917. Through De Stijl, Mondrian and van Doesburg galvanized an artistic response to what they believed would be the beginning of a new era after World War I, where art and life would be integrated. His Composition in Red, Blue, and Yellow (1930), with its gridded black lines locking squares of color into a geometric composition, exemplifies the visual vocabulary he created to express his ideas.",
                        ImageUrl = "/images/Artworks/04-Piet-Mondrian/1935-Composition-with-Red-Yellow-and-Blue.jpg",
                        ImageThumbnailUrl = "/images/Artworks/04-Piet-Mondrian/1935-tn_Composition-with-Red-Yellow-and-Blue.jpg",
                        Source = "www.wikipedia.org, www.artsy.net",
                        ArtistId = 4
                    },
                    new Artwork
                    {
                        Title = "Broadway Boogie Woogie",
                        Year = 1943,
                        ShortDescription = "Broadway Boogie Woogie is a painting by Piet Mondrian completed in 1943, shortly after he moved to New York in 1940.",
                        LongDescription = "Compared to his earlier work, the canvas is divided into a much larger number of squares. Although he spent most of his career creating abstract work, this painting is inspired by clear real-world examples: the city grid of Manhattan, and the Broadway boogie woogie, a type of music Mondrian loved. The painting was bought by the Brazilian sculptor Maria Martins for the price of $800 at the Valentine Gallery in New York City, after Martins and Mondrian both exhibited there in 1943. Martins later donated the painting to the Museum of Modern Art in New York City.",
                        ImageUrl = "/images/Artworks/04-Piet-Mondrian/1943-Broadway-Boogie-Woogie.jpg",
                        ImageThumbnailUrl = "/images/Artworks/04-Piet-Mondrian/1943-tn_Broadway-Boogie-Woogie.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 4
                    },
                    // Johannes Vermeer
                    new Artwork
                    {
                        Title = "The Milkmaid",
                        Year = 1660,
                        ShortDescription = "The Milkmaid (Dutch: De Melkmeid or Het Melkmeisje), sometimes called The Kitchen Maid, is an oil-on-canvas painting of a 'milkmaid', in fact, a domestic kitchen maid, by the Dutch artist Johannes Vermeer. It is now in the Rijksmuseum in Amsterdam, the Netherlands, which regards it as 'unquestionably one of the museum's finest attractions'.",
                        LongDescription = "Despite its traditional title, the picture clearly shows a kitchen or housemaid, a low-ranking indoor servant, rather than a milkmaid who actually milks the cow, in a plain room carefully pouring milk into a squat earthenware container (now commonly known as a 'Dutch oven') on a table. Also on the table are various types of bread. She is a young, sturdily built woman wearing a crisp linen cap, a blue apron and work sleeves pushed up from thick forearms. A foot warmer is on the floor behind her, near Delft wall tiles depicting Cupid (to the viewer's left) and a figure with a pole (to the right). Intense light streams from the window on the left side of the canvas.",
                        ImageUrl = "/images/Artworks/05-Johannes-Vermeer/1660-The-Milkmaid.jpg",
                        ImageThumbnailUrl = "/images/Artworks/05-Johannes-Vermeer/1660-tn_The-Milkmaid.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 5
                    },
                    new Artwork
                    {
                        Title = "View of Delft",
                        Year = 1661,
                        ShortDescription = "View of Delft (Dutch: Gezicht op Delft) is an oil painting by Johannes Vermeer, painted ca. 1660–1661.",
                        LongDescription = "The painting of the Dutch artist's hometown is among his most popular, painted at a time when cityscapes were uncommon. It is one of three known paintings of Delft by Vermeer, along with The Little Street and the lost painting House Standing in Delft. The use of pointillism in the work suggests that it postdates The Little Street.",
                        ImageUrl = "/images/Artworks/05-Johannes-Vermeer/1661-View-of-Delft.jpg",
                        ImageThumbnailUrl = "/images/Artworks/05-Johannes-Vermeer/1661-tn_View-of-Delft.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 5
                    },
                    new Artwork
                    {
                        Title = "Girl with a Pearl Earring",
                        Year = 1665,
                        ShortDescription = "Girl with a Pearl Earring (Dutch: Meisje met de parel) is an oil painting by Dutch Golden Age painter Johannes Vermeer. It is a tronie of a girl wearing a headscarf and a pearl earring. The painting has been in the collection of the Mauritshuis in The Hague since 1902.",
                        LongDescription = "The painting is a tronie, the Dutch 17th-century description of a 'head' that was not meant to be a portrait. It depicts a European girl wearing an exotic dress, an oriental turban, and an improbably large pearl earring. In 2014, Dutch astrophysicist Vincent Icke raised doubts about the material of the earring and argued that it looks more like polished tin than pearl on the grounds of the specular reflection, the pear shape and the large size of the earring. The work is oil on canvas and is 44.5 cm (17.5 in) high and 39 cm (15 in) wide. It is signed 'IVMeer' but not dated. It is estimated to have been painted around 1665. After the most recent restoration of the painting in 1994, the subtle colour scheme and the intimacy of the girl's gaze toward the viewer have been greatly enhanced. During the restoration, it was discovered that the dark background, today somewhat mottled, was initially intended by the painter to be a deep enamel-like green. This effect was produced by applying a thin transparent layer of paint, called a glaze, over the present-day black background. However, the two organic pigments of the green glaze, indigo and weld, have faded.",
                        ImageUrl = "/images/Artworks/05-Johannes-Vermeer/1665-Girl-with-a-Pearl-Earring.jpg",
                        ImageThumbnailUrl = "/images/Artworks/05-Johannes-Vermeer/1665-tn_Girl-with-a-Pearl-Earring.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 5
                    },
                    // Frans Hals
                    new Artwork
                    {
                        Title = "Laughing Cavalier",
                        Year = 1624,
                        ShortDescription = "The Laughing Cavalier (1624) is a portrait by the Dutch Golden Age painter Frans Hals in the Wallace Collection in London, which has been described as 'one of the most brilliant of all Baroque portraits'. The title is an invention of the Victorian public and press, dating from its exhibition in the opening display at the Bethnal Green Museum in 1872–75, just after its arrival in England, after which it was regularly reproduced as a print, and became among of the best known old master paintings in Britain. The unknown subject is in fact not laughing, but can be said to have an enigmatic smile, much amplified by his upturned moustache.",
                        LongDescription = "The portrait measures 83 × 67.3 cm (32.7 × 26.5 in) and is inscribed at top right 'Æ'TA SVÆ 26/A°1624', which expands to 'aetatis suae 26, anno 1624' in Latin and means that the portrait was painted when the sitter was 26 and in the year 1624. The identity of the man is unknown, and though the recorded 19th century titles in Dutch, English and French mostly suggest a military man, or at least an officer in one of the part-time militia companies that were often the subjects of group portraits, including some by Hals and later Rembrandt's Night Watch (1642), in fact he was as likely to be a wealthy civilian. Art historian Pieter Biesboer has theorised the painting possibly depicts Dutch cloth merchant Tieleman Roosterman, the subject of another of Hals' portraits. The composition is lively and spontaneous, and despite the apparent labour involved in the gorgeous, and very expensive, silk costume, close inspection reveals long, quick brush strokes. The turning pose and low viewpoint are found in other portraits by Hals and here allow emphasis on the embroidered sleeve and lace cuff. There are many emblems in the embroidery: signifying 'the pleasures and pains of love' are 'bees, arrows, flaming cornucopiae, lovers' knots and tongues of fire', while an obelisk or pyramid signifies strength and Mercury's cap and caduceus fortune. In general, commissioned portraits such as this rarely showed adults smiling until the late 18th century, though smiling is often seen in tronies and figures in genre painting. But Hals is an exception to the general rule and often showed sitters with broader smiles than here, and in informal poses that bring an impression of movement and spontaneity to his work. The effect of the eyes appearing to follow the viewer from every angle is a result of the subject being depicted as looking directly forward, toward the artist's point of view, combined with being a static two dimensional representation of this from whichever angle the painting itself is viewed.",
                        ImageUrl = "/images/Artworks/06-Frans-Hals/1624-Laughing-Cavalier.jpg",
                        ImageThumbnailUrl = "/images/Artworks/06-Frans-Hals/1624-tn_Laughing-Cavalier.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 6
                    },
                    new Artwork
                    {
                        Title = "The Banquet of the Officers of the St George Militia Company in 1627",
                        Year = 1627,
                        ShortDescription = "The Banquet of the Officers of the St George Militia Company in 1627 refers to a schutterstuk painted by Frans Hals for the St. George (or St. Joris) civic guard of Haarlem, and today is considered one of the main attractions of the Frans Hals Museum there.",
                        LongDescription = "In this group, each man wears a sash belonging to the color of the 'rot', in this painting all three are represented with their flag-bearers wearing the colours Orange, white or blue. These officers were selected by the council of Haarlem to serve for three years, and this group had just finished their tenure and celebrated their end of service with a portrait. The man with the orange sash holding a glass of wine sitting at the table on the left and looking at Captain Michiel de Wael with an empty glass, is Colonel Aart Jansz Druyvesteyn, who heads the table. The men featured are from left to right Lieutenant Cornelis Boudewijns (standing above Colonel Aernout Druyvesteyn), Captain Nicolaes Verbeek, Flag bearer Boudewijn van Offenberg, Lieutenant Jacob Pietersz Olycan, Captain Michiel de Wael, and above him, standing, is Flag bearer Dirck Dicx looking down at Jacob Olycan. Just behind him in the background is the servant Arent Jacobsz Koets, and below him, seated, is Lieutenant Frederik Coning. Behind the servant in the far right, is the flag bearer Jacob Cornelisz Schout who towers above the dwarf in the lower right, Captain Nicolaes le Febure.",
                        ImageUrl = "/images/Artworks/06-Frans-Hals/1627-The-Banquet-of-the-Officers-of-the-St-George-Militia-Company-in-1627.jpg",
                        ImageThumbnailUrl = "/images/Artworks/06-Frans-Hals/1627-tn_The-Banquet-of-the-Officers-of-the-St-George-Militia-Company-in-1627.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 6
                    },
                    new Artwork
                    {
                        Title = "Willem van Heythuysen posing with a sword",
                        Year = 1630,
                        ShortDescription = "Willem van Heythuysen posing with a sword is a painting by the Dutch Golden Age painter Frans Hals, painted in 1625 and now in the Alte Pinakothek, Munich. It shows the Haarlem cloth merchant Willem van Heythuysen in a theatrical pose with a rapier.",
                        LongDescription = "The painting shows a proud man standing in front of a neoclassical architectural element with drapery, leaning on a sword. In the distance a garden with a couple can be seen, and in the foreground some roses lie on the ground. It was first documented by Adriaan Loosjes, who mentioned it in his tribute to Hals in 1789 as being in the collection Gerrit Willem van Oosten de Bruyn. Much later Ernst Wilhelm Moes included it in his Iconographia Batavia, and Hofstede de Groot documented it again with the following description: 'WILLEM VAN HEYTHUYSEN. B. 123; M. 44.Full - length; life size. He stands with the left foot forward and the right drawn back. His figure is turned three - quarters left; his head almost faces the spectator, at whom he is looking.His left hand is pressed to his side; his right hand clasps the hilt of a sword with its point on the ground.He has a moustache and pointed beard.He wears a broad-brimmed hat, a white collar like a ruff trimmed with lace, and a very richly trimmed costume of dark blue with broad lace-trimmed cuffs.Behind him a lilac-brown drapery hangs on a fantastic piece of architecture; to the left is a view of a French garden; on the ground lie roses.Painted about 1635.'",
                        ImageUrl = "/images/Artworks/06-Frans-Hals/1630-Willem-van-Heythuysen-posing-with-a-sword.jpg",
                        ImageThumbnailUrl = "/images/Artworks/06-Frans-Hals/1630-tn_Willem-van-Heythuysen-posing-with-a-sword.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 6
                    },
                    // Willem de Kooning
                    new Artwork
                    {
                        Title = "Pink Angels",
                        Year = 1945,
                        ShortDescription = "This iconic work and its related series are emblematic of de Kooning's first radical steps in digesting the influence of Pablo Picasso, Surrealism and Arshile Gorky.",
                        LongDescription = "Pink Angels marked an important stage in de Kooning's evolution from figuration towards abstraction in the 1940s. The fleshy pink biomorphs of his earlier work - shapes that evoke eyes and other anatomical forms - are violently torn apart in a painting that was reportedly inspired by the carnage of World War II, and the figurative elements are barely distinguishable from the mustard yellow background. This thorough blurring of figure and ground was an important step in de Kooning's development towards the black and white paintings of the later part of the decade.",
                        ImageUrl = "/images/Artworks/07-Willem-de-Kooning/1945-Pink-Angels.jpg",
                        ImageThumbnailUrl = "/images/Artworks/07-Willem-de-Kooning/1945-tn_Pink-Angels.jpg",
                        Source = "www.theartstory.org",
                        ArtistId = 7
                    },
                    new Artwork
                    {
                        Title = "Excavation",
                        Year = 1950,
                        ShortDescription = "Excavation, Willem de Kooning’s largest painting up to 1950, exemplifies the artist’s innovative style of expressive brushwork and distinctive organization of space into loose, sliding planes with open contours.",
                        LongDescription = "According to de Kooning, his point of departure was an image of women working in a rice field from Bitter Rice, a 1949 Italian Neorealist film. The mobile structure of hooked, calligraphic lines defines anatomical parts—bird and fish shapes, human noses, eyes, teeth, necks, and jaws—revealing the particular tension between abstraction and figuration that is inherent in de Kooning’s work. Aptly titled, the composition reflects his technically masterful painting process: an intensive building up of the surface and scraping down of its paint layers, often for months, until the desired effect was achieved.",
                        ImageUrl = "/images/Artworks/07-Willem-de-Kooning/1950-Excavation.jpg",
                        ImageThumbnailUrl = "/images/Artworks/07-Willem-de-Kooning/1950-tn_Excavation.jpg",
                        Source = "www.artic.edu",
                        ArtistId = 7
                    },
                    new Artwork
                    {
                        Title = "Woman I",
                        Year = 1952,
                        ShortDescription = "De Kooning’s well-known Woman series, begun in 1950 and culminating in Woman VI, owes much to Picasso, not least in the aggressive, penetrative breaking apart of the figure, and the spaces around it. Picasso’s late works show signs that he, in turn, saw images of works by Pollock and de Kooning.",
                        LongDescription = "De Kooning took an unusually long time to create Woman I, making numerous preliminary studies and repainting the work repeatedly. The hulking, wild–eyed subject draws upon an amalgam of female archetypes, from Paleolithic fertility goddesses to contemporary pin–up girls. Her threatening stare and ferocious grin are heightened by de Kooning's aggressive brushwork and frantic paint application. Combining voluptuousness and menace, Woman I reflects the age–old cultural ambivalence between reverence for and fear of the power of the feminine.",
                        ImageUrl = "/images/Artworks/07-Willem-de-Kooning/1952-Woman-I.jpg",
                        ImageThumbnailUrl = "/images/Artworks/07-Willem-de-Kooning/1952-tn_Woman-I.jpg",
                        Source = "www.wikipedia.org, www.moma.org",
                        ArtistId = 7
                    },
                    // Jan Steen
                    new Artwork
                    {
                        Title = "Double portrait of Adolf Croeser and his daughter Catharina Croeser",
                        Year = 1655,
                        ShortDescription = "A Mayor of Delft and his Daughter (1655) is the common name of an oil on canvas painting by the Dutch painter Jan Steen. It is an example of Dutch Golden Age painting and is part of the collection of the Rijksmuseum. Since 2006 it has been determined that a more historically correct title is Double portrait of Adolf Croeser (1612-1668) and his daughter Catharina Croeser (1642-....).",
                        LongDescription = "This painting was documented by Hofstede de Groot in 1910, who wrote; '878. SO-CALLED PORTRAIT OF THE BURGOMASTER OF DELFT AND HIS DAUGHTER. The man sits in the centre, upon the steps in front of his house; he holds a sheet of paper. His daughter descends two steps to the left towards the spectator. The man is dressed in black; the girl has a blue skirt and a greyish - purple gown. A beggar-woman in red, with a boy, addresses the man from the right. In the distance, to the right, is the tower of the Oude Kerk, at Delft; to the left of the man's head is seen a small tower. A stone bridge, bearing the arms of the town, leads over the Oude Delft. To the left, in the window of the house, is a bouquet of flowers in a glass. The house projects slightly in front of the other houses in the street. The foliage of trees covers part of the picture.",
                        ImageUrl = "/images/Artworks/08-Jan-Steen/1655-Double-portrait-of-Adolf-Croeser-and-his-daughter-Catharina-Croeser.jpg",
                        ImageThumbnailUrl = "/images/Artworks/08-Jan-Steen/1655-tn_Double-portrait-of-Adolf-Croeser-and-his-daughter-Catharina-Croeser.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 8
                    },
                    new Artwork
                    {
                        Title = "The Dancing Couple",
                        Year = 1663,
                        ShortDescription = "The Dancing Couple is a 1663 oil painting by Jan Steen.",
                        LongDescription = "It depicts a chaotic party with a dancing couple in the center. The work is currently in the Widener Collection of the National Gallery of Art in Washington, D.C.. In the painting Jan Steen creates a very hectic environment. The setting of the painting is at a kermis, which is a local village fair that holds many symbolic references in Dutch art and was very popular in the Bruegel tradition.",
                        ImageUrl = "/images/Artworks/08-Jan-Steen/1663-The-Dancing-Couple.jpg",
                        ImageThumbnailUrl = "/images/Artworks/08-Jan-Steen/1663-tn_The-Dancing-Couple.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 8
                    },
                    new Artwork
                    {
                        Title = "The Feast of Saint Nicholas",
                        Year = 1665,
                        ShortDescription = "The Feast of Saint Nicholas (Dutch: Het Sint-Nicolaasfeest, c. 1665–1668), is a painting by Dutch master Jan Steen, which can now be found in the Rijksmuseum in Amsterdam. It measures 82 x 70.5 cm. The picture, painted in the chaotic Jan Steen 'style,' depicts a family at home on December 5, the night celebrated in the Netherlands as the Feast of Saint Nicholas, or Sinterklaas.",
                        LongDescription = "The focal point of the painting is the youngest daughter of the family, a golden-child, painted, in fact, in a golden smock and showing golden locks. She has behaved all year, and Saint Nicholas has rewarded her by stuffing her shoe with a doll and other treats, which she carries in her bucket. She is in stark contrast to her elder brother, standing to her right, who is sobbing, while another brother looks on, laughing. Apparently, the elder brother has been naughty, and his shoe, held up by an elder sister behind him, was left empty. Still there is hope for the sobbing boy. Hidden in the background, almost obscured by the draperies, his grandmother seems to beckon to him—perhaps she is hiding a gift for him too, behind the heavy curtains. While the mother attempts to coax the golden girl to show her the gifts she received, the father, seated in the center of the painting, seems to smile as he remembers his own childhood on this festive night. Further to the right a child can be seen holding a baby and pointing up the chimney, while a younger child looks on in amazement, as he has probably just been told that this was Sinterklaas' method of gaining entry to the house.",
                        ImageUrl = "/images/Artworks/08-Jan-Steen/1665-The-Feast-of-Saint-Nicholas.jpg",
                        ImageThumbnailUrl = "/images/Artworks/08-Jan-Steen/1665-tn_The-Feast-of-Saint-Nicholas.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 8
                    },
                    // Jacob Isaacksz van Ruisdael
                    new Artwork
                    {
                        Title = "View of Bentheim Castle",
                        Year = 1653,
                        ShortDescription = "View of Bentheim Castle (c. 1650s) is an oil on canvas painting of Burg Bentheim by the Dutch landscape painter Jacob van Ruisdael. It is an example of Dutch Golden Age painting and is now in the collection of the Rijksmuseum.",
                        LongDescription = "This painting was documented by Hofstede de Groot in 1911, who wrote; '21. THE CASTLE OF BENTHEIM. Sm. 16. The castle stands in the left middle distance on the rocky summit of a hill. To the right is a valley through which runs a road. In front are masses of rock between which flows a stream forming a little waterfall. On the left bank a shattered tree-trunk, beside the stump, lies diagonally across the stream. Farther back the stream widens ; on the left bank a shepherd drives his sheep forward. A fine picture, full of light. This scene is very similar to other paintings Ruisdael made in this period of Burg Bentheim and these often showed the castle on a high hill, though in reality it is only slightly elevated above the surrounding plain.",
                        ImageUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1653-Bentheim-Castle.jpg",
                        ImageThumbnailUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1653-tn_Bentheim-Castle.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 9
                    },
                    new Artwork
                    {
                        Title = "The Jewish Cemetery",
                        Year = 1655,
                        ShortDescription = "The Jewish Cemetery (c. 1650s) is an oil on canvas painting by the Dutch landscape painter Jacob van Ruisdael. It is an example of Dutch Golden Age painting and is now in the collection of the Detroit Institute of Arts.",
                        LongDescription = "This painting was documented by John Smith in 1835, who wrote: '60. The Cemetery. This grand and affecting picture exhibits the ruins of a church and convent upon the summit of a hill, occupying the whole extent of the view in the second distance, the declivity of which presents a cemetery, interspersed with large stones. On the foreground are a broken tree lying across a rapid stream, a tomb of black marble, with an inscription on it; a row of three sarcophagi extending along the front; and on the left stands a cluster of large umbrageous trees, the verdant hues of whose foliage is contrasted by the leafless trunk of a beech. Three persons in black are seen near a small tomb on the side of the hill, musing amidst the tombs. The grandeur and solemnity of the scene is strikingly enhanced by rolling stormy clouds, in which may be perceived the evanescent colours of a rainbow.",
                        ImageUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1655-The-Jewish-Cemetery.jpg",
                        ImageThumbnailUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1655-tn_The-Jewish-Cemetery.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 9
                    },
                    new Artwork
                    {
                        Title = "View of Haarlem With Bleaching Fields",
                        Year = 1670,
                        ShortDescription = "View of Haarlem with Bleaching Fields (c. 1670–1675) is an oil on canvas painting by the Dutch painter Jacob van Ruisdael. It is an example of Dutch Golden Age painting and is now in the collection of the Kunsthaus Zürich.",
                        LongDescription = "This painting was documented by Hofstede de Groot in 1911, who wrote; '92. The Haarlem Bleaching-Grounds. In the left foreground is a marshy pool surrounded with trees. A road leads from it up a hill towards the right background. In the middle distance is part of the bleaching-grounds ; large pieces of linen are spread out near cottages, and many persons are at work.In the distance is the town of Haarlem, dominated by the church of St.Bavo.The sky is filled with great masses of cloud which overshadow almost the whole landscape; stray sunbeams illumine part of the town and the bleaching-grounds.",
                        ImageUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1670-View-of-Haarlem-With-Bleaching-Fields.jpg",
                        ImageThumbnailUrl = "/images/Artworks/09-Jacob-Isaacksz-van-Ruisdael/1670-tn_View-of-Haarlem-With-Bleaching-Fields.jpg",
                        Source = "www.wikipedia.org",
                        ArtistId = 9
                    },
                    // Pieter Claesz
                    new Artwork
                    {
                        Title = "Still Life with Turkey Pie",
                        Year = 1627,
                        ShortDescription = "Still Life with Turkey Pie is a painting of a turkey pie and oysters created by the Dutch still-life master Pieter Claesz in 1627. The original is in the Rijksmuseum in Amsterdam.",
                        LongDescription = "One of the most important Dutch still-life painters of the 17th century, Pieter Claesz pioneered tabletop still lifes, depicting carefully composed meals that included breads, fruits, and wines. Claesz’s simple compositions are noted for bringing a remarkable presence to familiar items, capturing their rich textures, three-dimensional forms, and the play of light on surfaces. Claesz often included memento mori in his paintings, as in Vanitas (1656), in which a skull and bone are represented alongside an overturned chalice, burning incense, and script music, inviting viewers to reflect upon mortality and the passing of time.",
                        ImageUrl = "/images/Artworks/10-Pieter-Claesz/1627-Still-Life-with-Turkey-Pie.jpg",
                        ImageThumbnailUrl = "/images/Artworks/10-Pieter-Claesz/1627-tn_Still-Life-with-Turkey-Pie.jpg",
                        Source = "www.artsy.net",
                        ArtistId = 10
                    },
                    new Artwork
                    {
                        Title = "Still Life with a Skull and a Writing Quill",
                        Year = 1628,
                        ShortDescription = "Still Life with a Skull and a Writing Quill is an oil on Canvas painting by the Dutch still-life master Pieter Claesz in 1628.",
                        LongDescription = "This is one of the earliest dated still lifes by Claesz, a Haarlem painter who gave extraordinary presence to familiar things. Here a skull, an overturned glass roemer with its fleeting reflections, an expired lamp, and the attributes of a writer suggest that worldly efforts are ultimately in vain.",
                        ImageUrl = "/images/Artworks/10-Pieter-Claesz/1628-Still-Life-with-a-Skull-and-a-Writing-Quill.jpg",
                        ImageThumbnailUrl = "/images/Artworks/10-Pieter-Claesz/1628-tn_Still-Life-with-a-Skull-and-a-Writing-Quill.jpg",
                        Source = "www.metmuseum.org",
                        ArtistId = 10
                    },
                    new Artwork
                    {
                        Title = "Vanitas with Violin and Glass Ball",
                        Year = 1628,
                        ShortDescription = "Vanitas with Violin and Glass Ball is an oil on Panel painting by the Dutch still-life master Pieter Claesz in 1628.",
                        LongDescription = "Pieter Claesz creates an amazing vanitas in 1628. Here the focus is taken away from the skull, unlike earlier vanitas paintings in the exhibit, and he places it in the background. In front of the skull we see an overturned glass, whose contents have been drained out. This alludes to the brevity of all pleasures in life. On the other end of the table we see a pocket watch opened and facing the viewer. Once again we have the reference to time with the clock. The glass sphere in the back ground is very interesting. Here Claesz uses it to insert himself into the painting through a reflection. The sphere can also be seen as an allusion to a soap bubble similar to the ones seen in Jan van Kessel’s vanitas painting. The violin in the center of the painting, shows the parallels between music and painting, both pleasures in life.",
                        ImageUrl = "/images/Artworks/10-Pieter-Claesz/1628-Vanitas-with-Violin-and-Glass-Ball.jpg",
                        ImageThumbnailUrl = "/images/Artworks/10-Pieter-Claesz/1628-tn_Vanitas-with-Violin-and-Glass-Ball.jpg",
                        Source = "curiator.com",
                        ArtistId = 10
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
