using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class Area
    {
        static void Main()
        {
            Console.WriteLine("Enter the length and breadth of reactangle : ");
            int length = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side of the square : ");
            int side = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area of rectangle is {length * breadth}");
            Console.WriteLine($"Area of square id {side * side}");
        }
    }
}
