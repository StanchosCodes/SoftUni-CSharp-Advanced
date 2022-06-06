using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string[] carInfoArr = carInfo.Split();

                string model = carInfoArr[0];
                int speed = int.Parse(carInfoArr[1]);
                int power = int.Parse(carInfoArr[2]);
                int weight = int.Parse(carInfoArr[3]);
                string type = carInfoArr[4];
                double tire1Pressure = double.Parse(carInfoArr[5]);
                double tire1Age = double.Parse(carInfoArr[6]);
                double tire2Pressure = double.Parse(carInfoArr[7]);
                double tire2Age = double.Parse(carInfoArr[8]);
                double tire3Pressure = double.Parse(carInfoArr[9]);
                double tire3Age = double.Parse(carInfoArr[10]);
                double tire4Pressure = double.Parse(carInfoArr[11]);
                double tire4Age = double.Parse(carInfoArr[12]);


                Car newCar = new Car(model, new Engine(speed, power), new Cargo(type, weight), new Tires(new List<double> { tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire2Pressure, tire3Age, tire4Pressure, tire4Age}));

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "fragile" && car.Tires.TiresList.Any(tire => tire < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flammable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
