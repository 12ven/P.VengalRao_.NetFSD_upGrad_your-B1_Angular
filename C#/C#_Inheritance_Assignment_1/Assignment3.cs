using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment3
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Shipping;
        public virtual double CalculateShippingCost()
        {
            return Shipping = 50;
        }
    }
    class StandardOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping = 50;
        }
    }
    class ExpressOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping = 100;
        }
    }
    class InternationalOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping = 500;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order standard = new StandardOrder();
            Order express = new ExpressOrder();
            Order international = new InternationalOrder();

            Console.WriteLine("Standard Order Shipping Cost: " + standard.CalculateShippingCost());
            Console.WriteLine("Express Order Shipping Cost: " + express.CalculateShippingCost());
            Console.WriteLine("International Order Shipping Cost: " + international.CalculateShippingCost());

            Console.ReadLine();
        }
    }

}
