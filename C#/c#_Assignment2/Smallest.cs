using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Smallest
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers");
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
            //int smallest = numbers[0];
            //for (int i = 0; i < 5; i++)
            //{
            //    if (numbers[i] < smallest)
            //    {
            //        smallest = numbers[i];
            //    }

            //}
            //Console.WriteLine($"Smallest of five number is {smallest}");
        }
    }
}
