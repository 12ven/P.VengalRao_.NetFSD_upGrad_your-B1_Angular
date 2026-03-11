using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class SumAndAvg
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            float avg = sum / 5;
            Console.WriteLine($"Sum of five numbers is : {sum}");
            Console.WriteLine($"Avg of five numbers is : {avg}");

        }

    }
}
