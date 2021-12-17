using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryOfOriginsController : BaseApiAsyncController<CountryOfOrigin>
    {
        public CountryOfOriginsController(ICrudService<CountryOfOrigin> service, ILogger<CountryOfOrigin> logger) : base(service, logger)
        {
        }
    }
}