using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : BaseApiAsyncController<Currency>
    {
        public CurrenciesController(ICrudService<Currency> service, ILogger<Currency> logger) : base(service, logger)
        {
        }
    }
}