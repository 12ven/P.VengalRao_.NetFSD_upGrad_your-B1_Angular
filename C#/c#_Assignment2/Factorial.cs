using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            if (num == 0)
                Console.WriteLine($"Factorial of {num} is 1.");
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
            }
            Console.WriteLine($"Factorial of {num} is {result}.");
        }
    }
}
