using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string currCarInfo = Console.ReadLine();

                string model = currCarInfo.Split()[0];
                double fuelAmount = double.Parse(currCarInfo.Split()[1]);
                double fuelConsumptionPerKm = double.Parse(currCarInfo.Split()[2]);

                cars.Add(new Car (model, fuelAmount, fuelConsumptionPerKm));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string carModel = command.Split()[1];
                int amountOfKm = int.Parse(command.Split()[2]);

                cars.Find(car => car.Model == carModel).Drive(amountOfKm);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
