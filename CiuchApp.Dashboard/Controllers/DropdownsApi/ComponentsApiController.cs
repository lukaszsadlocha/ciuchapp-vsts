using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Components")]
    [ApiController]
    public class ComponentsApiController : CiuchAppBaseApiAsyncController<Component>
    {
        public ComponentsApiController(ICrudService<Component> service, ILogger<Component> logger) : base(service, logger)
        {
        }
    }
}