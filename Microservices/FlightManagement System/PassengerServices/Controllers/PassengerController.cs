using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PassengerServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private static List<object> passengers = new List<object>
        {
            new { PassengerId = 201, Name = "John", Age = 30 }
        };

        [HttpGet("GetPassengers")]

        public IActionResult GetAll()
        {
            return Ok(passengers);
        }

        [HttpPost("AddPassenger")]

        public IActionResult Insert([FromBody] object passenger)
        {
            passengers.Add(passenger);
            return Ok(passengers);
        }
    }
}
