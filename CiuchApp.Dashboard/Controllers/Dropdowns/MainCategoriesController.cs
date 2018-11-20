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
    public class MainCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MainCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MainCategories
        [HttpGet]
        public IEnumerable<MainCategory> GetMainCategories()
        {
            return _context.MainCategories;
        }

        // GET: api/MainCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMainCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mainCategory = await _context.MainCategories.FindAsync(id);

            if (mainCategory == null)
            {
                return NotFound();
            }

            return Ok(mainCategory);
        }

        // PUT: api/MainCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainCategory([FromRoute] int id, [FromBody] MainCategory mainCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mainCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainCategoryExists(id))
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

        // POST: api/MainCategories
        [HttpPost]
        public async Task<IActionResult> PostMainCategory([FromBody] MainCategory mainCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MainCategories.Add(mainCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMainCategory", new { id = mainCategory.Id }, mainCategory);
        }

        // DELETE: api/MainCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mainCategory = await _context.MainCategories.FindAsync(id);
            if (mainCategory == null)
            {
                return NotFound();
            }

            _context.MainCategories.Remove(mainCategory);
            await _context.SaveChangesAsync();

            return Ok(mainCategory);
        }

        private bool MainCategoryExists(int id)
        {
            return _context.MainCategories.Any(e => e.Id == id);
        }
    }
}