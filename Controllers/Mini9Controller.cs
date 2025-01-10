using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Endpoint_EightToTen.Services.Mini9A;
using Endpoint_EightToTen.Services.Mini9B;
using Endpoint_EightToTen.Services.Mini9C;

namespace Endpoint_EightToTen.Controllers
{
    [Route("[controller]")]
    public class Mini9AController : Controller
    {
        private readonly IMini9AService _logger;

        public Mini9AController(IMini9AService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini9-GuessItEasy/{input}")]
        public string GuessItEasy (string input)
        {
            return _logger.GuessItEasy(input);
        }
    }
    
    [Route("[controller]")]
    public class Mini9BController : Controller
    {
        private readonly IMini9BService _logger;

        public Mini9BController(IMini9BService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini9-GuessItNormal/{input}")]
        public string GuessItNormal (string input)
        {
            return _logger.GuessItNormal(input);
        }
    }

    [Route("[controller]")]
    public class Mini9CController : Controller
    {
        private readonly IMini9CService _logger;

        public Mini9CController(IMini9CService logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini9-GuessItHard/{input}")]
        public string GuessItHard (string input)
        {
            return _logger.GuessItHard(input);
        }
    }

}