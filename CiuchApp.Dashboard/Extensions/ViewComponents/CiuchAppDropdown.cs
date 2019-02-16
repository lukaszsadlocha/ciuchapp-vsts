using CiuchApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CiuchApp.Dashboard.Extensions.ViewComponents
{
    public class CiuchAppDropdown : ViewComponent
    {
        public IViewComponentResult Invoke(Piece model, string fieldLabel, string field, IEnumerable<SelectListItem> values)
        {
            var dropdownViewModel = new DropdownViewModel
            {
                Model = model,
                FieldLabel = "ASP SSIE",
                Field = "Group",
                Values = values

            };
            return View(dropdownViewModel);
        }

    }
}
