using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Endpoint_EightToTen.Services.Mini10;


namespace Endpoint_EightToTen.Controllers
{
    [Route("[controller]")]
    public class Mini10Controller : Controller
    {
        private readonly IMini10Service _logger;

        public Mini10Controller(IMini10Service logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Mini10-ResturauntPicker(pizza|fastfood|chinese)/{input}")]
        public string ResturauntPicker (string input)
        {
            return _logger.ResturauntPicker(input);
        }

    }
}