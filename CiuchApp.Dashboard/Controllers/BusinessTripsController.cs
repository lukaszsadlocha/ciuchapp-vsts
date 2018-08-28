using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard
{
    public class BusinessTripsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusinessTripsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BusinessTrips
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BusinessTrips
                .Include(b => b.City)
                .Include(b => b.Country)
                .Include(b => b.Currency)
                .Include(b => b.Season);

            var cities = _context.Cities.ToList();

            ViewBag.cities = cities;

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BusinessTrips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessTrip = await _context.BusinessTrips
                .Include(b => b.City)
                .Include(b => b.Country)
                .Include(b => b.Currency)
                .Include(b => b.Season)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessTrip == null)
            {
                return NotFound();
            }

            return View(businessTrip);
        }

        // GET: BusinessTrips/Create
        public IActionResult Create()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id");
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id");
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id");
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id");
            return View();
        }

        // POST: BusinessTrips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateFrom,DateTo,CountryId,CityId,SeasonId,CurrencyId")] BusinessTrip businessTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessTrip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
            return View(businessTrip);
        }

        // GET: BusinessTrips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessTrip = await _context.BusinessTrips.FindAsync(id);
            if (businessTrip == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
            return View(businessTrip);
        }

        // POST: BusinessTrips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateFrom,DateTo,CountryId,CityId,SeasonId,CurrencyId")] BusinessTrip businessTrip)
        {
            if (id != businessTrip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(businessTrip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessTripExists(businessTrip.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", businessTrip.CityId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Id", businessTrip.CountryId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Id", businessTrip.CurrencyId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", businessTrip.SeasonId);
            return View(businessTrip);
        }

        // GET: BusinessTrips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessTrip = await _context.BusinessTrips
                .Include(b => b.City)
                .Include(b => b.Country)
                .Include(b => b.Currency)
                .Include(b => b.Season)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessTrip == null)
            {
                return NotFound();
            }

            return View(businessTrip);
        }

        // POST: BusinessTrips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var businessTrip = await _context.BusinessTrips.FindAsync(id);
            _context.BusinessTrips.Remove(businessTrip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessTripExists(int id)
        {
            return _context.BusinessTrips.Any(e => e.Id == id);
        }
    }
}
