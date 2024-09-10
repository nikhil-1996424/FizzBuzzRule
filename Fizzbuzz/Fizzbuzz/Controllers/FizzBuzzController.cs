using Microsoft.AspNetCore.Mvc;

namespace Fizzbuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuzzFizzController : ControllerBase
    {
       
        private readonly ICalculation _calculation;

        public BuzzFizzController(ICalculation calculation)
        {           
            _calculation = calculation;
        }

       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the default endpoint!");
        }

        [HttpPost("{Calculation}")]
        public string Calculation(object[] model)
        {
            var result1 = _calculation.GetCalculationResults(model);
            return result1; ;
        }

        [HttpGet("{Calculation}")]
        public string Calculation()
        {
            return "Invalid Terms ";
        }
    }
}
