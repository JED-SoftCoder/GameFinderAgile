using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameFinderAgile.Models
{
    public class Game
    {
        [Key]
        public string Name { get; set; }


        [ForeignKey(nameof(GameGenre))]
        public int GenreId { get; set; }
        public virtual GameGenre GameGenre { get; set; }


        [ForeignKey(nameof(GameSystem))]
        public int GameSystemId { get; set; }
        public virtual GameSystem GameSystem { get; set; }

        public string ESRBRating { get; set; }

        [Range(0,10)]
        public double PlayerRating { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}