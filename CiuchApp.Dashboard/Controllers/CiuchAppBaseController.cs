using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;

namespace CiuchApp.Dashboard
{
    public abstract class CiuchAppBaseController<T> : Controller
    {
        private readonly ICrudService<T> _service;
        private readonly ILogger<T> _logger;
        private readonly ICiuchAppSettings _settings;

        public CiuchAppBaseController(ICrudService<T> serviceProvider, ILogger<T> logger, ICiuchAppSettings settings)
        {
            _service = serviceProvider;
            _logger = logger;
            _settings = settings;
        }

        // GET: BusinessTrips
        public IActionResult Index()
        {
            ViewBag.PhotoStoragePath = _settings.PhotoStorageFolder.Server.Name;
            return View(_service.GetAll());
        }
    }
}