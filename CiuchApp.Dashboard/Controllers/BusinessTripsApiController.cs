using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.Dashboard
{
    [ApiController]
    [Route("api/BusinessTrips")]
    public class BusinessTripsApiController : CiuchAppBaseApiController<BusinessTrip>
    {
        public BusinessTripsApiController(ICrudService<BusinessTrip> service, ILogger<BusinessTrip> logger) : base(service, logger)
        {
        }

        [HttpGet]
        [Route("{id}/Pieces")]
        public IEnumerable<Piece> GetBusinessTripPieces(int id)
        {
            return _service.GetContext().Pieces.Where(x => x.BusinessTripId == id)
                .Include(x => x.BusinessTrip)
                .Include(x => x.SizeAmountPairs)
                .ToList();
        }

        // TODO: fix this method ? move it to piece??
        //[HttpGet]
        //[Route("{id}/Pieces")]
        //public IEnumerable<Piece> GetBusinessTripPieces(int id)
        //{
        //    return _businessTripService.GetBusinessTripsPieces(id);
        //}

        //// GET: api/BusinessTripsApi
        //[HttpGet]
        //public IEnumerable<BusinessTrip> GetBusinessTrips()
        //{
        //    return _businessTripService.GetAll();
        //}


        //[HttpPut] // EDIT Business Trip
        //public IActionResult PutBusinessTrip([FromForm]BusinessTrip businessTrip)
        //{
        //    if (!ModelState.IsValid || !businessTrip.IsValid<BusinessTrip>(newItem: false))
        //        return BadRequest(ModelState);

        //    if (_businessTripService.UpdateBusinessTrip(businessTrip))
        //        return Ok();

        //    return NotFound();
        //}

        //[HttpPost] // ADD Business Trip
        //public IActionResult PostBusinessTrip([FromForm] BusinessTrip businessTrip)
        //{
        //    if (!ModelState.IsValid || !businessTrip.IsValid<BusinessTrip>(newItem: true))
        //        return BadRequest(ModelState);

        //    if (_businessTripService.AddBusinessTrip(businessTrip))
        //        return Ok();

        //    return NotFound();
        //}

        //[HttpDelete]// DELETE:
        //public IActionResult DeleteBusinessTrip([FromForm] BusinessTrip businessTrip)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (_businessTripService.DeleteBusinessTrip(businessTrip))
        //        return Ok();

        //    return NotFound();
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById([FromRoute] int id)
        //{
        //    var businessTrip = await _context.BusinessTrips.FindAsync(id);

        //    if (businessTrip == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(businessTrip);
        //}

        //private bool BusinessTripExists(int id)
        //{
        //    return _context.BusinessTrips.Any(e => e.Id == id);
        //}
    }
}