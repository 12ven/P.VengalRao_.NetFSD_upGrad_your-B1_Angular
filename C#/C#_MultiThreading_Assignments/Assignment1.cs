using System;
using System.Threading;

class ParallelNumberProcessing
{
    static int[] partialSums = new int[5]; // store results from threads

    static void Main()
    {
        int[] numbers = new int[50];
        for (int i = 0; i < 50; i++)
            numbers[i] = i + 1;

        Thread[] threads = new Thread[5];

        // Split into 5 parts
        for (int i = 0; i < 5; i++)
        {
            int start = i * 10;
            int end = start + 10;
            int threadIndex = i;

            threads[i] = new Thread(() => ProcessNumbers(numbers, start, end, threadIndex));
            threads[i].Start();
        }

        // Wait for all threads
        for (int i = 0; i < 5; i++)
        {
            threads[i].Join();
        }

        // Final sum
        int finalSum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {i + 1} Sum: {partialSums[i]}");
            finalSum += partialSums[i];
        }

        Console.WriteLine($"Final Sum: {finalSum}");
    }

    static void ProcessNumbers(int[] numbers, int start, int end, int threadIndex)
    {
        int sum = 0;
        Console.WriteLine($"Thread {threadIndex + 1} processing numbers:");

        for (int i = start; i < end; i++)
        {
            Console.Write(numbers[i] + " ");
            sum += numbers[i];
        }

        Console.WriteLine();
        partialSums[threadIndex] = sum;
    }
}