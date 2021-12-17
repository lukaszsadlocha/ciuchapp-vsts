using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : BaseApiAsyncController<Size>
    {
        public SizesController(ICrudService<Size> service, ILogger<Size> logger) : base(service, logger)
        {
        }
    }
}