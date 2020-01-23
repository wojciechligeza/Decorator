using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Samochód klasy wyższej";
        }

        public override double GetCarPrice() => 30000.00;
        public override string GetDescription() => Description;
    }
}
