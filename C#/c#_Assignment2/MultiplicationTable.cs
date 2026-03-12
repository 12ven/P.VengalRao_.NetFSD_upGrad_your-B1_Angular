using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class MultiplicationTable
    {
        static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }
        }
    }
}
