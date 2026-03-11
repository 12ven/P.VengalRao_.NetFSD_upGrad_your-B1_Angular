using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class ConvertKmIntoM
    {
        static void Main()
        {
            Console.WriteLine("Enter the km: ");
            decimal km = decimal.Parse(Console.ReadLine());
            int result = (int)(km * 1000);
            Console.WriteLine($"{km} km is equal to {result} meters ");
        }
    }
}
