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
            Console.WriteLine();

            car.Drive(1000);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            Car defaultCar = new Car();

            Console.WriteLine(defaultCar.WhoAmI());
            Console.WriteLine();

            Car defaultCarWithMakeAndModel = new Car("Skoda", "Octavia", 2009);

            Console.WriteLine(defaultCarWithMakeAndModel.WhoAmI());
            Console.WriteLine();

            Car defaultCarWithMakeModelAndYear = new Car("Skoda", "Octavia", 2009, 62, 0.04);

            Console.WriteLine(defaultCarWithMakeModelAndYear.WhoAmI());
            Console.WriteLine();

            Tire[] tires = new Tire[4]
            {
                new Tire(2018, 2.2),
                new Tire(2018, 2.4),
                new Tire(2018, 2.5),
                new Tire(2018, 2.6)
            };

            Engine engine = new Engine(560, 6300);

            Car labrghini = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine(labrghini.WhoAmI());
            Console.WriteLine();
        }
    }
}