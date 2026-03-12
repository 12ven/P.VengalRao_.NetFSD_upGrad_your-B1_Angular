using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class MedicalTest
    {
        public int TestId;
        public string TestName;
        public int TestCost;

        public MedicalTest(int TestId, string TestName, int TestCost)
        {
            this.TestId = TestId;
            this.TestName = TestName;
            this.TestCost = TestCost;
        }

        public void Details()
        {
            Console.WriteLine($"TestId : {TestId}");
            Console.WriteLine($"TestName : {TestName}");
            Console.WriteLine($"TestCost : {TestCost}");
            Console.WriteLine();
        }

    }
    internal class Assignment5
    {
        static void Main()
        {
            MedicalTest test1 = new MedicalTest(1, "Blood Test", 300);
            MedicalTest test2 = new MedicalTest(2, "X-Ray", 500);

            test1.Details();
            test2.Details();
        }
    }
}
