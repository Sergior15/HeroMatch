using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroMatch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizResultsController : ControllerBase
    {
        private readonly SiteContext _context;

        public QuizResultsController(SiteContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Character>> Results(Filter filter)
        {
            var filters = await _context.Filter.FindAsync(filter);
            var values = _context.Filter.Single(f => f.Difficulty == filter.Difficulty && f.Role == filter.Role && f.SubRole == filter.SubRole);

            return _context.Character.Single(c => c.CharacterId == filter.CharacterId);


        }
    }
}