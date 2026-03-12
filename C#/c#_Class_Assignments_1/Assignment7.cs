using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class Nurse
    {
        public int NurseId { get; set; }
        public string NurseName { get; set; }
        public string Department { get; set; }
    }
    internal class Assignment7
    {
        static void Main()
        {
            Nurse n1 = new Nurse
            {
                NurseId = 1,
                NurseName = "Latha",
                Department = "Skin"
            };
           

            Console.WriteLine($"NurseId : {n1.NurseId}");
            Console.WriteLine($"NurseName : {n1.NurseName}");
            Console.WriteLine($"Department : {n1.Department}");
        }
    }
}
