using Microsoft.AspNetCore.Mvc;
using System;

namespace SbrCoreRestApiWithSwaggerAndCors.Controllers
{
    /// <summary>
    /// Sample class that can be removed
    /// </summary>
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }

    /// <summary>
    /// Sample controller
    /// </summary>
    [ApiController]
    [Route("api/sample")]
    public class SampleController : ControllerBase
    {
        /// <summary>
        /// A sample method that can be removed
        /// </summary>
        [HttpGet()]
        public IActionResult GetSample()
        {
            return Ok(new Sample
            {
                Id = 100,
                Name = "Sample Data",
                Created = DateTime.Now.Date
            });
        }
    }
}
