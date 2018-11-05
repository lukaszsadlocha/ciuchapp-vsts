using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Collections;
using CiuchApp.Settings;
using Microsoft.AspNetCore;

namespace CiuchApp.Dashboard
{
    [Route("api/Images")]
    [ApiController]
    public class ImageApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly CiuchAppSettings _settings;

        public ImageApiController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _environment = env;
            _settings = CiuchAppSettingsFactory.GetSettings();
        }

        // POST:
        [HttpPost]
        public void PostImage()
        {
            if (Request?.Form?.Files?.Count > 0)
            {
                var file = Request.Form.Files[0];
                var fileName = file.FileName;

                //var webrootFolder = _environment.WebRootPath;

                var rootPath = _environment.WebRootPath;
                var localDir = _settings.PhotoStorageFolder.Server.Name;

                var localPath = Path.Combine(rootPath, localDir, fileName);

                using (var fileStream = System.IO.File.Create(localPath))
                {
                    file.CopyTo(fileStream);
                }
            }
        }

    }
}