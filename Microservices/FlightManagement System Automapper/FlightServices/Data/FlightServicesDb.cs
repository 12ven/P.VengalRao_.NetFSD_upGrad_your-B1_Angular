using Flight.FlightServices.Entitity;
using Microsoft.EntityFrameworkCore;
namespace Flight.FlightServices.Data
{
    public class FlightServicesDb : DbContext
    {
        public FlightServicesDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<FlightService> FlightServices { get; set; }

    }
}
