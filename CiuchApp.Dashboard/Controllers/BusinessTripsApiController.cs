using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard
{
    [Route("api/BusinessTrips")]
    [ApiController]
    public class BusinessTripsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BusinessTripsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BusinessTripsApi
        [HttpGet]
        public IEnumerable<BusinessTrip> GetBusinessTrips()
        {
            var businessTrips = _context.BusinessTrips.Include(b => b.City).Include(b => b.Country).Include(b => b.Currency).Include(b => b.Season);
            return businessTrips;
        }

        // GET: api/BusinessTripsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBusinessTrip([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var businessTrip = await _context.BusinessTrips.FindAsync(id);

            if (businessTrip == null)
            {
                return NotFound();
            }

            return Ok(businessTrip);
        }

        //(EDIT)  PUT: api/BusinessTripsApi  
        public async Task<IActionResult> PutBusinessTrip([FromForm]BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!businessTrip.IsValid<BusinessTrip>(newItem: false))
                return BadRequest("Business Trip model is not valid");

            _context.Entry(businessTrip).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessTripExists(businessTrip.Id))   
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/BusinessTripsApi (ADD)
        [HttpPost]
        public async Task<IActionResult> PostBusinessTrip([FromForm] BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!businessTrip.IsValid<BusinessTrip>(newItem: true))
                return BadRequest("Business Trip model is not valid");

            _context.BusinessTrips.Add(businessTrip);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessTrip", new { id = businessTrip.Id }, businessTrip);
        }

        // DELETE: api/BusinessTripsApi
        [HttpDelete]
        public async Task<IActionResult> DeleteBusinessTrip([FromForm] BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var businessTripDb = await _context.BusinessTrips.FindAsync(businessTrip.Id);
            if (businessTripDb == null)
            {
                return NotFound();
            }

            _context.BusinessTrips.Remove(businessTripDb);
            await _context.SaveChangesAsync();

            return Ok(businessTripDb);
        }

        private bool BusinessTripExists(int id)
        {
            return _context.BusinessTrips.Any(e => e.Id == id);
        }
    }
}