using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorsController : BaseApiAsyncController<Color>
    {
        public ColorsController(ICrudService<Color> service, ILogger<Color> logger) : base(service, logger)
        {
        }
    }
}