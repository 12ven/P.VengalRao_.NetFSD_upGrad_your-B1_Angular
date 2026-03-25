using System;
using System.IO;

class MiniNotepad
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Mini Notepad ---");
            Console.WriteLine("1. Create New File");
            Console.WriteLine("2. Write to File");
            Console.WriteLine("3. Read File");
            Console.WriteLine("4. Append Text");
            Console.WriteLine("5. Delete File");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateFile();
                    break;
                case "2":
                    WriteToFile();
                    break;
                case "3":
                    ReadFile();
                    break;
                case "4":
                    AppendToFile();
                    break;
                case "5":
                    DeleteFile();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateFile()
    {
        try
        {
            Console.Write("Enter file name (with .txt): ");
            string fileName = Console.ReadLine();

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                Console.WriteLine("File created successfully.");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Unauthorized access.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void WriteToFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                Console.WriteLine("Enter text (type 'END' to finish):");
                string line;
                while ((line = Console.ReadLine()) != "END")
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("File written successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Unauthorized access.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ReadFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();

            using (StreamReader sr = new StreamReader(fileName))
            {
                Console.WriteLine("\n--- File Content ---");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Unauthorized access.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void AppendToFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                Console.WriteLine("Enter text to append (type 'END' to finish):");
                string line;
                while ((line = Console.ReadLine()) != "END")
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("Text appended successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Unauthorized access.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void DeleteFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("File deleted successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Unauthorized access.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}