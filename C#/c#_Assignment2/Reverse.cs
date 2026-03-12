
using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Reverse
    {
        static void Main()
        {
            Console.WriteLine("Enter the word : ");
            string word = Console.ReadLine();
            string rev = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                rev += word[i];
            }
            Console.WriteLine(rev);
        }
    }
}
