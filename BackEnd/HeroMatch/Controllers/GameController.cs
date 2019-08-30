using HeroMatch.Models;
using HeroMatch.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private SiteContext db;

        public GameController(SiteContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> Get()
        {
            return db.Game;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetByProperties(int id)
        {   
            return db.Game.Single(g => g.GameId == id);
        }

    }
}
