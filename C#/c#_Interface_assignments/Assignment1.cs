namespace c__Interface_assignments
{
    public interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    public class TCS : GovtRules
    {
        private int empId;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;

        public TCS(int empId, string name, string dept, string desg, double basicSalary)
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
            double employerContribution = 0.0833 * basicSalary;
            double pensionFund = 0.0367 * basicSalary;
            Console.WriteLine($"Employee Contribution: {employeeContribution}");
            Console.WriteLine($"Employer Contribution: {employerContribution}");
            Console.WriteLine($"Pension Fund: {pensionFund}");
            return employeeContribution + employerContribution;
        }

        public string LeaveDetails()
        {
            return "TCS Leave Policy:\n" +
                   "1 day Casual Leave per month\n" +
                   "12 days Sick Leave per year\n" +
                   "10 days Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return basicSalary;
            else
                return 0;
        }
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
            double employeeContribution = 0.10 * basicSalary;
            double employerContribution = 0.10 * basicSalary;
            Console.WriteLine($"Employee Contribution: {employeeContribution}");
            Console.WriteLine($"Employer Contribution: {employerContribution}");
            return employeeContribution + employerContribution;
        }

        public string LeaveDetails()
        {
            return "Accenture Leave Policy:\n" +
                   "2 days Casual Leave per month\n" +
                   "10 days Sick Leave per year\n" +
                   "15 days Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 15)
                return 2.5 * basicSalary;
            else if (serviceCompleted > 7)
                return 1.5 * basicSalary;
            else
                return 0;
        }
    }

    class Assignment1
    {
        static void Main(string[] args)
        {
            TCS emp1 = new TCS(101, "Ravi", "IT", "Developer", 50000);
            Console.WriteLine($"Employee: {emp1.Name}, Dept: {emp1.Dept}, Desg: {emp1.Desg}, Salary: {emp1.BasicSalary}");
            Console.WriteLine(emp1.LeaveDetails());
            Console.WriteLine("PF Total: " + emp1.EmployeePF(emp1.BasicSalary));
            Console.WriteLine("Gratuity: " + emp1.GratuityAmount(12, emp1.BasicSalary));

            Console.WriteLine("\n----------------------\n");

            Accenture emp2 = new Accenture(102, "Priya", "HR", "Manager", 60000);
            Console.WriteLine($"Employee: {emp2.Name}, Dept: {emp2.Dept}, Desg: {emp2.Desg}, Salary: {emp2.BasicSalary}");
            Console.WriteLine(emp2.LeaveDetails());
            Console.WriteLine("PF Total: " + emp2.EmployeePF(emp2.BasicSalary));
            Console.WriteLine("Gratuity: " + emp2.GratuityAmount(8, emp2.BasicSalary));
        }
    }
}