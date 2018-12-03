using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryOfOriginsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CountryOfOriginsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CountryOfOrigins
        [HttpGet]
        public IEnumerable<CountryOfOrigin> GetCountryOfOrigin()
        {
            return _context.CountryOfOrigin;
        }

        // GET: api/CountryOfOrigins/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountryOfOrigin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var countryOfOrigin = await _context.CountryOfOrigin.FindAsync(id);

            if (countryOfOrigin == null)
            {
                return NotFound();
            }

            return Ok(countryOfOrigin);
        }

        // PUT: api/CountryOfOrigins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountryOfOrigin([FromRoute] int id, [FromBody] CountryOfOrigin countryOfOrigin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != countryOfOrigin.Id)
            {
                return BadRequest();
            }

            _context.Entry(countryOfOrigin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryOfOriginExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CountryOfOrigins
        [HttpPost]
        public async Task<IActionResult> PostCountryOfOrigin([FromBody] CountryOfOrigin countryOfOrigin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CountryOfOrigin.Add(countryOfOrigin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountryOfOrigin", new { id = countryOfOrigin.Id }, countryOfOrigin);
        }

        // DELETE: api/CountryOfOrigins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountryOfOrigin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var countryOfOrigin = await _context.CountryOfOrigin.FindAsync(id);
            if (countryOfOrigin == null)
            {
                return NotFound();
            }

            _context.CountryOfOrigin.Remove(countryOfOrigin);
            await _context.SaveChangesAsync();

            return Ok(countryOfOrigin);
        }

        private bool CountryOfOriginExists(int id)
        {
            return _context.CountryOfOrigin.Any(e => e.Id == id);
        }
    }
}