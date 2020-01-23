using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Samochód kompaktowy";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }
}
