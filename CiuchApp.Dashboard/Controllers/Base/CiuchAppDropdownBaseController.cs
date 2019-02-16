using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Controllers.Base
{
    public abstract class CiuchAppDrodownBaseController<T> : CiuchAppBaseController<T> where T : CiuchAppBaseModel
    {
        public CiuchAppDrodownBaseController(
            ICrudService<T> serviceProvider, 
            ILogger<T> logger, 
            ICiuchAppSettings settings, 
            IDropdownServices dropdownServices,
            string indexView = @"/Views/Dropdowns/Index.cshtml",
            string editView = @"/Views/Dropdowns/Edit.cshtml",
            string createView = @"/Views/Dropdowns/Create.cshtml",
            string deleteView = @"/Views/Dropdowns/Delete.cshtml"
            ) : base(serviceProvider, logger, settings, dropdownServices)
        {
            IndexView = indexView;
            EditView = editView;
            CreateView = createView;
            DeleteView = deleteView;
        }
    }
}