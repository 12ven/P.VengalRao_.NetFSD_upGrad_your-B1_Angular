using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class Hospital
    {
        public static string HospitalName="Yashoda";
        public static string HospitalAddress="Hyderabad";
        public string PatientName;

        
        public void Details()
        {
            Console.WriteLine($"HospialName : {Hospital.HospitalName}");
            Console.WriteLine($"HospitalAddress : {Hospital.HospitalAddress}");
            Console.WriteLine($"PatientName : {PatientName}");
            Console.WriteLine();

        }
    }
    internal class Assignment3
    {
        static void Main()
        {
            Hospital h1 = new Hospital();
            Hospital h2 = new Hospital();
            Hospital h3 = new Hospital();

            h1.PatientName = "Vengal";
            h2.PatientName = "Nithin";
            h3.PatientName = "Srikanth";
            h1.Details();
            h2.Details();
            h3.Details();


        }
    }
}
