using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
    internal class Assignment2
    {
        
        public class Account
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }

            public void CalculateInterest()
            {

                Console.WriteLine("Base account interest calculation");
            }
        }

        public class SavingsAccount : Account
        {
            public new void CalculateInterest()
            {
                Console.WriteLine("Savings account interest calculation");
            }
        }

        public class CurrentAccount : Account
        {
            public new void CalculateInterest()
            {
                Console.WriteLine("Current account interest calculation");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Account acc = new SavingsAccount();
                acc.CalculateInterest();

                SavingsAccount savAcc = new SavingsAccount();
                savAcc.CalculateInterest();

                Account acc2 = new CurrentAccount();
                acc2.CalculateInterest();

                CurrentAccount curAcc = new CurrentAccount();
                curAcc.CalculateInterest();

                Console.ReadLine();
            }
        }
    }
}

