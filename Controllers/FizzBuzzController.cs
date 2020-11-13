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
    public class FizzBuzzController : ControllerBase
    {
        [HttpGet("fizzBuzzInputStr")]
        public ActionResult<IEnumerable<FizzBuzzResponse>> ProcessFizzBuzz(string fizzBuzzInputStr)
        {

            var fb = new FizzBuzzProcessor();
            IEnumerable<FizzBuzzResponse> x = fb.ProcessFizzBuzz(fizzBuzzInputStr);

            return Ok(x);
        }
    }
}
