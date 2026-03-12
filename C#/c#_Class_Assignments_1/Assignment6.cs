using System;
using System.Collections.Generic;
using System.Text;

namespace c__Class_Assignments_1
{
    class Billing
    {
        public string PatientName;
        public int ConsultationFee;
        public int TestCharges;

        public void TotalBill()
        {
            int totalBill = ConsultationFee + TestCharges;
            Console.WriteLine($"TotalBill : {totalBill}");
        }
    }
    internal class Assignment6
    {
        static void Main()
        {
            Billing bill = new Billing();
            bill.PatientName = "Vengal Rao";
            bill.ConsultationFee = 3000;
            bill.TestCharges = 400;

            bill.TotalBill();

        }
    }
}
