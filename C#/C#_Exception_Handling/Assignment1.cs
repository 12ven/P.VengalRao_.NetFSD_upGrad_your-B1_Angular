using System;

namespace BankAccountDemo
{
    // Custom Exception
    public class CheckBalanceException : Exception
    {
        public CheckBalanceException(string message) : base(message) { }
    }

    public class BankAccount
    {
        public int AccountNumber { get; }
        public string Name { get; }
        public static double Balance { get; private set; } = 500; // minimum balance
        public string TransactionType { get; }
        public double TransactionAmount { get; }

        public BankAccount(int accountNumber, string name, string transactionType, double transactionAmount)
        {
            AccountNumber = accountNumber;
            Name = name;
            TransactionType = transactionType.ToLower();
            TransactionAmount = transactionAmount;
        }

        public void PerformTransaction()
        {
            if (TransactionType == "d") // deposit
            {
                Balance += TransactionAmount;
                Console.WriteLine($"Deposited: {TransactionAmount}, New Balance: {Balance}");
            }
            else if (TransactionType == "c") // credit/withdraw
            {
                if (Balance - TransactionAmount < 500)
                {
                    throw new CheckBalanceException("Balance cannot go below minimum limit of Rs.500!");
                }
                else
                {
                    Balance -= TransactionAmount;
                    Console.WriteLine($"Withdrawn: {TransactionAmount}, New Balance: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Use 'd' for deposit or 'c' for withdraw.");
            }
        }
    }

    class Assignment1
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount acc1 = new BankAccount(101, "Ravi", "d", 2000);
                acc1.PerformTransaction();

                BankAccount acc2 = new BankAccount(102, "Priya", "c", 1800);
                acc2.PerformTransaction(); // this will throw exception
            }
            catch (CheckBalanceException ex)
            {
                Console.WriteLine("Transaction Failed: " + ex.Message);
            }
        }
    }
}