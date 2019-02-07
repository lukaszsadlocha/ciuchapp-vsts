using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class CountriesController : CiuchAppDrodownBaseController<Country>
    {
        public CountriesController(ICrudService<Country> serviceProvider, ILogger<Country> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
            
        }

        protected override void PrepareItemImages()
        {
            ViewBag.WithImageThumbnailPath = @"/images/BusinessTripImages/{0}.PNG";
        }
    }
}