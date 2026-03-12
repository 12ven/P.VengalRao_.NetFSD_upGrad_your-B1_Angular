using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class ProductSum
    {
        static void Main()
        {
            double price1 = 22.5, price2 = 44.50, price3 = 9.98, total = 0.0;
            Console.WriteLine("Enter how many sales entries you want to input: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEntry {i + 1}:");
                Console.WriteLine("Enter product number (1, 2, or 3): ");
                int productNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter quantity sold: ");
                int quantity = int.Parse(Console.ReadLine());

                switch (productNumber)
                {
                    case 1:
                        total += price1 * quantity;
                        break;
                    case 2:
                        total += price2 * quantity;
                        break;
                    case 3:
                        total += price3 * quantity;
                        break;
                    default:
                        Console.WriteLine("Invalid product number! Skipping entry.");
                        break;
                }

            }
            Console.WriteLine("\nTotal Price: " + total);

        }
    }
}
