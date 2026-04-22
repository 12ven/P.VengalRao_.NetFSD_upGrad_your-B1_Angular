
using Flight.FlightServices.Data;
using Flight.FlightServices.Repositites;
using Microsoft.EntityFrameworkCore;

namespace FlightServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionstring = builder.Configuration.GetConnectionString("FlightServiceDb");
            builder.Services.AddDbContext<FlightServicesDb>
                (options => options.UseSqlServer(connectionstring));

            builder.Services.AddTransient<Flight.FlightServices.Services.IFlightService, Flight.FlightServices.Services.FlightServices>();
            builder.Services.AddTransient<Flight.FlightServices.Repositites.IFlightServiceRepositity, Flight.FlightServices.Repositites.FlightServiceRepositity>();


            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(cfg => { }, AppDomain.CurrentDomain.GetAssemblies());
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
