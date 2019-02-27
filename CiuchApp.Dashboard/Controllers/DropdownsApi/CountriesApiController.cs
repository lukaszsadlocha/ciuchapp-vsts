using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Countries")]
    [ApiController]
    public class CountriesApiController : CiuchAppBaseApiAsyncController<Country>
    {
        public CountriesApiController(ICrudService<Country> service, ILogger<Country> logger) : base(service, logger)
        {
        }
    }
}