using System;
using System.Runtime.ConstrainedExecution;


namespace Praktyki.zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford Focus", "Blue", 85000, "Ford", 2018, 1.5);
            Car car2 = new Car("Toyota Corolla", "Red", 120000, "Toyota", 2015, 1.8 );

            Console.WriteLine($"Car 1: {car1.Model}, {car1.Color}, {car1.Mileage}km, {car1.Brand}, {car1.YearOfProduction}, {car1.EngineSize}L");
            Console.WriteLine($"Car 2: {car2.Model}, {car2.Color}, {car2.Mileage}km, {car2.Brand}, {car2.YearOfProduction}, {car2.EngineSize}L");
        }
    }
}