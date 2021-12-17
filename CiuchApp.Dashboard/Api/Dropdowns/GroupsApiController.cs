using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : BaseApiAsyncController<Group>
    {
        public GroupsController(ICrudService<Group> service, ILogger<Group> logger) : base(service, logger)
        {
        }
    }
}