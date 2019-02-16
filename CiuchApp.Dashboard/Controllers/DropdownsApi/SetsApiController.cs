using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Sets")]
    [ApiController]
    public class SetsApiController : CiuchAppBaseApiController<Set>
    {
        public SetsApiController(ICrudService<Set> service, ILogger<Set> logger) : base(service, logger)
        {
        }
    }
}