﻿using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    [Route("api/TopCategories")]
    [ApiController]
    public class TopCategoriesApiController : CiuchAppBaseApiAsyncController<TopCategory>
    {
        public TopCategoriesApiController(ICrudService<TopCategory> service, ILogger<TopCategory> logger) : base(service, logger)
        {
        }
    }
}