using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameFinderAgile.Models
{
    public class GameSystem
    {
        [Key]
        public int GameSystemId { get; set; }
        [Required]
        public string Name { get; set; }
        public int NumberOfGames { get; set; }


    }
}