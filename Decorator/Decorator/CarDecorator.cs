using Decorator.Component;

namespace Decorator.Decorator
{
    public class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();
        public override string GetDescription() => _car.GetDescription();
    }
}
