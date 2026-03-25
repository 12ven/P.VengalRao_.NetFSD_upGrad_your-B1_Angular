namespace C__Collections_Assignments
{
    internal class Assignment2
    {

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Marks: {Marks}";
            }
        }

        class Program
        {
            static void Main()
            {
                Dictionary<int, Student> students = new Dictionary<int, Student>();

                // Add 5 students
                students.Add(1, new Student { Id = 1, Name = "Alice", Marks = 85 });
                students.Add(2, new Student { Id = 2, Name = "Bob", Marks = 72 });
                students.Add(3, new Student { Id = 3, Name = "Charlie", Marks = 90 });
                students.Add(4, new Student { Id = 4, Name = "David", Marks = 65 });
                students.Add(5, new Student { Id = 5, Name = "Eva", Marks = 78 });

                Console.WriteLine("--- All Students ---");
                foreach (var s in students.Values)
                    Console.WriteLine(s);

                Console.WriteLine("\n--- Retrieve Student by Id (3) ---");
                if (students.ContainsKey(3))
                    Console.WriteLine(students[3]);

                Console.WriteLine("\n--- Check if Student Exists (Id = 6) ---");
                Console.WriteLine(students.ContainsKey(6) ? "Student exists" : "Student not found");

                Console.WriteLine("\n--- Update Marks of Student (Id = 2) ---");
                if (students.ContainsKey(2))
                {
                    students[2].Marks = 80;
                    Console.WriteLine("Updated: " + students[2]);
                }

                Console.WriteLine("\n--- Remove Student (Id = 4) ---");
                students.Remove(4);
                foreach (var s in students.Values)
                    Console.WriteLine(s);

                Console.WriteLine("\n--- Students Scoring Above 75 ---");
                var toppers = students.Values.Where(s => s.Marks > 75);
                foreach (var s in toppers)
                    Console.WriteLine(s);
            }
        }
    }
}
