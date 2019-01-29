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
    public class TopCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TopCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TopCategories
        [HttpGet]
        public IEnumerable<TopCategory> GetTopCategories()
        {
            return _context.TopCategories;
        }

        // GET: api/TopCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTopCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var topCategory = await _context.TopCategories.FindAsync(id);

            if (topCategory == null)
            {
                return NotFound();
            }

            return Ok(topCategory);
        }

        // PUT: api/TopCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopCategory([FromRoute] int id, [FromBody] TopCategory topCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != topCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(topCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopCategoryExists(id))
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

        // POST: api/TopCategories
        [HttpPost]
        public async Task<IActionResult> PostTopCategory([FromBody] TopCategory topCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TopCategories.Add(topCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopCategory", new { id = topCategory.Id }, topCategory);
        }

        // DELETE: api/TopCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var topCategory = await _context.TopCategories.FindAsync(id);
            if (topCategory == null)
            {
                return NotFound();
            }

            _context.TopCategories.Remove(topCategory);
            await _context.SaveChangesAsync();

            return Ok(topCategory);
        }

        private bool TopCategoryExists(int id)
        {
            return _context.TopCategories.Any(e => e.Id == id);
        }
    }
}