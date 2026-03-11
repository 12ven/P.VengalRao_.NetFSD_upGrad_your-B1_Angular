using System;
using System.Collections.Generic;
using System.Text;

namespace c__Assignment1
{
    internal class GreaterofTwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2){
                Console.WriteLine("First Number is Greatest");
            }
            else
            {
                Console.WriteLine("SecondNumber is Greatest");
            }

        }
    }
}
