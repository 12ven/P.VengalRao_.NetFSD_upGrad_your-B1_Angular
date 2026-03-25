using System;

namespace GovtRulesDemo
{
    public interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    public class Accenture : GovtRules
    {
        private int empId;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId => empId;
        public string Name => name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double employeeContribution = 0.12 * basicSalary;
            double employerContribution = 0.12 * basicSalary;
            Console.WriteLine($"Employee Contribution: {employeeContribution}");
            Console.WriteLine($"Employer Contribution: {employerContribution}");
            return employeeContribution + employerContribution;
        }

        public string LeaveDetails()
        {
            return "Accenture Leave Policy:\n" +
                   "2 days Casual Leave per month\n" +
                   "5 days Sick Leave per year\n" +
                   "5 days Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; // Not applicable
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accenture emp = new Accenture(102, "Priya", "HR", "Manager", 60000);
            Console.WriteLine($"Employee: {emp.Name}, Dept: {emp.Dept}, Desg: {emp.Desg}, Salary: {emp.BasicSalary}");
            Console.WriteLine(emp.LeaveDetails());
            Console.WriteLine("PF Total: " + emp.EmployeePF(emp.BasicSalary));
            Console.WriteLine("Gratuity: " + emp.GratuityAmount(8, emp.BasicSalary));
        }
    }
}