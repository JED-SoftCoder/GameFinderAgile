using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameFinderAgile.Models
{
    public class GameFinderDbContext : DbContext
    {
        public GameFinderDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameSystem> GameSystems { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
    }
}