using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CiuchApp.Dashboard.Data;
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
            return View(await _context.BusinessTrips.ToListAsync());
        }

        // GET: BusinessTrips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessTrip = await _context.BusinessTrips
                .SingleOrDefaultAsync(m => m.Id == id);
            if (businessTrip == null)
            {
                return NotFound();
            }

            return View(businessTrip);
        }

        // GET: BusinessTrips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BusinessTrips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Country,City,Date")] BusinessTrip businessTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessTrip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(businessTrip);
        }

        // GET: BusinessTrips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessTrip = await _context.BusinessTrips.SingleOrDefaultAsync(m => m.Id == id);
            if (businessTrip == null)
            {
                return NotFound();
            }
            return View(businessTrip);
        }

        // POST: BusinessTrips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Country,City,Date")] BusinessTrip businessTrip)
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
                .SingleOrDefaultAsync(m => m.Id == id);
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
            var businessTrip = await _context.BusinessTrips.SingleOrDefaultAsync(m => m.Id == id);
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
