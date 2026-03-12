using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class sixmethods
    {
        static void Main()
        {
            Console.WriteLine("Enter 10 numbers: ");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
                num[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += num[i];
            Console.WriteLine($"Total of 10 numbers is {sum}");
            double avg = (double)sum / 10;
            Console.WriteLine($"Avg of 10 numbers is {avg}");
            int min = num.Min();
            Console.WriteLine($"Min of 10 numbers is {min}");
            int max = num.Max();
            Console.WriteLine($"Max of 10 numbers is {max}");
            Array.Sort(num);
            Console.WriteLine("Ascending order of 10 numbers is "+String.Join(", ",num));
            Array.Reverse(num);
            Console.WriteLine("Descending order of 10 numbers is "+String.Join(", ",num));

        }
    }
}
