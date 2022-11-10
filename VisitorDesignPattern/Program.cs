using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Classes;

namespace VisitorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bikeInsurance = new BikeInsurance();
            var carInsurance = new CarInsurance();
            var quote = new QuoteVisitor();
            var communication = new CommunicationVisitor();
            bikeInsurance.Accept(quote);
            carInsurance.Accept(quote);
            bikeInsurance.Accept(communication);
            carInsurance.Accept(communication);
            Console.ReadLine();
        }
    }
}
