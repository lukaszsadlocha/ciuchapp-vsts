using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Color")]
    [ApiController]
    public class ColorsApiController : CiuchAppBaseApiAsyncController<Color>
    {
        public ColorsApiController(ICrudService<Color> service, ILogger<Color> logger) : base(service, logger)
        {
        }
    }
}