using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class Appointment
    {
        public int AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Now;
        }

        public void Details()
        {
            Console.WriteLine($"AppointmentId : {AppointmentId}");
            Console.WriteLine($"PatientName : {PatientName}");
            Console.WriteLine($"DoctorName : {DoctorName}");
            Console.WriteLine($"AppointmentDate : {AppointmentDate.ToShortDateString()}");
            Console.WriteLine();
        }
    }
    internal class Assignment4
    {
        static void Main()
        {
            Appointment a1 = new Appointment();
            a1.AppointmentId = 1;
            a1.PatientName = "Vengal";

            a1.Details();
        }
    }
}
