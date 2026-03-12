using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Greeting
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Write the name");
            }
            else
            {
                string name = args[0];
                Console.WriteLine($"Hi! {name}\nWelcome to the world of C#");
            }
            

        }
    }
}
