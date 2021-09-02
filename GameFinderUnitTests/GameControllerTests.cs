using GameFinderAgile.Controllers;
using GameFinderAgile.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace GameFinderUnitTests
{
    [TestClass]
    public class GameControllerTests
    {
        private readonly GameFinderDbContext _context = new GameFinderDbContext();
        GameController _controller = new GameController();
       
        [TestMethod]
        public void PostGame_ShouldGetAreEqual()
        {
            _controller.Request = new HttpRequestMessage();
            Game newGame = new Game();
            newGame.Name = "Super Mario Bros 2";
            newGame.GenreId = 1;
            newGame.GameSystemId = 1;
            newGame.ESRBRating = "E";
            newGame.PlayerRating = 10;
            newGame.ReleaseDate = new DateTime(1988, 10, 09);
            _context.Games.Add(newGame);
            var okResult = _controller.CreateGame(newGame);
            Assert.AreEqual(newGame, _context.Games.Find(newGame.Name));
        }
    }
}
