using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/CountryOfOrigins")]
    [ApiController]
    public class CountryOfOriginsApiController : CiuchAppBaseApiController<CountryOfOrigin>
    {
        public CountryOfOriginsApiController(ICrudService<CountryOfOrigin> service, ILogger<CountryOfOrigin> logger) : base(service, logger)
        {
        }
    }
}