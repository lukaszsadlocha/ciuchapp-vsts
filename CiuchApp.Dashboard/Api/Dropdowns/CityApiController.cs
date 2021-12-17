using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : BaseApiAsyncController<City>
    {
        public CitiesController(ICrudService<City> service, ILogger<City> logger) : base(service, logger)
        {
        }
    }
}