using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class CurrenciesController : CiuchAppDrodownBaseController<Currency>
    {
        public CurrenciesController(ICrudService<Currency> serviceProvider, ILogger<Currency> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }
}