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

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}"); // Printing the values of the fields of car
        }
    }
}
