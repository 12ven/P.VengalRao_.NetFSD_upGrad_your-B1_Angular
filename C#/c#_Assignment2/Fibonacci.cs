using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Fibonacci
    {
        static void Main()
        {
            int first = 0, second = 1, next;
            Console.WriteLine("Fibonacci series till 40");
            Console.Write(first + "," + second);

            while (true)
            {
                next = first + second;
                if (next > 40)
                    break;
                Console.Write("," + next);
                first = second;
                second = next;

            }
        }
    }
}
