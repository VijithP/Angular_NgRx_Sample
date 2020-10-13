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
    public class LoanController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<LoanController> _logger;

        public LoanController(ILogger<LoanController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Loan> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new Loan
            {
                id = index,
                loanNumber=index,
                name = "Name "+index.ToString(),
                email = "Description" + index.ToString(),
                phoneNumber="Phone "+index.ToString()
            })
            .ToArray();
        }
        
        [HttpGet("GetLoan")]
        public IEnumerable<Loan> GetLoan(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new Loan
            {
                id = id,
                loanNumber=id,
                name = "Name "+id.ToString(),
                email = "Description " + id.ToString(),
                phoneNumber="Phone "+id.ToString()
            })
            .ToArray();
        }



        [HttpGet("ValidateUser")]
        public string[] ValidateUser(string userName)
        {

            string[] userNameList=new string[1];
            string result=( userName=="vijith")?"succes":"failed";
            userNameList[0]=result;
            return userNameList;

        }


    }
}
