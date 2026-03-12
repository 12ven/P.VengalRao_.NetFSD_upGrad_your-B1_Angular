using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Largestofthree
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("All three are equal");
            else if (a >= b && a >= c)
            {
                Console.WriteLine("A is Largest");
            }
            else if (b >= a && b>=c)
                Console.WriteLine("B is Largest");
            else
                Console.WriteLine("C is Largest");
        }
    }
}
