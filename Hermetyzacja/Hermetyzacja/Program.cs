using System;
using static System.Console;
using static System.DateTime;
namespace Hermetyzacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empty");
            constructorChainning constructor0 = new constructorChainning();
            Console.WriteLine("\n\nSimple int");
            constructorChainning constructor = new constructorChainning(20);
            Console.WriteLine("\n\nSimple string");
            constructorChainning constructor1 = new constructorChainning("text");
            Console.WriteLine("\n\nint and string");
            constructorChainning constructor2 = new constructorChainning(20,"text");
           
            Car car = new Car("audi",220,1);
            Car car1 = new Car("Mercedes",250,2000);
            Car.numberOfCarProduced++;
            Car.numberOfCarProduced++;
            Console.WriteLine("Year production"+Car.year_of_production);
            Console.WriteLine("Car vin"+car.Vin);
            Console.WriteLine("Car vin"+car1.Vin);
            Console.WriteLine("Car name {0} and car speed {1}",car.Name,car.SpeedCar);
            Console.WriteLine($"Number of car production {Car.numberOfCarProduced}");
            CarGarage carGarage = new CarGarage();
            carGarage.MyAuto = car1;
            Console.WriteLine($"Number of cars in garage {carGarage.numberOfCarsInGarage}");
            Console.WriteLine($"My auto in garage {carGarage.MyAuto.Name}");
            Console.WriteLine($"Number of wheels must be {car.numberWheels}");
            PartialClass partial = new PartialClass(1);
            Console.WriteLine( partial.NumberOne);
            Console.WriteLine("Mileage",car.mileage);
            Console.ReadKey();
        }
    }
}
