using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Sizes")]
    [ApiController]
    public class SizesApiController : CiuchAppBaseApiController<Size>
    {
        public SizesApiController(ICrudService<Size> service, ILogger<Size> logger) : base(service, logger)
        {
        }
    }
}