using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
        class Student
        {
            public long StudentId { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

            public Student(long studentId, string name, int marks)
            {
                StudentId = studentId;
                Name = name;
                Marks = marks;
            }

            public virtual string CalculateGrade()
            {
                if (Marks > 50)
                    return "Pass";
                else
                    return "Fail";
            }
        }

        class SchoolStudent : Student
        {
            public SchoolStudent(long studentId, string name, int marks) : base(studentId, name, marks) { }

            public override string CalculateGrade()
            {
                if (Marks > 40)
                    return "Pass";
                else
                    return "Fail";
            }
        }

        class CollegeStudent : Student
        {
            public CollegeStudent(long studentId, string name, int marks) : base(studentId, name, marks) { }

            public override string CalculateGrade()
            {
                if (Marks > 50)
                    return "Pass";
                else
                    return "Fail";
            }
        }

        class OnlineStudent : Student
        {
            public OnlineStudent(long studentId, string name, int marks) : base(studentId, name, marks) { }

            public override string CalculateGrade()
            {
                if (Marks > 60)
                    return "Pass";
                else
                    return "Fail";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new SchoolStudent(101, "Alice", 45);
                Student s2 = new CollegeStudent(102, "Bob", 55);
                Student s3 = new OnlineStudent(103, "Charlie", 65);

                Console.WriteLine($"{s1.Name} ({s1.StudentId}) Grade: {s1.CalculateGrade()}");
                Console.WriteLine($"{s2.Name} ({s2.StudentId}) Grade: {s2.CalculateGrade()}");
                Console.WriteLine($"{s3.Name} ({s3.StudentId}) Grade: {s3.CalculateGrade()}");

                Console.ReadLine();
            }
        }
    }


