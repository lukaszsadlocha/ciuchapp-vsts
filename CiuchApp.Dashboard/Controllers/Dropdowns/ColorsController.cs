using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class ColorsController : CiuchAppDrodownBaseController<Color>
    {
        public ColorsController(ICrudService<Color> serviceProvider, ILogger<Color> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }

}