using AutoMapper;
using Flight.FlightServices.Dtos;
using Flight.FlightServices.Entitity;
using Flight.FlightServices.Repositites;
namespace Flight.FlightServices.Services
{
    public class FlightServices : IFlightService
    {
        private readonly IFlightServiceRepositity _flightRepositity;
        private readonly IMapper _mapper;

        public FlightServices(IFlightServiceRepositity flightServiceRepositity, IMapper mapper = null)
        {
            _flightRepositity = flightServiceRepositity;
            _mapper = mapper;

        }

        public async Task CreateFlightServiceAsync(CreateFlightServiceDto createDto)
        {
            var flight = _mapper.Map<FlightService>(createDto);
            await _flightRepositity.CreateFlightServiceAsync(flight);
        }

        public async Task<ReadFlightServiceDto> GetFlightServiceByIdAsync(int FlightServiceId)
        {
            var flight = await _flightRepositity.GetFlightServiceByIdAsync(FlightServiceId);
            return _mapper.Map<ReadFlightServiceDto>(flight);

        }

        public async Task<List<ReadFlightServiceDto>> GetFlightServicesAsync()
        {
            var flight = await _flightRepositity.GetFlightServicesAsync();
            var dto = _mapper.Map<List<ReadFlightServiceDto>>(flight);
            return dto;
        }
    }
}
