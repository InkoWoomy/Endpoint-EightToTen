using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Endpoint_EightToTen.Services.Mini8;

namespace Endpoint_EightToTen.Controllers
{
    [Route("[controller]")]
    public class Mini8Controller : Controller
    {
        private readonly IMini8Service _logger;

        public Mini8Controller(IMini8Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini8-8Ball/{question}")]
        public string EightBall (string question)
        {
            return _logger.EightBall(question);
        }

    }
}