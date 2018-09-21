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
    public class CodeCnsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CodeCnsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CodeCns
        [HttpGet]
        public IEnumerable<CodeCn> GetCodeCns()
        {
            return _context.CodeCns;
        }

        // GET: api/CodeCns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCodeCn([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeCn = await _context.CodeCns.FindAsync(id);

            if (codeCn == null)
            {
                return NotFound();
            }

            return Ok(codeCn);
        }

        // PUT: api/CodeCns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodeCn([FromRoute] int id, [FromBody] CodeCn codeCn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codeCn.Id)
            {
                return BadRequest();
            }

            _context.Entry(codeCn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeCnExists(id))
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

        // POST: api/CodeCns
        [HttpPost]
        public async Task<IActionResult> PostCodeCn([FromBody] CodeCn codeCn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CodeCns.Add(codeCn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodeCn", new { id = codeCn.Id }, codeCn);
        }

        // DELETE: api/CodeCns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodeCn([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeCn = await _context.CodeCns.FindAsync(id);
            if (codeCn == null)
            {
                return NotFound();
            }

            _context.CodeCns.Remove(codeCn);
            await _context.SaveChangesAsync();

            return Ok(codeCn);
        }

        private bool CodeCnExists(int id)
        {
            return _context.CodeCns.Any(e => e.Id == id);
        }
    }
}