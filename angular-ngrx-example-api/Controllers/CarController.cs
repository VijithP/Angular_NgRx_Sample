using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using angular_ngrx_example_api.Services;

namespace angular_ngrx_example_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        // private readonly ILogger<CarController> _logger;

        // public CarController(ILogger<CarController> logger)
        // {
        //     _logger = logger;
        // }

        // [HttpGet]
        // public IEnumerable<Car> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new Car
        //     {
        //         id = index,
        //         make = "Make "+index.ToString(),
        //         model = "model" + index.ToString(),             
        //         year = 2020,
        //         color="Red",
        //         price=2000
        //     })
        //     .ToArray();
        // }


        /////////////////////////////////




        
        private ICarService _CarService;
        public CarController(ICarService CarService)
        {
            _CarService = CarService;
        }

        [HttpPost]
        public IActionResult PostCarDetails(Car Car)
        {
            string result = _CarService.SaveCar(Car);
            return Ok();


        }



        public IEnumerable<Car> GetCarDetails()
        {
            var CarsList = _CarService.GetAllCar();
            return CarsList;


        }


        [HttpDelete("DeleteCar/{carid}")]
        public IActionResult DeleteCarDetails(int carid)
        {
            string result=_CarService.DeleteCar(carid);
            return Ok("Car is Deleted");
        }


        [HttpGet("ShowCar/{id}")]
        public IActionResult ShowCarDetails(int id)
        {           
            var result=_CarService.GetAllCarByID(id);
            return Ok(result);
        }







    }
}
