using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Divisible7
    {
        static void Main()
        {
            int first = 200, last = 300;
            for(int i = first; i <= last; i++)
            {
                if (i % 7 == 0)
                    Console.Write(i+" ");

            }
        }
    }
}
