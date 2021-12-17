using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : BaseApiAsyncController<Country>
    {
        public CountriesController(ICrudService<Country> service, ILogger<Country> logger) : base(service, logger)
        {
        }
    }
}