using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Cities")]
    [ApiController]
    public class CitiesApiController : CiuchAppBaseApiAsyncController<City>
    {
        public CitiesApiController(ICrudService<City> service, ILogger<City> logger) : base(service, logger)
        {
        }
    }
}