using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainCategoriesController : BaseApiAsyncController<MainCategory>
    {
        public MainCategoriesController(ICrudService<MainCategory> service, ILogger<MainCategory> logger) : base(service, logger)
        {
        }
    }
}