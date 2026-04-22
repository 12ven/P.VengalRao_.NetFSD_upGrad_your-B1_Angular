namespace Flight.FlightServices.Dtos
{
    public class CreateFlightServiceDto
    {
        public int FlightNumber { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
    }

}
