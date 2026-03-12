using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class NoOfEvenOdd
    {
        static void Main()
        {
            int evenCount = 0, oddCount = 0;
            Console.WriteLine("Enter the number of even and odd");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter {i + 1} values");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"Even number count is {evenCount}");
            Console.WriteLine($"odd number count is {oddCount}");
        }
    }
}
