using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroMatch;
using HeroMatch.Models;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private readonly SiteContext _context;

        public FiltersController(SiteContext context)
        {
            _context = context;
        }

        // GET: api/Filters
        [HttpGet]
        public IEnumerable<Filter> GetFilter()
        {
            return _context.Filter;
        }

        // GET: api/Filters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFilter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var filter = await _context.Filter.FindAsync(id);

            if (filter == null)
            {
                return NotFound();
            }

            return Ok(filter);
        }

        public async Task<ActionResult<Character>> Results(Filter filter)
        {
            var filters = await _context.Filter.FindAsync(filter);
            var values = _context.Filter.Single(f => f.Difficulty == filter.Difficulty && f.Role == filter.Role && f.SubRole == filter.SubRole);

            return _context.Character.Single(c => c.CharacterId == filter.CharacterId);


        }

        // PUT: api/Filters/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Character>> PutFilter([FromRoute] int id, [FromBody] Filter filter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != filter.FilterId)
            {
                return BadRequest();
            }

            _context.Entry(filter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return _context.Character.Single(r => r.CharacterId == filter.CharacterId);
        }

        // POST: api/Filters
        [HttpPost]
        public async Task<ActionResult<Character>> PostFilter([FromBody] Filter filter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Filter.Add(filter);
            await _context.SaveChangesAsync();

            return _context.Character.Single(r => r.CharacterId == filter.CharacterId);
        }

        // DELETE: api/Filters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Character>> DeleteFilter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var filter = await _context.Filter.FindAsync(id);
            if (filter == null)
            {
                return NotFound();
            }

            _context.Filter.Remove(filter);
            await _context.SaveChangesAsync();

            return _context.Character.Single(r => r.CharacterId == filter.CharacterId);
        }

        private bool FilterExists(int id)
        {
            return _context.Filter.Any(e => e.FilterId == id);
        }
    }
}