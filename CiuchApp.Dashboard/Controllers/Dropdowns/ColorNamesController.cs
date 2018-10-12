using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorNamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ColorNamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ColorNames
        [HttpGet]
        public IEnumerable<ColorName> GetColorNames()
        {
            return _context.ColorNames;
        }

        // GET: api/ColorNames/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColorName([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var colorName = await _context.ColorNames.FindAsync(id);

            if (colorName == null)
            {
                return NotFound();
            }

            return Ok(colorName);
        }

        // PUT: api/ColorNames/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColorName([FromRoute] int id, [FromBody] ColorName colorName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != colorName.Id)
            {
                return BadRequest();
            }

            _context.Entry(colorName).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorNameExists(id))
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

        // POST: api/ColorNames
        [HttpPost]
        public async Task<IActionResult> PostColorName([FromBody] ColorName colorName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ColorNames.Add(colorName);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColorName", new { id = colorName.Id }, colorName);
        }

        // DELETE: api/ColorNames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColorName([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var colorName = await _context.ColorNames.FindAsync(id);
            if (colorName == null)
            {
                return NotFound();
            }

            _context.ColorNames.Remove(colorName);
            await _context.SaveChangesAsync();

            return Ok(colorName);
        }

        private bool ColorNameExists(int id)
        {
            return _context.ColorNames.Any(e => e.Id == id);
        }
    }
}