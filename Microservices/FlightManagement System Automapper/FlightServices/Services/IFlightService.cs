using Flight.FlightServices.Entitity;
using Flight.FlightServices.Dtos;

namespace Flight.FlightServices.Services
{
    public interface IFlightService
    {
        Task CreateFlightServiceAsync(CreateFlightServiceDto createDto);
        Task<List<ReadFlightServiceDto>> GetFlightServicesAsync();
        Task<ReadFlightServiceDto> GetFlightServiceByIdAsync(int FlightServiceId);
    }
}
