using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using CiuchApp.Settings;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace CiuchApp.Dashboard.Controllers.Base
{
    [Authorize]
    public abstract class CiuchAppBaseController<T> : Controller where T : CiuchAppBaseModel
    {
        protected readonly ICrudService<T> _service;
        private readonly ILogger<T> _logger;
        protected readonly ICiuchAppSettings _settings;
        protected readonly IDropdownServices _dropdownService;

        protected string IndexView { get; set; }
        protected string EditView { get; set; }
        protected string CreateView { get; set; }
        protected string DeleteView { get; set; }

        public CiuchAppBaseController(ICrudService<T> serviceProvider, ILogger<T> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices)
        {
            _service = serviceProvider;
            _logger = logger;
            _settings = settings;
            _dropdownService = dropdownServices;
        }


        // GET: BusinessTrips
        public IActionResult Index()
        {
            PrepareItemImages();
            return ResolveIndexView(_service.GetAll());
        }

        public IActionResult Edit(int id)
        {
            PrepareDropdownValues();
            return ResolveEditView(_service.GetById(id));
        }

        // POST: BusinessTrips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(int id, T item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(item);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;

                    //if (!BusinessTripExists(businessTrip.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }

            PrepareDropdownValues();
            return View(item);
        }

        public IActionResult Create()
        {
            PrepareDropdownValues();
            return ResolveCreateView();
        }

        [HttpPost]
        public IActionResult Create(T item)
        {
            if (ModelState.IsValid)
            {
                _service.Add(item);
                return RedirectToAction(nameof(Index));
            }
            PrepareDropdownValues();
            return ResolveCreateView(item);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _service.GetById(id);
            return ResolveDeleteView(model);
        }

        [HttpPost]
        public IActionResult Delete(T item)
        {
            _service.Delete(item);
            return Index();
        }


        protected virtual void PrepareDropdownValues()
        {
        }

        protected virtual void PrepareItemImages()
        {
        }

        protected IActionResult ResolveIndexView(IList<T> list) => IndexView != null ? View(IndexView, list) : View("Index", list);
        private IActionResult ResolveEditView(T item) => EditView != null ? View(EditView, item) : View(item);
        private IActionResult ResolveCreateView() => CreateView != null ? View(CreateView) : View();
        private IActionResult ResolveCreateView(T item) => CreateView != null ? View(CreateView, item) : View(item);
        private IActionResult ResolveDeleteView(object model)
        {
            if(DeleteView != null)
            {
                return View(DeleteView, model);
            }
            else
            {
                return View(model);
            }
        }
    }
}