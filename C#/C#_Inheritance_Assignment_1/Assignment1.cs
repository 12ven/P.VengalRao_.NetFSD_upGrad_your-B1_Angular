
using static C__Inheritance_Assignment.Assignment1;

namespace C__Inheritance_Assignment
{
    internal class Assignment1
    {   
        public class Staff
        {
            public int staffId { get; set; }
            public string Name { get; set; }
            public double BaseSalary { get; set; }

            public virtual double CalculateSalary()
            {
                return BaseSalary;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Staff ID: {staffId}, Name: {Name}, Salary: {CalculateSalary()}");

            }

        }

        public class Doctor : Staff
        {
            public double ConsultationFee { get; set; }

            public override double CalculateSalary()
            {
                return BaseSalary + ConsultationFee;
            }
        }

        public class Nurse : Staff
        {
            public double NightShiftAllowance { get; set; }
            public override double CalculateSalary()
            {
                return BaseSalary+NightShiftAllowance;
            }

        }
        public class LabTechnician : Staff
        {
            public double EquipmentAllowance { get; set; }
            public override double CalculateSalary()
            {
                return BaseSalary + EquipmentAllowance;
            }
        }

        class program 
        {
            static void Main(String[] args)
            {
                Staff staff1 = new Doctor { staffId = 1, Name = "Dr. Vengal", BaseSalary = 50000, ConsultationFee = 15000 };
                Staff staff2 = new Nurse { staffId = 2, Name = "Nurse Malli", BaseSalary = 30000, NightShiftAllowance = 5000 };
                Staff staff3 = new LabTechnician { staffId = 3, Name = "Ravi", BaseSalary = 25000, EquipmentAllowance = 4000 };

                staff1.DisplayInfo();
                staff2.DisplayInfo();
                staff3.DisplayInfo();




            }
        }


    }
}
