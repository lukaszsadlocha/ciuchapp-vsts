using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/Currencies")]
    [ApiController]
    public class CurrenciesApiController : CiuchAppBaseApiController<Currency>
    {
        public CurrenciesApiController(ICrudService<Currency> service, ILogger<Currency> logger) : base(service, logger)
        {
        }
    }
}