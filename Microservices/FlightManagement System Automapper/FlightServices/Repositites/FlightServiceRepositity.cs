using Flight.FlightServices.Data;
using Flight.FlightServices.Entitity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Flight.FlightServices.Repositites
{
    public class FlightServiceRepositity : IFlightServiceRepositity
    {
        private readonly FlightServicesDb _context;

        public FlightServiceRepositity(FlightServicesDb context)
        {
            _context = context;
        }

        public async Task CreateFlightServiceAsync(FlightService flightService)
        {
            _context.FlightServices.Add(flightService);
            await _context.SaveChangesAsync();

        }



        public async Task<FlightService> GetFlightServiceByIdAsync(int FlightServiceId)
        {
            return await _context.FlightServices.FindAsync(FlightServiceId);

        }

        public async Task<List<FlightService>> GetFlightServicesAsync()
        {
            return await _context.FlightServices.ToListAsync();
        }
    }
}
