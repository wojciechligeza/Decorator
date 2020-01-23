using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Skórzana tapicerka";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
