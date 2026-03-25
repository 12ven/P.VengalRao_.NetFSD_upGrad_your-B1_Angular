namespace C__LINQ_Assignments
{
    internal class Assignment1
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Marks { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}";
            }
        }

        class Program
        {
            static void Main()
            {
                List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20, Marks = 85 },
            new Student { Id = 2, Name = "Bob", Age = 22, Marks = 65 },
            new Student { Id = 3, Name = "Charlie", Age = 18, Marks = 90 },
            new Student { Id = 4, Name = "David", Age = 26, Marks = 70 },
            new Student { Id = 5, Name = "Eva", Age = 24, Marks = 78 }
        };

                Console.WriteLine("--- Students with Marks > 75 ---");
                var highScorers = students.Where(s => s.Marks > 75);
                foreach (var s in highScorers)
                    Console.WriteLine(s);

                Console.WriteLine("\n--- Students with Age between 18 and 25 ---");
                var ageFiltered = students.Where(s => s.Age >= 18 && s.Age <= 25);
                foreach (var s in ageFiltered)
                    Console.WriteLine(s);

                Console.WriteLine("\n--- Students Sorted by Marks (Descending) ---");
                var sortedByMarks = students.OrderByDescending(s => s.Marks);
                foreach (var s in sortedByMarks)
                    Console.WriteLine(s);

                Console.WriteLine("\n--- Select Only Name and Marks ---");
                var nameMarks = students.Select(s => new { s.Name, s.Marks });
                foreach (var nm in nameMarks)
                    Console.WriteLine($"Name: {nm.Name}, Marks: {nm.Marks}");
            }
        }
    }
}
