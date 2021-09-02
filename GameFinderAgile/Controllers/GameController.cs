using GameFinderAgile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GameFinderAgile.Controllers
{
    public class GameController : ApiController
    {
        private readonly GameFinderDbContext _context = new GameFinderDbContext();

        //POST(create)
        //api/Game
        [HttpPost]
        public async Task<IHttpActionResult> CreateGame([FromBody] Game model)
        {
            if (model is null)
            {
                return BadRequest("your request body cannot be empty");
            }
            // If the model is valid
            if (ModelState.IsValid)
            {
                //Store the model in the database
                _context.Games.Add(model);
                int changeCount = await _context.SaveChangesAsync();

                return Ok("Your Game was created");
                
            }
            //The model is not valid,go ahead and reject it
            return BadRequest(ModelState);

        }

       

    }
}
