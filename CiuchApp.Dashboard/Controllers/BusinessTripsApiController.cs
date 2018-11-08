using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;

namespace CiuchApp.Dashboard
{
    [Route("api/BusinessTrips")]
    [ApiController]
    public class BusinessTripsApiController : ControllerBase
    {
        private readonly IBusinessTripService _businessTripService;
        private readonly ILogger<BusinessTripsApiController> _logger;

        public BusinessTripsApiController(IBusinessTripService businessTripService, ILogger<BusinessTripsApiController> logger)
        {
            _businessTripService = businessTripService;
            _logger = logger;
        }

        // GET: api/BusinessTripsApi
        [HttpGet]
        public IEnumerable<BusinessTrip> GetBusinessTrips()
        {
            return _businessTripService.GetBusinessTrips();
        }

        [HttpGet]
        [Route("{id}/Pieces")]
        public IEnumerable<Piece> GetBusinessTripPieces(int id)
        {
            return _businessTripService.GetBusinessTripsPieces(id);
        }
        [HttpPut] // EDIT Business Trip
        public IActionResult PutBusinessTrip([FromForm]BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid || !businessTrip.IsValid<BusinessTrip>(newItem: false))
                return BadRequest(ModelState);

            if (_businessTripService.UpdateBusinessTrip(businessTrip))
                return Ok();

            return NotFound();
        }

        [HttpPost] // ADD Business Trip
        public IActionResult PostBusinessTrip([FromForm] BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid || !businessTrip.IsValid<BusinessTrip>(newItem: true))
                return BadRequest(ModelState);

            if (_businessTripService.AddBusinessTrip(businessTrip))
                return Ok();

            return NotFound();
        }

        [HttpDelete]// DELETE:
        public IActionResult DeleteBusinessTrip([FromForm] BusinessTrip businessTrip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_businessTripService.DeleteBusinessTrip(businessTrip))
                return Ok();

            return NotFound();
        }

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