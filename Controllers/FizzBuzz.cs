using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Models;
using FizzBuzz.Logic;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzz : ControllerBase
    {
        private readonly ILogger<FizzBuzzResponse> _logger;

        public FizzBuzz(ILogger<FizzBuzzResponse> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<FizzBuzzResponse> ProcessFizzBuzz([FromBody] IEnumerable<FizzBuzzInput> inputItems)
        {
            var fb = new FizzBuzzProcessor();
            IEnumerable<FizzBuzzResponse> x = fb.ProcessFizzBuzz(inputItems);

            return x;
        }
    }
}
