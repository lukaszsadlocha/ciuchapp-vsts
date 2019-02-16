using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class CodeCnsController : CiuchAppDrodownBaseController<CodeCn>
    {
        public CodeCnsController(ICrudService<CodeCn> serviceProvider, ILogger<CodeCn> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }
}