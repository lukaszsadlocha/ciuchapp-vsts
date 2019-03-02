using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/ColorNames")]
    [ApiController]
    public class ColorNamesApiController : CiuchAppBaseApiAsyncController<ColorName>
    {
        public ColorNamesApiController(ICrudService<ColorName> service, ILogger<ColorName> logger) : base(service, logger)
        {
        }
    }
}