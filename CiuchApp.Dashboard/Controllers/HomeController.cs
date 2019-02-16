using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CiuchApp.Dashboard.Models;
using CiuchApp.Dashboard.Extensions.Attributes;
using Microsoft.AspNetCore.Authorization;

namespace CiuchApp.Dashboard.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
