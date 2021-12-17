using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonsController : BaseApiAsyncController<Season>
    {
        public SeasonsController(ICrudService<Season> service, ILogger<Season> logger) : base(service, logger)
        {
        }
    }
}