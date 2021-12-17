using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopCategoriesController : BaseApiAsyncController<TopCategory>
    {
        public TopCategoriesController(ICrudService<TopCategory> service, ILogger<TopCategory> logger) : base(service, logger)
        {
        }
    }
}