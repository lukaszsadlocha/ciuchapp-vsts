using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;

namespace CiuchApp.Dashboard
{
    [ApiController]
    [Route("api/Cache")]
    public class CacheApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CacheApiController(ApplicationDbContext context, ILogger<CacheApiController> logger)
        {
            _context = context;
        }

        [HttpGet]
        public CacheContext GetCache()
        {
            var cacheContext = new CacheContext
            {
                BusinessTrips = _context.BusinessTrips.Include(x => x.Pieces).ThenInclude(y => y.SizeAmountPairs).ToList(),

                Colors = _context.Colors.ToList(),
                MainCategories = _context.MainCategories.ToList(),
                TopCategories = _context.TopCategories.ToList(),
                Groups = _context.Groups.ToList(),
                Components = _context.Components.ToList(),
                CountryOfOrigin = _context.CountryOfOrigin.ToList(),
                Suppliers = _context.Suppliers.ToList(),
                Sizes = _context.Sizes.ToList(),
                CodeCns = _context.CodeCns.ToList(),
                Sets = _context.Sets.ToList(),
                ColorNames = _context.ColorNames.ToList(),
                SizeAmountPairs = _context.SizeAmountPairs.ToList(),

                Countries = _context.Countries.ToList(),
                Cities = _context.Cities.ToList(),
                Seasons = _context.Seasons.ToList(),
                Currencies = _context.Currencies.ToList()
            };

            return cacheContext;
        }
    }
}