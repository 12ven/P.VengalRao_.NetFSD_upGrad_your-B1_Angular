using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class PatientRecord
    {
        public static string HospitalName="Yashoda";
        public int PatientId;
        public string PatientName;
        public int Age;
        public string Disease;

        public PatientRecord(int PatientId, string PatientName, int Age, string Disease)
        {
            this.PatientId = PatientId;
            this.PatientName = PatientName;
            this.Age = Age;
            this.Disease = Disease;
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine($"PatientId : {PatientId}");
            Console.WriteLine($"PatientName : {PatientName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Disease : {Disease}");
            Console.WriteLine($"HospitalName : {PatientRecord.HospitalName}");
            Console.WriteLine();
        }
        

    }
    internal class Assignment8
    {
        static void Main()
        {
            PatientRecord patient1 = new PatientRecord(1, "Vengal", 23, "Skin");
            PatientRecord patient2 = new PatientRecord(2, "nithin", 24, "eyes");
            PatientRecord patient3 = new PatientRecord(3, "srikanth", 24, "heart");

            patient1.DisplayPatientRecord();
            patient2.DisplayPatientRecord();
            patient3.DisplayPatientRecord();
        }
    }
}
