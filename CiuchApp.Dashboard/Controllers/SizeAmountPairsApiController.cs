﻿using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Services;

namespace CiuchApp.Dashboard
{
    [Route("api/SizeAmountPairs")]
    public class SizeAmountPairsApiController : CiuchAppBaseApiController<SizeAmountPair>
    {
        public SizeAmountPairsApiController(ICrudService<SizeAmountPair> serviceProvider, ILogger<SizeAmountPair> logger) : base(serviceProvider, logger)
        {
        }
    }
}