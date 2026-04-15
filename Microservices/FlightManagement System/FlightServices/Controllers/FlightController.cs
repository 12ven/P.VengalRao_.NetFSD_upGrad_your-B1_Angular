using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private static List<object> flights = new List<object>
        {
            new { Id = 1, FlightNumber = "AI101", Source = "Hyderabad", Destination = "Delhi" },
            new { Id = 2, FlightNumber = "AI202", Source = "Chennai", Destination = "Mumbai" }
        };

        [HttpGet("GetFlights")]

        public IActionResult GetAll()
        {
            return Ok(flights);
        }

        [HttpGet("Get/{id}")]

        public IActionResult Get(int id)
        {
            var flight = flights.FirstOrDefault(f => (int)f.GetType().GetProperty("Id").GetValue(f) == id);
            return Ok(flights);
        }

        [HttpPost("AddFlight")]

        public IActionResult Insert([FromBody] object flight)
        {
            flights.Add(flight);
            return Ok(flights);
        }


    }
}
