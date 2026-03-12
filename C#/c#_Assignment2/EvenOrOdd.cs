using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class EvenOrOdd
    {
        static void Main()
        {
            Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is a even number");
            }
            else
            {
                Console.WriteLine($"{number} is a odd number");
            }
        }
    }
}
