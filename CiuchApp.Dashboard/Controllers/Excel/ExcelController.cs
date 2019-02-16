using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CiuchApp.Dashboard.Models;
using CiuchApp.Excel;
using Microsoft.AspNetCore.Hosting;
using System;
using CiuchApp.Dashboard.Services;
using CiuchApp.Domain;
using CiuchApp.Settings;

namespace CiuchApp.Dashboard.Controllers
{
    public class ExcelController : Controller
    {
        private readonly string _excelFileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private readonly IHostingEnvironment _env;
        private readonly ICiuchAppSettings _settings;
        private readonly ICrudService<Piece> _service;

        public ExcelController(IHostingEnvironment env, ICrudService<Piece> service, ICiuchAppSettings settings)
        {
            _env = env;
            _settings = settings;
            _service = service;
        }

        public IActionResult GenerateKpcExcel(int id)
        {
            //id in this case is a business trip Id and it takes all pieces of this business trip
            var pieces = _service.GetAll();

            var excelName = _settings.Excel.KpcFileName;
            var memoryStream = ExcelGenerator.GetKpcExcelMemoryStream(pieces, _env.WebRootPath, _settings.Excel.FolderName, excelName);
            return File(memoryStream, _excelFileType, excelName);
        }
    }
}
