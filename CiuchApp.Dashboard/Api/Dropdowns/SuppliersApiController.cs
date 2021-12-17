using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : BaseApiAsyncController<Supplier>
    {
        public SuppliersController(ICrudService<Supplier> service, ILogger<Supplier> logger) : base(service, logger)
        {
        }
    }
}