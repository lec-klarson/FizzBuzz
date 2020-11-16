using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FizzBuzz.Models;
using FizzBuzz.Logic;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FBController : ControllerBase
    {
        [HttpGet("get")]
        public ActionResult<IEnumerable<FizzBuzzResponse>> FBProcess(string inputStr)
        {
            var fb = new FizzBuzzProcessor();
            IEnumerable<FizzBuzzResponse> responses = fb.ProcessFizzBuzz(inputStr);

            if (responses == null)
            {
                return NoContent();
            }

            return Ok(responses);
        }
    }
}
