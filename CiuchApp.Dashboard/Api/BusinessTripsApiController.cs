using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessTripsController : BaseApiAsyncController<BusinessTrip>
    {
        public BusinessTripsController(ICrudService<BusinessTrip> service, ILogger<BusinessTrip> logger) : base(service, logger)
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
    }
}