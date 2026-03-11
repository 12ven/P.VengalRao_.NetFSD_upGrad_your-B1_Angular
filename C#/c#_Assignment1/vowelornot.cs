using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class vowelornot
    {
        static void Main()
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            if (input.Length < 3)
            {
                Console.WriteLine("Sting is too short to have thrid character");
            }
            else
            {
                char thirdchar = input[2];
                if ("aeiou".Contains(thirdchar) || "AEIOU".Contains(thirdchar))
                {
                    Console.WriteLine("It is a vowel");
                }
                else
                {
                    Console.WriteLine("it is a Constanct");
                }
            }
        }
    }
}
