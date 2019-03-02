using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;
using CiuchApp.Domain;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.Base
{
    public abstract class CiuchAppBaseApiAsyncController<T> : ControllerBase where T : CiuchAppBaseModel
    {
        protected readonly ICrudService<T> _service;
        protected readonly ILogger<T> _logger;

        public CiuchAppBaseApiAsyncController(ICrudService<T> service, ILogger<T> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<T>>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        [HttpPost]
        public IActionResult Add([FromForm] T item) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.Add(item))
                return Ok(item.Id);

            return NotFound();
        }

        [HttpPut]
        public IActionResult Edit([FromForm] T item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.Update(item))
                return Ok();

            return NotFound();
        }
        [HttpDelete]
        public IActionResult Delete([FromForm] T item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.Delete(item))
                return Ok();

            return NotFound();
        }
    }
}