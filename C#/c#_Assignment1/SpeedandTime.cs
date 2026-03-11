using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class SpeedandTime
    { 
        static void Main()
        {
            Console.WriteLine("Enter the distance : ");
            decimal distance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Speed : ");
            decimal speed = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The time taken to travel is {distance / speed}");
        }
    }
}
