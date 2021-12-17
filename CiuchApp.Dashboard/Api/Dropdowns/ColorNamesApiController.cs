using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorNamesController : BaseApiAsyncController<ColorName>
    {
        public ColorNamesController(ICrudService<ColorName> service, ILogger<ColorName> logger) : base(service, logger)
        {
        }
    }
}