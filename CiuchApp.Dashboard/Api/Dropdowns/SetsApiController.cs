using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetsController : BaseApiAsyncController<Set>
    {
        public SetsController(ICrudService<Set> service, ILogger<Set> logger) : base(service, logger)
        {
        }
    }
}