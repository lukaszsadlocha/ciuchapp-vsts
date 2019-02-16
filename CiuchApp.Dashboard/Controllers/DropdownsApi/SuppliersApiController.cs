using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Suppliers")]
    [ApiController]
    public class SuppliersApiController : CiuchAppBaseApiController<Supplier>
    {
        public SuppliersApiController(ICrudService<Supplier> service, ILogger<Supplier> logger) : base(service, logger)
        {
        }
    }
}