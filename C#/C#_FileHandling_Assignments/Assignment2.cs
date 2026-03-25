using System;
using System.IO;

class StudentReportCard
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Report Card Generator ---");
            Console.WriteLine("1. Generate Report Card");
            Console.WriteLine("2. View Report Card");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GenerateReportCard();
                    break;
                case "2":
                    ViewReportCard();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void GenerateReportCard()
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            string rollNumber = Console.ReadLine();

            int[] marks = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter marks for Subject {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0 || marks[i] > 100)
                {
                    Console.WriteLine("Invalid marks! Please enter a number between 0 and 100.");
                    return;
                }
            }

            int total = marks[0] + marks[1] + marks[2];
            double average = total / 3.0;
            string grade;

            if (average >= 75) grade = "A";
            else if (average >= 60) grade = "B";
            else if (average >= 40) grade = "C";
            else grade = "Fail";

            string report = $"Student Name: {name}\n" +
                            $"Roll Number: {rollNumber}\n" +
                            $"Marks: {marks[0]}, {marks[1]}, {marks[2]}\n" +
                            $"Total: {total}\n" +
                            $"Average: {average:F2}\n" +
                            $"Grade: {grade}";

            File.WriteAllText($"{rollNumber}.txt", report);

            Console.WriteLine("Report card generated successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ViewReportCard()
    {
        try
        {
            Console.Write("Enter Roll Number to view report: ");
            string rollNumber = Console.ReadLine();

            string fileName = $"{rollNumber}.txt";

            if (File.Exists(fileName))
            {
                string report = File.ReadAllText(fileName);
                Console.WriteLine("\n--- Report Card ---");
                Console.WriteLine(report);
            }
            else
            {
                Console.WriteLine("Report card not found for this Roll Number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}