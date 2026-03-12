using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class numbersBetween
    {
        static void Main(string[] args)
        {
            if (args.Length < 2){
                Console.WriteLine("Enter two numbers");

            }
            else
            {
                int num1 = int.Parse(args[0]);
                int num2 = int.Parse(args[1]);

                Console.WriteLine($"Number between {num1} and {num2} are :");
                for(int i = num1+1; i < num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
