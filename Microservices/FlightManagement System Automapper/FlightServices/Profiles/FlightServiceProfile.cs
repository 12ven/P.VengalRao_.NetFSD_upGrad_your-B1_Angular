using AutoMapper;
using Flight.FlightServices.Dtos;
using Flight.FlightServices.Entitity;
namespace Flight.FlightServices.Profiles
{
    public class FlightServiceProfile:Profile
    {
        public FlightServiceProfile()
        {
            CreateMap<FlightService, ReadFlightServiceDto>();
            CreateMap<CreateFlightServiceDto, FlightService>();
            CreateMap<FlightService, ReadFlightServiceDto>();

        }
    }
}
