using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/CodeCns")]
    [ApiController]
    public class CodeCnsApiController : CiuchAppBaseApiAsyncController<CodeCn>
    {
        public CodeCnsApiController(ICrudService<CodeCn> service, ILogger<CodeCn> logger) : base(service, logger)
        {
        }
    }
}