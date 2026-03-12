using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Series
    {
        static void Main()
        {
            for(int i = 0; i <=25; i++)

            {
                if (i == 25)
                
                    Console.Write(i * i);

                else
                    Console.Write(i * i + ",");
                
            }
        }
    }
}
