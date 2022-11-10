using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Interfaces;

namespace VisitorDesignPattern.Classes
{
    public class QuoteVisitor : IVisitor
    {
        public void VisitorBikeInsurance(BikeInsurance element)
        {
            Console.WriteLine($"Get Bike Incurance Quote is{element.GetType()}");
        }

        public void VisitorCarInsurance(CarInsurance element)
        {
            Console.WriteLine($"Get Car Incurance Quote is{element.GetType()}");
        }
    }
    public class CommunicationVisitor : IVisitor
    {
        public void VisitorBikeInsurance(BikeInsurance element)
        {
            Console.WriteLine("Email/SMS sent to the Bike Owner");
        }

        public void VisitorCarInsurance(CarInsurance element)
        {
            Console.WriteLine("SMS/Email sent to the car owner");
        }
    }
}
