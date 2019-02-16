using CiuchApp.Dashboard.Services;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class IndexButtonRowViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool includeExcelActions)
        {
            return View(includeExcelActions);
        }
    }
}

