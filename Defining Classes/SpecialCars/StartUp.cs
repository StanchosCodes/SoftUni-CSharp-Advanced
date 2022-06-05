using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car(); // Initialising a new object car of class Car

            //car.Make = "Alfa Romeo"; // Setting a value to make
            //car.Model = "156"; // Setting a value to model
            //car.Year = 2004; // Setting a value to year
            //car.FuelQuantity = 62;
            //car.FuelConsumption = 0.045; // 4.5/100km -> 0.45/10km -> 0.045/1km

            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine();

            //car.Drive(1000);
            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine();

            //Car defaultCar = new Car();

            //Console.WriteLine(defaultCar.WhoAmI());
            //Console.WriteLine();

            //Car defaultCarWithMakeAndModel = new Car("Skoda", "Octavia", 2009);

            //Console.WriteLine(defaultCarWithMakeAndModel.WhoAmI());
            //Console.WriteLine();

            //Car defaultCarWithMakeModelAndYear = new Car("Skoda", "Octavia", 2009, 62, 0.04);

            //Console.WriteLine(defaultCarWithMakeModelAndYear.WhoAmI());
            //Console.WriteLine();

            //Tire[] tires = new Tire[4]
            //{
            //    new Tire(2018, 2.2),
            //    new Tire(2018, 2.4),
            //    new Tire(2018, 2.5),
            //    new Tire(2018, 2.6)
            //};

            //Engine engine = new Engine(560, 6300);

            //Car labrghini = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            //Console.WriteLine(labrghini.WhoAmI());
            //Console.WriteLine();

            List<string> tiresInfo = new List<string>();
            List<string> enginesInfo = new List<string>();
            List<Car> carsList = new List<Car>();

            string tiresCommand;
            while ((tiresCommand = Console.ReadLine()) != "No more tires")
            {
                string currTire = string.Empty;
                for (int i = 0; i < tiresCommand.Split().Length; i += 2)
                {
                    currTire = tiresCommand.Split()[i] + " " + tiresCommand.Split()[i + 1];
                    // 0 1 2 3 4 5 6 7 -> (i = 0) 0 1, (i = 2) 2 3, (i = 4) 4 5, (i = 6) 6 7, (i = 8) break;

                    tiresInfo.Add(currTire);
                }

            }

            string enginesCommand;
            while ((enginesCommand = Console.ReadLine()) != "Engines done")
            {
                enginesInfo.Add(enginesCommand);
            }

            string carsCommand;
            while ((carsCommand = Console.ReadLine()) != "Show special")
            {
                string carMake = carsCommand.Split()[0];
                string carModel = carsCommand.Split()[1];
                int carYear = int.Parse(carsCommand.Split()[2]);
                double carFuelQnt = double.Parse(carsCommand.Split()[3]);
                double carFuelCnsp = double.Parse(carsCommand.Split()[4]);
                int carEngineIndex = int.Parse(carsCommand.Split()[5]);
                int carTiresIndex = int.Parse(carsCommand.Split()[6]);

                string carEngine = enginesInfo[carEngineIndex];
                string carTire = tiresInfo[carTiresIndex];

                int horsePower = int.Parse(carEngine.Split()[0]);
                double cubicCapacity = double.Parse(carEngine.Split()[1]);

                int tireYear = int.Parse(carTire.Split()[0]);
                double pressure = double.Parse(carTire.Split()[1]);

                Engine currEngine = new Engine(horsePower, cubicCapacity);
                Tire currTire = new Tire(tireYear, pressure);

                carsList.Add(new Car(carMake, carModel, carYear, carFuelQnt, carFuelCnsp, currEngine, currTire));
            }

            List<Car> specialCars = new List<Car>();

            foreach (var car in carsList)
            {
                double sumPressure = car.Tires.Pressure * 4;
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && sumPressure >= 9)
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }

            if (specialCars.Any())
            {
                foreach (var car in specialCars)
                {
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}