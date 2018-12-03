using Microsoft.AspNetCore.Mvc;
using CiuchApp.DataAccess;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using CiuchApp.Settings;

namespace CiuchApp.Dashboard
{
    [Route("api/Images")]
    [ApiController]
    public class ImageApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly ICiuchAppSettings _settings;

        public ImageApiController(ApplicationDbContext context, IHostingEnvironment env, ICiuchAppSettings settings)
        {
            _context = context;
            _environment = env;
            _settings = settings;
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