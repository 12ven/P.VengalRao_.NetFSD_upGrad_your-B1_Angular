using System;
using System.IO;

class EmployeeLogSystem
{
    static string filePath = "employee_log.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Employee Log Management ---");
            Console.WriteLine("1. Add Login Entry");
            Console.WriteLine("2. Update Logout Time");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice= Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddLoginEntry();
                    break;
                case "2":
                    UpdateLogoutTime();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddLoginEntry()
    {
        try
        {
            Console.Write("Enter Employee ID: ");
            string empId = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            string loginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{empId} | {name} | {loginTime} | ");
            }

            Console.WriteLine("Login entry added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void UpdateLogoutTime()
    {
        try
        {
            Console.Write("Enter Employee ID to update logout: ");
            string empId = Console.ReadLine();

            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(empId + " "))
                {
                    string[] parts = lines[i].Split('|');
                    if (parts.Length >= 4)
                    {
                        parts[3] = " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        lines[i] = string.Join("|", parts);
                        updated = true;
                        break;
                    }
                }
            }

            if (updated)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Logout time updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}