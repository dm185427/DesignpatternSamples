using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Interfaces;

namespace VisitorDesignPattern.Classes
{
	public class CarInsurance:IIncurance
    {
        public string RegistrationNumber { get; set; }
        public string PostCode { get; set; }
        public string Model { get; set; }
        public bool IsLeftHandDrive { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitorCarInsurance(this);
        }
    }
    public class BikeInsurance : IIncurance
    {
        public string RegistrationNumber { get; set; }
        public string PostCode { get; set; }
        public string Model { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitorBikeInsurance(this);
        }
    }
}
