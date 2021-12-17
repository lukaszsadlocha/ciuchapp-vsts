using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : BaseApiAsyncController<Component>
    {
        public ComponentsController(ICrudService<Component> service, ILogger<Component> logger) : base(service, logger)
        {
        }
    }
}