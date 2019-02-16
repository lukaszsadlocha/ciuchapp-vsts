using CiuchApp.Dashboard.Services;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class CardImageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int itemId)
        {
            //e.g. /Countries
            var folder = Request.Path.Value;
            var path = $@"/images{folder}/{itemId}.PNG";

            return View(model:path);
        }
    }
}

