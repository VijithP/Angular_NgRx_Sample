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
    public class CustomerController : ControllerBase
    {

        // private readonly ILogger<ICustomerService> _logger;

        // public CustomerController(ILogger<ICustomerService> logger)
        // {
        //     _logger = logger;
        // }



        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("SaveCustomer")]
        public IActionResult SaveCustomerDetails([FromBody] Customer customer)
        {
            string result = _customerService.SaveCustomer(customer);
            return Ok();


        }



        [HttpGet("GetCustomer")]
        public IEnumerable<Customer> GetCustomerDetails()
        {
            // var customersList = _customerService.GetAllCustomer();
            // return Ok(customersList);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Customer
            {
                id=index.ToString(),
                CustomerID = index,
                Name = "Name "+index.ToString(),
                Address = "Address" + index.ToString()
            })
            .ToArray();

        }


        [HttpDelete("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomerDetails(int id)
        {
            string result=_customerService.DeleteCustomer(id);
            return Ok("Customer is Deleted");
        }


        [HttpGet("ShowCustomer/{id}")]
        public IActionResult ShowCustomerDetails(int id)
        {           
            var result=_customerService.GetAllCustomerByID(id);
            return Ok(result);
        }



    }
}