using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Seasons")]
    [ApiController]
    public class SeasonsApiController : CiuchAppBaseApiController<Season>
    {
        public SeasonsApiController(ICrudService<Season> service, ILogger<Season> logger) : base(service, logger)
        {
        }
    }
}