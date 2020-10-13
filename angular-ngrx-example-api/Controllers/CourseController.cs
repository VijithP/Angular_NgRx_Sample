using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace angular_ngrx_example_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Course
            {
                id = index.ToString(),
                name = "Name "+index.ToString(),
                description = "Description" + index.ToString()
            })
            .ToArray();
        }




    }
}
