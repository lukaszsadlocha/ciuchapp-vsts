using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{

    public class SizesController : CiuchAppBaseController<Size>
    {
        public SizesController(ICrudService<Size> serviceProvider, ILogger<Size> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }
}