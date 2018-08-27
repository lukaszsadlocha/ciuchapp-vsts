using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.Dashboard.Data;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard
{
    [Produces("application/json")]
    [Route("api/Clothes")]
    public class ClothesApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClothesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Clothes
        [HttpGet]
        public IEnumerable<Piece> GetClothe()
        {
            return _context.Pieces;
        }

        //Details
        // GET: api/Clothes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClothe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clothe = await _context.Pieces.SingleOrDefaultAsync(m => m.Id == id);

            if (clothe == null)
            {
                return NotFound();
            }

            return Ok(clothe);
        }

        //Edit
        // PUT: api/Clothes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClothe([FromRoute] int id, [FromBody] Piece clothe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clothe.Id)
            {
                return BadRequest();
            }

            _context.Entry(clothe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClotheExists(id))
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

        // ADD
        // POST: api/Clothes
        [HttpPost]
        public async Task<IActionResult> PostClothe([FromBody] Piece clothe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pieces.Add(clothe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClothe", new { id = clothe.Id }, clothe);
        }

        // DELETE: api/Clothes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClothe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clothe = await _context.Pieces.SingleOrDefaultAsync(m => m.Id == id);
            if (clothe == null)
            {
                return NotFound();
            }

            _context.Pieces.Remove(clothe);
            await _context.SaveChangesAsync();

            return Ok(clothe);
        }

        private bool ClotheExists(int id)
        {
            return _context.Pieces.Any(e => e.Id == id);
        }
    }
}