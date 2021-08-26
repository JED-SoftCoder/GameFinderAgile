using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameFinderAgile.Models
{
    public class GameGenre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        [Required]
        [MaxLength(256)]
        public string Description { get; set; }
    }
}