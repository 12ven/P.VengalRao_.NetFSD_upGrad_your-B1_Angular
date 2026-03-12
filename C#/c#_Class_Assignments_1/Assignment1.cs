namespace c__Class_Assignments_1
{
    class Patient
    {
        public int PatientId;
        public string PatientName;
        public byte Age;
        public string Disease;

        
        public void Details()
        {
            Console.WriteLine($"PatientId : {PatientId}");
            Console.WriteLine($"PatientName : {PatientName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Disease : {Disease}");
        }
    }
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.PatientId = 101;
            p.PatientName = "Ravi Kumar";
            p.Age = 45;
            p.Disease = "Diabetes";
            p.Details();
        }
    }
}
