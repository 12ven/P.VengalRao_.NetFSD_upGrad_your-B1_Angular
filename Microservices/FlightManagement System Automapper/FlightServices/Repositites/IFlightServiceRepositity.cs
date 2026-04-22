using Flight.FlightServices.Entitity;
namespace Flight.FlightServices.Repositites
{
    public interface IFlightServiceRepositity
    {
        Task CreateFlightServiceAsync(FlightService flightService);
        Task<List<FlightService>> GetFlightServicesAsync();
        Task<FlightService> GetFlightServiceByIdAsync(int FlightServiceId);
    }
}
