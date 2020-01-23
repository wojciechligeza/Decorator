using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            Description = "Samochód klasy średniej";
        }

        public override double GetCarPrice() => 20000.00;
        public override string GetDescription() => Description;
    }
}
