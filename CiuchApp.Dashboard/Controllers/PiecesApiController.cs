using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using CiuchApp.DataAccess.AspNetIdentity;
using Microsoft.AspNetCore.Identity;

namespace CiuchApp.Dashboard
{
    [Route("api/Pieces")]
    [ApiController]
    public class PiecesApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PiecesApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        public UserManager<ApplicationUser> UserManager { get; private set; }
        // GET: api/PiecesApi
        [HttpGet]
        public IEnumerable<Piece> GetPieces()
        {
            return _context.Pieces
                .Include(p => p.BusinessTrip).ThenInclude(b => b.City)
                .Include(p => p.BusinessTrip).ThenInclude(b => b.Country)
                .Include(p => p.BusinessTrip).ThenInclude(b => b.Currency)
                .Include(p => p.BusinessTrip).ThenInclude(b => b.Season)
                .Include(p => p.CodeCn)
                .Include(p => p.Color)
                .Include(p => p.ColorName)
                .Include(p => p.CountryOfOrigin)
                .Include(p => p.Group)
                .Include(p => p.MainCategory)
                .Include(p => p.Set)
                .Include(p => p.Size)
                .Include(p => p.Supplier);
        }

        // GET: api/PiecesApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPiece([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piece = await _context.Pieces.FindAsync(id);

            if (piece == null)
            {
                return NotFound();
            }

            return Ok(piece);
        }

        // PUT: api/PiecesApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPiece([FromRoute] int id, [FromBody] Piece piece)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != piece.Id)
            {
                return BadRequest();
            }

            _context.Entry(piece).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PieceExists(id))
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

        // POST: api/PiecesApi
        [HttpPost]
        public async Task<IActionResult> PostPiece([FromBody] Piece piece)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pieces.Add(piece);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPiece", new { id = piece.Id }, piece);
        }

        // DELETE: api/PiecesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePiece([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piece = await _context.Pieces.FindAsync(id);
            if (piece == null)
            {
                return NotFound();
            }

            _context.Pieces.Remove(piece);
            await _context.SaveChangesAsync();

            return Ok(piece);
        }

        private bool PieceExists(int id)
        {
            return _context.Pieces.Any(e => e.Id == id);
        }
    }
}