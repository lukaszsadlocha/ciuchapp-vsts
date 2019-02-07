using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Groups")]
    [ApiController]
    public class GroupsApiController : CiuchAppBaseApiController<Group>
    {
        public GroupsApiController(ICrudService<Group> service, ILogger<Group> logger) : base(service, logger)
        {
        }
    }
}