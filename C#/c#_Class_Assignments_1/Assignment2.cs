using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class Doctor
    {
        public int DoctorId;
        public string DoctorName;
        public string Specification;
        public decimal ConstulationFee;

        public void Details()
        {
            Console.WriteLine($"DoctorId : {DoctorId}");
            Console.WriteLine($"DoctorName : {DoctorName}");
            Console.WriteLine($"Specification: {Specification}");
            Console.WriteLine($"ConstulationFee : {ConstulationFee}");
            Console.WriteLine();
        }
    }
    internal class Assignment2
    {
        static void Main()
        {
            Doctor d1 = new Doctor();
            Doctor d2 = new Doctor();

            d1.DoctorId = 1;
            d1.DoctorName = "Vengal";
            d1.Specification = "Heart";
            d1.ConstulationFee = 300;

            d2.DoctorId = 2;
            d2.DoctorName = "Nithin";
            d2.Specification = "Skin";
            d2.ConstulationFee = 500;

            d1.Details();
            d2.Details();
        }
    }
}
