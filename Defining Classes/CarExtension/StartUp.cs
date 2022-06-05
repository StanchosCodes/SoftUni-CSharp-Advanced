using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // Initialising a new object car of class Car

            car.Make = "Alfa Romeo"; // Setting a value to make
            car.Model = "156"; // Setting a value to model
            car.Year = 2004; // Setting a value to year
            car.FuelQuantity = 62;
            car.FuelConsumption = 0.045; // 4.5/100km -> 0.45/10km -> 0.045/1km

            Console.WriteLine(car.WhoAmI());

            car.Drive(1000);
            Console.WriteLine(car.WhoAmI());
            
        }
    }
}