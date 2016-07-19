using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/api/echo")]
    public class EchoController
    {

        [HttpGet("{echoString}")]
        public IActionResult Get(string echoString)
        {
            return new OkObjectResult(echoString);
        }
    }
}
