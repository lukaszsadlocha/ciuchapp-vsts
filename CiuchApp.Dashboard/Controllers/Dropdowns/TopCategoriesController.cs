using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class TopCategoriesController : CiuchAppDrodownBaseController<TopCategory>
    {
        public TopCategoriesController(ICrudService<TopCategory> serviceProvider, ILogger<TopCategory> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }
}