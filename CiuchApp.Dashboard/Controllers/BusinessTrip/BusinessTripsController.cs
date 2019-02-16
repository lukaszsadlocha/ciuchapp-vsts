using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Settings;
using CiuchApp.Dashboard.Controllers.Base;
using Microsoft.AspNetCore.Authorization;

namespace CiuchApp.Dashboard.Controllers
{
    [Authorize]
    public class BusinessTripsController : CiuchAppBaseController<BusinessTrip>
    {
        public BusinessTripsController(
            ICrudService<BusinessTrip> serviceProvider,
            ILogger<BusinessTrip> logger, ICiuchAppSettings settings,
            IDropdownServices dropdownServices) :
            base(
                serviceProvider,
                logger,
                settings,
                dropdownServices)
        { }

        protected override void PrepareDropdownValues()
        {
            ViewBag.Countries = _dropdownService.CountryService.GetAll();
            ViewBag.Cities = _dropdownService.CityService.GetAll();
            ViewBag.Currencies = _dropdownService.CurrencyService.GetAll();
            ViewBag.Seasons = _dropdownService.SeasonService.GetAll();
        }


        //// GET: BusinessTrips/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var businessTrip = await _context.BusinessTrips
        //        .Include(b => b.City)
        //        .Include(b => b.Country)
        //        .Include(b => b.Currency)
        //        .Include(b => b.Season)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (businessTrip == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(businessTrip);
        //}

        // GET: BusinessTrips/Create
        //public IActionResult Create()
        //{
        //    ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id");
        //    ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id");
        //    ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id");
        //    ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id");
        //    return View();
        //}

        // POST: BusinessTrips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,DateFrom,DateTo,CountryId,CityId,SeasonId,CurrencyId")] BusinessTrip businessTrip)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(businessTrip);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
        //    ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
        //    ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
        //    ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
        //    return View(businessTrip);
        //}

        //// GET: BusinessTrips/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var businessTrip = await _context.BusinessTrips.FindAsync(id);
        //    if (businessTrip == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
        //    ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
        //    ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
        //    ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
        //    return View(businessTrip);
        //}

        //// POST: BusinessTrips/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,DateFrom,DateTo,CountryId,CityId,SeasonId,CurrencyId")] BusinessTrip businessTrip)
        //{
        //    if (id != businessTrip.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(businessTrip);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BusinessTripExists(businessTrip.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
        //    ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
        //    ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
        //    ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
        //    return View(businessTrip);
        //}

        //// GET: BusinessTrips/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var businessTrip = await _context.BusinessTrips
        //        .Include(b => b.City)
        //        .Include(b => b.Country)
        //        .Include(b => b.Currency)
        //        .Include(b => b.Season)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (businessTrip == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(businessTrip);
        //}

        //// POST: BusinessTrips/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var businessTrip = await _context.BusinessTrips.FindAsync(id);
        //    _context.BusinessTrips.Remove(businessTrip);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BusinessTripExists(int id)
        //{
        //    return _context.BusinessTrips.Any(e => e.Id == id);
        //}
    }
}
