using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Navigation: CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Nawigacja";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 5000;
    }
}
