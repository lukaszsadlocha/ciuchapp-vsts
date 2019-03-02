using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/MainCategories")]
    [ApiController]
    public class MainCategoriesApiController : CiuchAppBaseApiAsyncController<MainCategory>
    {
        public MainCategoriesApiController(ICrudService<MainCategory> service, ILogger<MainCategory> logger) : base(service, logger)
        {
        }
    }
}