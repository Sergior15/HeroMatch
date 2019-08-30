using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroMatch;
using HeroMatch.Models;
using HeroMatch.Repositories;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private SiteContext db;

        public CharactersController(SiteContext db)
        {
            this.db = db; 
        }

        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get()
        {
            return db.Character;
        }

        [HttpGet("{gameId}/{difficulty}/{role}/{subRole}")]
        public ActionResult<List<Character>> GetByProperties(int gameId, int difficulty, int role, int subRole, int aesthetic)
        {
            IEnumerable<Character> charlist = db.Character
                .Where(c => c.GameId == gameId && c.Difficulty == difficulty && c.Role == role && c.SubRole == subRole);

            return charlist.ToList();
        }

    }
}