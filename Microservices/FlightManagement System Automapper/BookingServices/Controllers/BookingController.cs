using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static List<object> bookings = new List<object>
        {
            new { BookingId = 101, FlightId = 1, PassengerId = 201 }
        };

        [HttpGet("GetBooking")]

        public IActionResult GetAll()
        {
            return Ok(bookings);
        }

        [HttpPost("AddBooking")]

        public IActionResult Insert([FromBody] object booking)
        {
            bookings.Add(booking);
            return Ok(booking);
        }
    }
}
