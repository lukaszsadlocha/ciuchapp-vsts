using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class GroupsController : CiuchAppDrodownBaseController<Group>
    {
        private readonly ICrudService<MainCategory> _mainCategoryService;

        public GroupsController(ICrudService<Group> serviceProvider, ILogger<Group> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices, ICrudService<MainCategory> mainCategoryService) : base(
            serviceProvider, 
            logger, 
            settings, 
            dropdownServices,
            editView: @"/Views/Dropdowns/Group/Edit.cshtml")
        {
            this._mainCategoryService = mainCategoryService;
        }

        protected override void PrepareDropdownValues()
        {
            ViewBag.MainCategories = _mainCategoryService.GetAll();
        }
    }
}