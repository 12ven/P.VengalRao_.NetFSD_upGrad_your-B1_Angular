using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment4
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }
        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started...");
        }
    }
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public void ShowCarDetails()
        {
            Console.WriteLine("Car Number: " + VehicleNumber);
            Console.WriteLine("Car Brand: " + Brand);
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }

    public class Bike : Vehicle
    {
        public void ShowBikeDetails()
        {
            Console.WriteLine("Bike Number: " + VehicleNumber);
            Console.WriteLine("Bike Brand: " + Brand);
        }
    }
    public sealed class ElectricCar : Car
    {
        public void ShowEletricCarInfo()
        {
            Console.WriteLine("This is Eletric Car");
        }
    }

    class Program
        {
        static void Main(string[] args)
        {
            Car car = new Car { VehicleNumber = "CAR123", Brand = "Toyota", FuelType = "Petrol" };
            car.StartVehicle();
            car.ShowCarDetails();

            Bike bike = new Bike { VehicleNumber = "BIKE456", Brand = "Honda" };
            bike.StartVehicle();
            bike.ShowBikeDetails();

            ElectricCar eCar = new ElectricCar { VehicleNumber = "ELEC789", Brand = "Tesla", FuelType = "Electric" };
            eCar.StartVehicle();
            eCar.ShowCarDetails();
            eCar.ShowEletricCarInfo();

            Console.ReadLine();
        }
    }

}

