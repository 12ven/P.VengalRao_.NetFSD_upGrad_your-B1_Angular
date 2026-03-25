using System;
using System.Threading;

class BankAccount
{
    private int balance;
    private readonly object lockObj = new object(); // for synchronization

    public BankAccount(int initialBalance)
    {
        balance = initialBalance;
    }

    // Withdraw WITHOUT synchronization
    public void WithdrawUnsafe(int amount)
    {
        if (balance >= amount)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is withdrawing {amount}");
            balance -= amount;
            Console.WriteLine($"{Thread.CurrentThread.Name} completed withdrawal. Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} attempted withdrawal. Insufficient funds!");
        }
    }

    // Withdraw WITH synchronization
    public void WithdrawSafe(int amount)
    {
        lock (lockObj)
        {
            if (balance >= amount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is withdrawing {amount}");
                balance -= amount;
                Console.WriteLine($"{Thread.CurrentThread.Name} completed withdrawal. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} attempted withdrawal. Insufficient funds!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Bank Account Simulation ---");

        // Step 1: Run WITHOUT synchronization
        BankAccount account1 = new BankAccount(100);
        Thread t1 = new Thread(() => account1.WithdrawUnsafe(70)) { Name = "User1" };
        Thread t2 = new Thread(() => account1.WithdrawUnsafe(50)) { Name = "User2" };
        Thread t3 = new Thread(() => account1.WithdrawUnsafe(30)) { Name = "User3" };

        t1.Start(); t2.Start(); t3.Start();
        t1.Join(); t2.Join(); t3.Join();

        Console.WriteLine("\n--- Now with Synchronization (lock) ---");

        // Step 2: Run WITH synchronization
        BankAccount account2 = new BankAccount(100);
        Thread t4 = new Thread(() => account2.WithdrawSafe(70)) { Name = "User1" };
        Thread t5 = new Thread(() => account2.WithdrawSafe(50)) { Name = "User2" };
        Thread t6 = new Thread(() => account2.WithdrawSafe(30)) { Name = "User3" };

        t4.Start(); t5.Start(); t6.Start();
        t4.Join(); t5.Join(); t6.Join();
    }
}