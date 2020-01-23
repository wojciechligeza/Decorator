using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car compactCar = new CompactCar();
            compactCar = new Navigation(compactCar);
            compactCar = new Sunroof(compactCar);
            compactCar = new LeatherSeats(compactCar);

            Console.WriteLine(compactCar.GetDescription());
            Console.WriteLine($"{compactCar.GetCarPrice():C2}");
            Console.ReadKey();
        }
    }
}
