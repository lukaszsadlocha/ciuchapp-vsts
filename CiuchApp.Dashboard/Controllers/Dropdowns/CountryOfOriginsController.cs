using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class CountryOfOriginsController : CiuchAppDrodownBaseController<CountryOfOrigin>
    {
        public CountryOfOriginsController(ICrudService<CountryOfOrigin> serviceProvider, ILogger<CountryOfOrigin> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }
}