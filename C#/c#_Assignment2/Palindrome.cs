using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment2
{
    internal class Palindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter the word : ");
            string word = Console.ReadLine();
            string rev = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }
            if (word == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindrome");
        }
    }
}
