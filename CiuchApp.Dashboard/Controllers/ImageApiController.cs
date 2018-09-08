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

namespace CiuchApp.Dashboard
{
    [Route("api/Images")]
    [ApiController]
    public class ImageApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        public ImageApiController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        // GET: api/BusinessTripsApi
        [HttpGet]
        public IEnumerable<BusinessTrip> GetBusinessTrips()
        {
            var businessTrips = _context.BusinessTrips.Include(b => b.City).Include(b => b.Country).Include(b => b.Currency).Include(b => b.Season);
            return businessTrips;
        }

        // POST:
        
        [HttpPost]
        public async Task PostImage()
        {
            if(Request?.Form?.Files?.Count > 0)
            {
                var file = Request.Form.Files[0];
                var webrootFolder = _environment.WebRootPath;


                using (var fileStream = System.IO.File.Create(webrootFolder + @"/kupadupa.jpg"))
                {
                    file.CopyTo(fileStream);
                }
                //System.IO.File.WriteAllBytes(webrootFolder + @"/kupadupa.jpg", file.CopyTo


            }
        }

    }
}