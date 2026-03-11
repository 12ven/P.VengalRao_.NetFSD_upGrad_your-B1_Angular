using System;
namespace c__Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter secong number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                int result = num1 / num2;
                Console.WriteLine($"Quotient of two numbers is {result}");
            }

        }
    }
}
