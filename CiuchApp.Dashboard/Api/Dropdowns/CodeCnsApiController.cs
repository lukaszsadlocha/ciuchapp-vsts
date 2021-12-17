using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class CodeCnsController : BaseApiAsyncController<CodeCn>
    {
        public CodeCnsController(ICrudService<CodeCn> service, ILogger<CodeCn> logger) : base(service, logger)
        {
        }
    }
}