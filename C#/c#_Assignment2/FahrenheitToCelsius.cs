using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class FahrenheitToCelsius
    {
        static void Main()
        {
            Console.WriteLine("Enter the Fahernheit degree : ");
            double fahernheitDegree = double.Parse(Console.ReadLine());
            double result = (fahernheitDegree - 32) * (5.0 / 9.0);
            Console.WriteLine(result);
        }
    }
}
