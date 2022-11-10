using VisitorDesignPattern.Classes;

namespace VisitorDesignPattern.Interfaces
{
    public interface IIncurance
    {
        void Accept(IVisitor visitor);
    }
    public interface IVisitor
    {
        void VisitorCarInsurance(CarInsurance element);
        void VisitorBikeInsurance(BikeInsurance element);
    }

}

