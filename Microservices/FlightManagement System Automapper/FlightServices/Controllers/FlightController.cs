using Flight.FlightServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flight.FlightServices.Dtos;

namespace FlightServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> CreateFlightServiceAsync([FromBody]CreateFlightServiceDto createDto)
        {
            await _flightService.CreateFlightServiceAsync(createDto);
            return Ok("Added");
        }

        [HttpGet("Search/{id}")]

        public async Task<IActionResult> GetFlightServiceByIdAsync(int FlightServiceId)
        {
            var flight = await _flightService.GetFlightServiceByIdAsync(FlightServiceId);
            return Ok(flight);
        }

        [HttpGet("GetFlightServices")]
        public async Task<IActionResult> GetFlightServicesAsync()
        {
            var flight = await _flightService.GetFlightServicesAsync();
            return Ok(flight);

        }


    }
}
