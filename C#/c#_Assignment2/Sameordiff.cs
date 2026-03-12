using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Sameordiff
    {
        static void Main()
        {
            Console.WriteLine("Enter two words :");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word1 == word2)
                Console.WriteLine("Both are same");
            else
                Console.WriteLine("Both are Different");
        }
    }
}
