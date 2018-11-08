using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Hosting;
using CiuchApp.Settings;
using System.IO;
using CiuchApp.Dashboard.Services;

namespace CiuchApp.Dashboard
{
    public class PiecesController : Controller
    {
        private readonly IPieceService _pieceService;
        private readonly IHostingEnvironment _environment;
        private readonly ICiuchAppSettings _settings;

        public PiecesController(IPieceService pieceService, IHostingEnvironment environment, ICiuchAppSettings settings)
        {
            _pieceService = pieceService;
            _environment = environment;
            _settings = settings;
        }

        // GET: Pieces
        public IActionResult Index()
        {
            ViewBag.PhotoStoragePath = _settings.PhotoStorageFolder.Server.Name;
            return View(_pieceService.GetPieces());
        }

        //[HttpPost, ActionName("Delete")]
        ////[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(Piece piece)
        //{
        //    _pieceService.DeletePiece(piece);
        //    return RedirectToAction(nameof(Index));
        //}

        // GET: Pieces/Create
        //public IActionResult Create()
        //{
        //    ViewData["BusinessTripId"] = new SelectList(_context.BusinessTrips, "Id", "Id");
        //    ViewData["CodeCnId"] = new SelectList(_context.CodeCns, "Id", "Id");
        //    ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Id");
        //    ViewData["ColorNameId"] = new SelectList(_context.ColorNames, "Id", "Id");
        //    ViewData["CountryOfOriginId"] = new SelectList(_context.CountryOfOrigin, "Id", "Id");
        //    ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id");
        //    ViewData["MainCategoryId"] = new SelectList(_context.MainCategories, "Id", "Id");
        //    ViewData["SetId"] = new SelectList(_context.Sets, "Id", "Id");
        //    ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id");
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id");
        //    return View();
        //}

        // POST: Pieces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,BusinessTripId,ColorId,MainCategoryId,GroupId,ComponentsId,CountryOfOriginId,BuyPrice,SellPrice,SupplierId,SizeId,OrderDate,EstimatedDateOfShipment,EstimatedTimeOfDelivery,Amount,CodeCnId,SetId,ColorNameId,ImageName")] Piece piece)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(piece);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["BusinessTripId"] = new SelectList(_context.BusinessTrips, "Id", "Id", piece.BusinessTripId);
        //    ViewData["CodeCnId"] = new SelectList(_context.CodeCns, "Id", "Id", piece.CodeCnId);
        //    ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Id", piece.ColorId);
        //    ViewData["ColorNameId"] = new SelectList(_context.ColorNames, "Id", "Id", piece.ColorNameId);
        //    ViewData["CountryOfOriginId"] = new SelectList(_context.CountryOfOrigin, "Id", "Id", piece.CountryOfOriginId);
        //    ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", piece.GroupId);
        //    ViewData["MainCategoryId"] = new SelectList(_context.MainCategories, "Id", "Id", piece.MainCategoryId);
        //    ViewData["SetId"] = new SelectList(_context.Sets, "Id", "Id", piece.SetId);
        //    ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", piece.SizeId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", piece.SupplierId);
        //    return View(piece);
        //}

        // GET: Pieces/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var piece = await _context.Pieces.FindAsync(id);
        //    if (piece == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["BusinessTripId"] = new SelectList(_context.BusinessTrips, "Id", "Id", piece.BusinessTripId);
        //    ViewData["CodeCnId"] = new SelectList(_context.CodeCns, "Id", "Id", piece.CodeCnId);
        //    ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Id", piece.ColorId);
        //    ViewData["ColorNameId"] = new SelectList(_context.ColorNames, "Id", "Id", piece.ColorNameId);
        //    ViewData["CountryOfOriginId"] = new SelectList(_context.CountryOfOrigin, "Id", "Id", piece.CountryOfOriginId);
        //    ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", piece.GroupId);
        //    ViewData["MainCategoryId"] = new SelectList(_context.MainCategories, "Id", "Id", piece.MainCategoryId);
        //    ViewData["SetId"] = new SelectList(_context.Sets, "Id", "Id", piece.SetId);
        //    ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", piece.SizeId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", piece.SupplierId);
        //    return View(piece);
        //}

        // POST: Pieces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,BusinessTripId,ColorId,MainCategoryId,GroupId,ComponentsId,CountryOfOriginId,BuyPrice,SellPrice,SupplierId,SizeId,OrderDate,EstimatedDateOfShipment,EstimatedTimeOfDelivery,Amount,CodeCnId,SetId,ColorNameId,ImageName")] Piece piece)
        //{
        //    if (id != piece.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(piece);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PieceExists(piece.Id))
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
        //    ViewData["BusinessTripId"] = new SelectList(_context.BusinessTrips, "Id", "Id", piece.BusinessTripId);
        //    ViewData["CodeCnId"] = new SelectList(_context.CodeCns, "Id", "Id", piece.CodeCnId);
        //    ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Id", piece.ColorId);
        //    ViewData["ColorNameId"] = new SelectList(_context.ColorNames, "Id", "Id", piece.ColorNameId);
        //    ViewData["CountryOfOriginId"] = new SelectList(_context.CountryOfOrigin, "Id", "Id", piece.CountryOfOriginId);
        //    ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", piece.GroupId);
        //    ViewData["MainCategoryId"] = new SelectList(_context.MainCategories, "Id", "Id", piece.MainCategoryId);
        //    ViewData["SetId"] = new SelectList(_context.Sets, "Id", "Id", piece.SetId);
        //    ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", piece.SizeId);
        //    ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", piece.SupplierId);
        //    return View(piece);
        //}

        // GET: Pieces/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var piece = await _context.Pieces
        //        .Include(p => p.BusinessTrip)
        //        .Include(p => p.CodeCn)
        //        .Include(p => p.Color)
        //        .Include(p => p.ColorName)
        //        .Include(p => p.CountryOfOrigin)
        //        .Include(p => p.Group)
        //        .Include(p => p.MainCategory)
        //        .Include(p => p.Set)
        //        .Include(p => p.Supplier)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (piece == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(piece);
        //}

        //private bool PieceExists(int id)
        //{
        //    return _context.Pieces.Any(e => e.Id == id);
        //}
    }
}
