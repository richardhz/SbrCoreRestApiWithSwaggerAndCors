using Microsoft.AspNetCore.Mvc;
using System;

namespace SbrCoreRestApiWithSwaggerAndCors.Controllers
{
    [ApiController]
    [Route("api/sample")]
    public class SampleController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetSample()
        {
            return Ok(new
            {
                Id = 100,
                Name = "Sample Data",
                Created = DateTime.Now.Date
            });
        }
    }
}
