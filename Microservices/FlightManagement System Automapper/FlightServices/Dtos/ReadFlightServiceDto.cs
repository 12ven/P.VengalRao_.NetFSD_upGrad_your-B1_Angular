namespace Flight.FlightServices.Dtos
{
    public class ReadFlightServiceDto
    {
        public int FlightServiceId { get; set; }
        public int FlightNumber { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
    }
}
